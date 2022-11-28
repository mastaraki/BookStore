using Newtonsoft.Json;

namespace BookStore.Core.Domain.Dtos
{
    public class PurchasedCourseDto
    {
        [JsonIgnore]
        public long CourseId { get; set; }

        public CourseDto Course { get; set; }

        [JsonIgnore]
        public long CustomerId { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime? ExpirationDate { get; set; }
    }
}
