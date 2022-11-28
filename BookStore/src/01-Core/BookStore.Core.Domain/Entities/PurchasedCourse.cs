using System;
using System.Text.Json.Serialization;

namespace BookStore.Core.Domain.Entities
{
    public class PurchasedCourse : BaseEntity
    {
        [JsonIgnore]
        public long CourseId { get; set; }

        public Course Course { get; set; }

        [JsonIgnore]
        public long CustomerId { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime? ExpirationDate { get; set; }
    }
}
