
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookStore.Core.Domain.Entities
{
    public class Customer : BaseEntity
    {
        
        public string FirstName { get; set; }

     
        public string LastName { get; set; }

       
        public string Email { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerStatus Status { get; set; }

        public DateTime? StatusExpirationDate { get; set; }

        public decimal MoneySpent { get; set; }

        public IList<PurchasedCourse> PurchasedCourses { get; set; }
    }
}
