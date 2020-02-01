using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorIntegration.Domain
{
    public class Customer
    {
        /*
       ,[Name]
      ,[Header]
      ,[Address.Street]
      ,[Address.Unit]
      ,[Address.City]
      ,[Address.State]
      ,[Address.Zip]
      ,[Address.Country]
      ,[Address.Latitude]
      ,[Address.Longitude]
      ,[Address.IsMilitary]
      ,[Balance]*/

        public int Id { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
