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
            throw new System.NotImplementedException();
        }

        public void updateTour(Tour tour)
        {
            throw new System.NotImplementedException();
        }
    }
}