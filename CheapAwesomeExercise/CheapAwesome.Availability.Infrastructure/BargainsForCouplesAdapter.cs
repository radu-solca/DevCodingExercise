using System.Collections.Generic;
using CheapAwesome.Availability.Core.Domain;
using CheapAwesome.Availability.Core.Interfaces;

namespace CheapAwesome.Availability.Infrastructure
{
    public class BargainsForCouplesAdapter: IAvailabilityExternalServiceAdapter
    {
        /**
         * Mock for testing purposes
         */
        public IEnumerable<Core.Domain.Availability> GetAvailabilities(int destinationId, int numberOfNights, string authToken)
        {
            return new List<Core.Domain.Availability>
            {
                new Core.Domain.Availability
                {
                    Hotel = new Hotel
                    {
                        PropertyId = 79732,
                        Name = "JAC Canada (CA$)8314",
                        GeoId = destinationId,
                        Rating = 3
                    },
                    Rates = new List<Rate>
                    {
                        new Rate
                        {
                            RateType = RateTypes.PerNight,
                            BoardType = BoardTypes.NoMeals,
                            Value = 207.6
                        },
                        new Rate
                        {
                            RateType = RateTypes.PerNight,
                            BoardType = BoardTypes.HalfBoard,
                            Value = 242.2
                        },
                        new Rate
                        {
                            RateType = RateTypes.PerNight,
                            BoardType = BoardTypes.FullBoard,
                            Value = 276.8
                        }
                    }
                },

                new Core.Domain.Availability
                {
                    Hotel = new Hotel
                    {
                        PropertyId = 79821,
                        Name = "JAC Canada (CA$)8555",
                        GeoId = destinationId,
                        Rating = 3
                    },
                    Rates = new List<Rate>
                    {
                        new Rate
                        {
                            RateType = RateTypes.Stay,
                            BoardType = BoardTypes.NoMeals,
                            Value = 590.4
                        },
                        new Rate
                        {
                            RateType = RateTypes.Stay,
                            BoardType = BoardTypes.HalfBoard,
                            Value = 688.8
                        },
                        new Rate
                        {
                            RateType = RateTypes.Stay,
                            BoardType = BoardTypes.FullBoard,
                            Value = 787.2
                        }
                    }
                }
            };
        }
    }
}