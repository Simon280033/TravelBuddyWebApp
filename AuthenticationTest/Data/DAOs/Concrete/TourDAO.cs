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
                List<Tuple<int, int>> tourIdsAndIndexes = new List<Tuple<int, int>>();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        int tourId = (int) Int32.Parse(sdr["language_code"].ToString());
                        
                        // If we haven't already created this tour, we add it
                        if (!tourIdsAdded.Contains(tourId))
                        {
                            Tour tour = new Tour
                            {
                                Id = (int) Int32.Parse(sdr["language_code"].ToString()),
                                CompanyId = (int) Int32.Parse(sdr["language_code"].ToString()),
                                ImageBase64 = sdr["language_code"].ToString()
                            };
                            // And add it to the lists
                            tourIdsAdded.Add(tourId);
                            tourIdsAndIndexes.Add(new Tuple<int, int>(tourId, tourIdsAndIndexes.Count-1));
                            tours.Add(tour);
                        }
                        
                        // We get the tour for the row
                        Tour tourToWork = tours[tourIdsAndIndexes[tourIdsAdded.IndexOf(tourId)].Item2];
                        
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
                                TourName = sdr["language_code"].ToString(),
                                TourDescription = sdr["language_code"].ToString()
                            };
                            // And add it to the tour
                            tourToWork.Variants.Add(variant);
                        }
                        
                        // We create the sight variant
                        SightVariant sightVariant = new SightVariant
                        {
                            Language = language,
                            AudioBase64 = sdr["language_code"].ToString(),
                            AudioFileName = sdr["language_code"].ToString(),
                            SightDescription = sdr["language_code"].ToString(),
                            SightName = sdr["language_code"].ToString()
                        };
                        
                        // Sight
                        int sightId = (int) Int32.Parse(sdr["language_code"].ToString());
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
                                Id = (int) Int32.Parse(sdr["language_code"].ToString()),
                                ImageBase64 = sdr["language_code"].ToString(),
                                Latitude = (double) Double.Parse(sdr["language_code"].ToString()),
                                Longitude = (double) Double.Parse(sdr["language_code"].ToString()),
                                RadiusInMeters = (int) Int32.Parse(sdr["language_code"].ToString()),
                                TourId = tourToWork.Id,
                                Variants = new List<SightVariant>()
                            };
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