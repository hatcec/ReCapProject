using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string CompanyName { get; set; }
    }
}
