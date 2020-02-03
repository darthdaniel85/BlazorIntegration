using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorIntegration.Domain
{
    public class Job
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Priority { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public decimal Total { get; set; }

        public Customer Customer { get; set; }
    }
}
