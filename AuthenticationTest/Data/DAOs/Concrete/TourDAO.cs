using System;
using System.Collections.Generic;
using System.Data;
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
            OpenConnIfClosed();
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
                                Latitude = (double) Double.Parse(sdr["latitude"].ToString().Replace(".", ",")),
                                Longitude = (double) Double.Parse(sdr["longitude"].ToString().Replace(".", ",")),
                                RadiusInMeters = (int) Int32.Parse(sdr["radius_in_meters"].ToString()),
                                TourId = tourToWork.Id,
                                Variants = new List<SightVariant>()
                            };
                            Console.WriteLine("Lat: " + (double) Double.Parse(sdr["latitude"].ToString().Replace(".", ",")));
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
            OpenConnIfClosed();
            Console.WriteLine("Attempting to create tour...");
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                // We add the tour itself
                command.CommandText = "INSERT INTO travelbuddy.Tours VALUES(DEFAULT, @companyId, @imageBase64);";
                command.Connection = conn;
                command.Parameters.AddWithValue("companyId", tour.CompanyId);
                command.Parameters.AddWithValue("imageBase64", tour.ImageBase64);
                command.Prepare();
                command.ExecuteNonQuery();
                command.Cancel();
                command.Dispose();
                Console.WriteLine("Created tour! Attempting to create " + tour.Variants.Count + " variants...");
            }
            // We then add any variants
                for (int i = 0; i < tour.Variants.Count; i++)
                {
                    CreateVariant(tour.CompanyId, tour.Variants[i]);
                }
                conn.Close();
                Console.WriteLine("Successfully created tour!");
        }

        private void CreateVariant(int companyId, TourVariant variant)
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    // We get the highest ID for the customer, as this will be the newliest created
                    command.CommandText =
                        "INSERT INTO travelbuddy.Tour_variants VALUES((SELECT tour_id FROM travelbuddy.tours WHERE company_id = @companyId ORDER BY tour_id DESC LIMIT 1), @languageCode, @tourName, @tourDescription);";
                    command.Connection = conn;
                    command.Parameters.AddWithValue("companyId", companyId);
                    command.Parameters.AddWithValue("languageCode", variant.Language.LanguageCode);
                    command.Parameters.AddWithValue("tourName", variant.TourName);
                    command.Parameters.AddWithValue("tourDescription", variant.TourDescription);
                    command.Prepare();
                    command.ExecuteNonQuery();
                    command.Cancel();
                    command.Dispose();
                    Console.WriteLine("Created variant for language '" + variant.Language.LanguageName +
                                      "'!");
                }
                conn.Close();
        }

        public void updateTour(Tour tour)
        {
           Console.WriteLine("Attempting to update tour...");
           OpenConnIfClosed();
           using (NpgsqlCommand command = new NpgsqlCommand())
            {
                // We get the current variants
                List<string> variantCodes = new List<string>();
                command.CommandText = "SELECT language_code FROM travelbuddy.tour_variants WHERE tour_id = @tourId;";
                command.Parameters.AddWithValue("tourId", tour.Id);
                command.Connection = conn;
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

        public List<Tour> getToursForCompany(int companyId)
        {
            OpenConnIfClosed();
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
                                      "travelbuddy.Tours.company_id = @companyId;";
                
                command.Connection = conn;
                command.Parameters.AddWithValue("companyId", companyId);
                command.Prepare();
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
                            Console.WriteLine("Tour " + tourId + " added");
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
                        // If there is no sight, we skip the rest
                        if (sdr["sight_id"].ToString().Length > 0)
                        {
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
                                Latitude = (double) Double.Parse((string) sdr["latitude"]),
                                Longitude = (double) Double.Parse((string)sdr["longitude"]),
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
                                // We check if the language has been added
                                bool added = false;
                                foreach (SightVariant variant in sight.Variants)
                                {
                                    if (variant.SightName.Equals(sightVariant.SightName) || variant.Language.LanguageCode.Equals(language.LanguageCode))
                                    {
                                        added = true;
                                        break;
                                    }
                                }
                                if (!added)
                                {
                                    sight.Variants.Add(sightVariant);
                                    break;
                                }
                            }
                        }
                        }
                    }
                }
                conn.Close();
                // We check if each sight has a variant for each tour variant
                for (int i = 0; i < tours.Count; i++)
                {
                    List<string> tourLanguageCodes = new List<string>();
                    List<Language> tourLanguages = new List<Language>();
                    foreach (TourVariant variant in tours[i].Variants)
                    {
                        tourLanguageCodes.Add(variant.Language.LanguageCode);
                        tourLanguages.Add(variant.Language);
                    }
                    // We go over each sight
                    foreach (Sight sight in tours[i].Sights)
                    {
                        List<string> sightLanguages = new List<string>();
                        // We add all variants to the list
                        foreach (SightVariant variant in sight.Variants)
                        {
                            sightLanguages.Add(variant.Language.LanguageCode);
                        }
                        // We go through each tour language, and check if one exists for the sight
                        foreach (string tourLang in tourLanguageCodes)
                        {
                            if (!sightLanguages.Contains(tourLang))
                            {
                                int indexOfLang = 0;
                                indexOfLang = tourLanguageCodes.IndexOf(tourLang);
                                // If it isn't there, we add a dummy
                                sight.Variants.Add(new SightVariant
                                {
                                    Language = new Language
                                    {
                                        LanguageCode = tourLanguages[indexOfLang].LanguageCode,
                                        LanguageName = tourLanguages[indexOfLang].LanguageName
                                    },
                                    SightName = "Untitled " + tourLanguages[indexOfLang].LanguageName + " version of '" + sight.Variants[0].SightName + "'"
                                });
                            }
                        }
                    }
                }
                // Now we make sure that they all have the same amount of tour variants
                int highestAmount = 0;
                foreach (Tour tour in tours)
                {
                    if (tour.Variants.Count > highestAmount)
                    {
                        highestAmount = tour.Variants.Count;
                    }
                }
                foreach (Tour tour in tours)
                {
                    while (tour.Variants.Count < highestAmount)
                    {
                       tour.Variants.Add(new TourVariant());
                    }
                }
                return tours;
            }
        }

        public Tour getTourById(int tourId)
        {
            Tour tour = new Tour();
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM " +
                                      "travelbuddy.Tours " +
                                      "LEFT JOIN " +
                                      "travelbuddy.Tour_variants " +
                                      "ON " +
                                      "travelbuddy.Tours.tour_id = travelbuddy.Tour_variants.tour_id " +
                                      "LEFT JOIN " +
                                      "travelbuddy.Languages " +
                                      "ON " +
                                      "travelbuddy.Languages.language_code = travelbuddy.Tour_variants.language_code " +
                                      "WHERE " +
                                      "travelbuddy.Tours.tour_id = @tourId;";
                command.Parameters.AddWithValue("tourId", tourId);
                command.Connection = conn;
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        TourVariant variant = new TourVariant
                        {
                            Language = new Language
                            {
                                LanguageCode = sdr["language_code"].ToString(),
                                LanguageName = sdr["language_name"].ToString()
                            },
                            TourName = "tour_name",
                            TourDescription = "tour_description"
                        };

                        if (tour.Id == 0)
                        {
                            tour.Id = (int) Int32.Parse(sdr["tour_id"].ToString());
                            tour.CompanyId = (int)Int32.Parse(sdr["company_id"].ToString());
                            tour.ImageBase64 = sdr["tour_image"].ToString();
                        }
                        
                        tour.Variants.Add(variant);
                    }
                }
                conn.Close();
            }
            return tour;
        }

        private void OpenConnIfClosed()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}