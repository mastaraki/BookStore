using BookStore.Core.Domain.Entities;
using Newtonsoft.Json;

namespace BookStore.Core.Domain.Dtos
{
    public class CourseDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public LicensingModel LicensingModel { get; set; }

    }
}
