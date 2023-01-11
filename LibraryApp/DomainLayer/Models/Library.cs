using DomainLayer.Common;


namespace DomainLayer.Models
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
    }
}
