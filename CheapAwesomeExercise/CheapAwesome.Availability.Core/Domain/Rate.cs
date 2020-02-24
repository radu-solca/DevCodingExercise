namespace CheapAwesome.Availability.Core.Domain
{
    public class Rate
    {
        public RateTypes RateType { get; set; }
        public BoardTypes BoardType { get; set; }
        public double Value { get; set; }
    }
}