using BookStore.Core.Domain.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Domain.Dtos
{
    public class CustomerDto
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام 100 کاراکتر است.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام خانوادگی 100 کاراکتر است.")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^(.+)@(.+)$", ErrorMessage = "ایمیل وارد شده قابل قبول نمی‌باشد.")]
        public string Email { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerStatus Status { get; set; }

        public DateTime? StatusExpirationDate { get; set; }

        public decimal MoneySpent { get; set; }

        public IList<PurchasedCourseDto> PurchasedCourses { get; set; }

    }

}
