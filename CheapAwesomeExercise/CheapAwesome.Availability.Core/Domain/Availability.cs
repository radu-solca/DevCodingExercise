using System.Collections.Generic;

namespace CheapAwesome.Availability.Core.Domain
{
    public class Availability
    {
        public Hotel Hotel { get; set; }
        public IEnumerable<Rate> Rates { get; set; }
    }
}