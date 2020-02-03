using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorIntegration.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
