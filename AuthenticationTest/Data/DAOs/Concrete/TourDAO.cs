using System;
using System.Collections.Generic;
using System.Linq;
using AuthenticationTest.Data.Entities;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class TourDAO : ITourDAO
    {
        private NpgsqlConnection conn;
        
        public TourDAO(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
        
        public List<Tour> getTours()
        {
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM " +
                                      "travelbuddy.Tours " +
                                      "LEFT JOIN " +
                                      "travelbuddy.Tour_variants " +
                                      "ON " +
                                      "travelbuddy.Tours.tour_id = travelbuddy.Tour_variants.tour_id " +
                                      "LEFT JOIN " +
                                      "travelbuddy.Sights " +
                                      "ON " +
                                      "travelbuddy.Sights.tour_id = travelbuddy.Tours.tour_id " +
                                      "LEFT JOIN " +
                                      "travelbuddy.Sight_variants " +
                                      "ON " +
                                      "travelbuddy.Sight_variants.sight_id = travelbuddy.Sights.sight_id " +
                                      "LEFT JOIN " +
                                      "travelbuddy.Languages " +
                                      "ON " +
                                      "travelbuddy.Languages.language_code = travelbuddy.Tour_variants.language_code " +
                                      "WHERE " +
                                      "travelbuddy.Tour_variants.language_code = travelbuddy.Sight_variants.language_code;";
                
                command.Connection = conn;
                conn.Open();
                List<Tour> tours = new List<Tour>();
                List<int> tourIdsAdded = new List<int>();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        int tourId = (int) Int32.Parse(sdr["tour_id"].ToString());
                        
                        // If we haven't already created this tour, we add it
                        if (!tourIdsAdded.Contains(tourId))
                        {
                            Tour tour = new Tour
                            {
                                Id = tourId,
                                CompanyId = (int) Int32.Parse(sdr["company_id"].ToString()),
                                ImageBase64 = sdr["tour_image"].ToString()
                            };
                            // And add it to the lists
                            tourIdsAdded.Add(tourId);
                            tours.Add(tour);
                        }
                        
                        // We get the tour for the row
                        Tour tourToWork = tours[tourIdsAdded.IndexOf(tourId)];
                        
                        // We work from the top
                        // Language
                        Language language = new Language
                        {
                            LanguageCode = sdr["language_code"].ToString(),
                            LanguageName = sdr["language_name"].ToString()
                        };
                        // Tour variant
                        // If we haven't already created this tour, we add it
                        bool tourVariantCreated = false;
                        foreach (TourVariant variant in tourToWork.Variants)
                        {
                            if (variant.Language.LanguageCode.Equals(language.LanguageCode))
                            {
                                tourVariantCreated = true;
                                break;
                            }
                        }
                        
                        // If the tour variant is not created, we create it
                        if (!tourVariantCreated)
                        {
                            TourVariant variant = new TourVariant
                            {
                                Language = language,
                                TourName = sdr["tour_name"].ToString(),
                                TourDescription = sdr["tour_description"].ToString()
                            };
                            // And add it to the tour
                            tourToWork.Variants.Add(variant);
                        }
                        
                        // We create the sight variant
                        SightVariant sightVariant = new SightVariant
                        {
                            Language = language,
                            AudioBase64 = sdr["sight_audio"].ToString(),
                            AudioFileName = sdr["audio_file_name"].ToString(),
                            SightDescription = sdr["sight_description"].ToString(),
                            SightName = sdr["sight_name"].ToString()
                        };
                        
                        // Sight
                        int sightId = (int) Int32.Parse(sdr["sight_id"].ToString());
                        // If the sight is not already created, we create it
                        bool sightIsCreated = false;
                        foreach (Sight sight in tourToWork.Sights)
                        {
                            if (sight.Id == sightId)
                            {
                                sightIsCreated = true;
                                break;
                            }
                        }
                        
                        // If the sight is not created, we do it
                        if (!sightIsCreated)
                        {
                            Sight sight = new Sight
                            {
                                Id = sightId,
                                ImageBase64 = sdr["sight_image"].ToString(),
                                Latitude = (double) Double.Parse(sdr["latitude"].ToString()),
                                Longitude = (double) Double.Parse(sdr["longitude"].ToString()),
                                RadiusInMeters = (int) Int32.Parse(sdr["radius_in_meters"].ToString()),
                                TourId = tourToWork.Id,
                                Variants = new List<SightVariant>()
                            };
                            // We add the sight to the tour
                            tourToWork.Sights.Add(sight);
                        } 
                        
                        // We add the sight variant to the right sight
                        foreach (Sight sight in tourToWork.Sights)
                        {
                            if (sight.Id == sightId)
                            {
                                sight.Variants.Add(sightVariant);
                                break;
                            }
                        }
                    }
                }
                conn.Close();
                return tours;
            }
        }

        public void createTour(Tour tour)
        {
            Console.WriteLine("Attempting to create tour...");
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                // We add the tour itself
                command.CommandText = "INSERT INTO travelbuddy.Tours VALUES(DEFAULT, @companyId, @imageBase64);";
                command.Connection = conn;
                conn.Open();
                command.Parameters.AddWithValue("companyId", tour.CompanyId);
                command.Parameters.AddWithValue("imageBase64", tour.ImageBase64);
                command.Prepare();
                command.ExecuteNonQuery();
                command.Cancel();
                Console.WriteLine("Created tour! Attempting to create " + tour.Variants.Count + " variants...");
                // We then add any variants
                for (int i = 0; i < tour.Variants.Count; i++)
                {
                    // We get the highest ID for the customer, as this will be the newliest created
                    command.CommandText = "INSERT INTO travelbuddy.Tour_variants VALUES((SELECT tour_id FROM travelbuddy.tours WHERE company_id = @companyId ORDER BY tour_id DESC LIMIT 1)), @languageCode, @tourName, @tourDescription);";
                    command.Connection = conn;
                    conn.Open();
                    command.Parameters.AddWithValue("companyId", tour.CompanyId);
                    command.Parameters.AddWithValue("languageCode", tour.Variants[i].Language.LanguageCode);
                    command.Parameters.AddWithValue("tourName", tour.Variants[i].TourName);
                    command.Parameters.AddWithValue("tourDescription", tour.Variants[i].TourDescription);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    command.Cancel();
                    Console.WriteLine("Created variant for language '" + tour.Variants[i].Language.LanguageName + "'!");
                }
                conn.Close();
            }
            Console.WriteLine("Successfully created tour!");
        }

        public void updateTour(Tour tour)
        {
           Console.WriteLine("Attempting to update tour...");
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                // We get the current variants
                List<string> variantCodes = new List<string>();
                command.CommandText = "SELECT language_code FROM travelbuddy.tour_variants WHERE tour_id = @tourId;";
                command.Parameters.AddWithValue("tourId", tour.Id);
                command.Connection = conn;
                conn.Open();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        variantCodes.Add(sdr["language_code"].ToString());
                    }
                }
                
                // We update the tour itself
                command.CommandText = "UPDATE travelbuddy.Tours SET tour_image = @imageBase64";
                command.Connection = conn;
                command.Parameters.AddWithValue("imageBase64", tour.ImageBase64);
                command.Prepare();
                command.ExecuteNonQuery();
                command.Cancel();
                Console.WriteLine("Updated tour! Attempting to update " + tour.Variants.Count + " variants...");
                
                // We make a list of the new variants
                List<string> newVariants = new List<string>();
                // We then update any variants
                for (int i = 0; i < tour.Variants.Count; i++)
                {
                    // If it is not in the DB already, we create it
                    if (!variantCodes.Contains(tour.Variants[i].Language.LanguageCode))
                    {
                        command.CommandText = "INSERT INTO travelbuddy.Tour_variants VALUES(@tourId, @languageCode, @tourName, @tourDescription);";
                        command.Connection = conn;
                        conn.Open();
                        command.Parameters.AddWithValue("tourId", tour.Id);
                        command.Parameters.AddWithValue("companyId", tour.CompanyId);
                        command.Parameters.AddWithValue("languageCode", tour.Variants[i].Language.LanguageCode);
                        command.Parameters.AddWithValue("tourName", tour.Variants[i].TourName);
                        command.Parameters.AddWithValue("tourDescription", tour.Variants[i].TourDescription);
                        command.Prepare();
                        command.ExecuteNonQuery();
                        command.Cancel();
                        Console.WriteLine("Created variant for language '" + tour.Variants[i].Language.LanguageName + "'!");
                    }
                    else
                    {
                        // If it is already in there, we update it
                        command.CommandText = "UPDATE travelbuddy.Tour_variants SET tour_name = @tourName, tour_description = @tourDescription WHERE tour_id = @tourId AND language_code = @languageCode;";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("tourId", tour.Id);
                        command.Parameters.AddWithValue("languageCode", tour.Variants[i].Language.LanguageCode);
                        command.Parameters.AddWithValue("tourName", tour.Variants[i].TourName);
                        command.Parameters.AddWithValue("tourDescription", tour.Variants[i].TourDescription);
                        command.Prepare();
                        command.ExecuteNonQuery();
                        command.Cancel();
                        Console.WriteLine("Updated variant for language '" + tour.Variants[i].Language.LanguageName + "'!");
                    }
                    // We add language to the new list
                    newVariants.Add(tour.Variants[i].Language.LanguageCode);
                }
                // Now we check if any of the variants were deleted
                // We go through the old variants, and see if they exist in the new
                foreach (string code in variantCodes)
                {
                    if (!newVariants.Contains(code))
                    {
                        Console.WriteLine("Attempting to delete variant for language '" + code + "'...");
                        // WE NEED TO ADD ON DELETE CASCADE
                        command.CommandText = "DELETE travelbuddy.Tour_variants WHERE tour_id = @tourId AND language_code = @languageCode;";
                        command.Connection = conn;
                        command.Parameters.AddWithValue("tourId", tour.Id);
                        command.Parameters.AddWithValue("languageCode", code);
                        command.Prepare();
                        command.ExecuteNonQuery();
                        command.Cancel();
                        Console.WriteLine("Succesfully deleted variant for language '" + code + "'!");
                    }
                }
                conn.Close();
            }
            Console.WriteLine("Successfully updated tour!");        
        }
    }
}