using BookStore.Core.Domain.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Core.Domain.Dtos
{
    public class CustomerInListDto
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


    }

}
