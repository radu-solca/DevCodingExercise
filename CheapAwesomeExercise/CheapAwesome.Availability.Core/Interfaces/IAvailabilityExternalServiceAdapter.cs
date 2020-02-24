using System.Collections.Generic;

namespace CheapAwesome.Availability.Core.Interfaces
{
    public interface IAvailabilityExternalServiceAdapter
    {
        IEnumerable<Domain.Availability> GetAvailabilities(int destinationId, int numberOfNights, string authToken);
    }
}
