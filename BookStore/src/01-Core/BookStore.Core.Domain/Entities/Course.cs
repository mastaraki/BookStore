using System.Text.Json.Serialization;

namespace BookStore.Core.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        [JsonIgnore]
        public LicensingModel LicensingModel { get; set; }
    }
}
