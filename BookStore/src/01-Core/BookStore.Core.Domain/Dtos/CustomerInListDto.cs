using BookStore.Core.Domain.Entities;
using BookStore.Core.Domain.ValueObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Core.Domain.Dtos
{
    public class CustomerInListDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? StatusExpirationDate { get; set; }
        public decimal MoneySpent { get; set; }

    }

}
