using System.Collections.Generic;
using CheapAwesome.Availability.Core.Domain;
using CheapAwesome.Availability.Core.Interfaces;

namespace CheapAwesome.Availability.Core.Business
{
    public class AvailabilityService
    {
        private readonly IAvailabilityExternalServiceAdapter adapter;

        public AvailabilityService(IAvailabilityExternalServiceAdapter adapter)
        {
            this.adapter = adapter;
        }

        public IEnumerable<Domain.Availability> GetAvailabilities(int destinationId, int numberOfNights, string authToken)
        {
            var availabilities =  adapter.GetAvailabilities(destinationId, numberOfNights, authToken);
            foreach (var availability in availabilities)
            {
                foreach (var rate in availability.Rates)
                {
                    if (rate.RateType == RateTypes.PerNight)
                    {
                        rate.Value = rate.Value * numberOfNights;
                    }
                }
            }

            return availabilities;
        }
    }
}
