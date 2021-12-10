using System;
using System.Collections.Generic;
using AuthenticationTest.Data.Entities;

namespace AuthenticationTest.Data.Seeders
{
    public class TourSeeder
    {
        public static List<Tour> GetSeededToursTList(int tourAmount, int sightPerTour)
        {
            List<Tour> tours = new List<Tour>();

            for (int i = 0; i < tourAmount; i++)
            {
                Tour tour = new Tour
                {
                    Id = i,
                    CompanyId = 0,
                    ImageBase64 = "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",
                };
                
                tour.Variants.Add(new TourVariant
                {
                    Language = new Language
                    {
                        LanguageCode = "EN",
                        LanguageName = "English"
                    },
                    TourName = "Tour " + i,
                    TourDescription = "Description " + i
                });
                
                tour.Variants.Add(new TourVariant
                {
                    Language = new Language
                    {
                        LanguageCode = "DA",
                        LanguageName = "Danish"
                    },
                    TourName = "Tur " + i,
                    TourDescription = "Beskrivelse " + i
                });
                
                // We add sights
                for (int j = 0; j < sightPerTour; j++)
                {
                    Sight sight = new Sight();
                    sight.Id = j;
                    sight.Latitude = RandomNumberBetween(-90, 90);
                    sight.Longitude = RandomNumberBetween(-180, 180);

                    SightVariant variant = new SightVariant();
                    variant.Language = new Language
                    {
                        LanguageCode = "EN",
                        LanguageName = "English"
                    };
                    variant.SightName = "Sight " + j;
                    variant.SightDescription = "Description";
                    variant.AudioFileName = "file.mp3";

                    sight.Variants = new List<SightVariant>();
            
                    sight.Variants.Add(variant);
                    
                    tour.Sights.Add(sight);
                }
                tours.Add(tour);
            }

            return tours;
        }
        
        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}