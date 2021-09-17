using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Driver : BaseEntity
    {
        public string DriverName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

    }
}
