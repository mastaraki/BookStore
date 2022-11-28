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
    public class UpdateCustomerDto
    {

        
        public string FirstName { get; set; }

      
        public string LastName { get; set; }

       
        
    }

}
