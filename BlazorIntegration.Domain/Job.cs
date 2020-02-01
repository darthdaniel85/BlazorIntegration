using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorIntegration.Domain
{
    public class Job
    {
        /*
         *   ,[Number]
      ,[Lead.Id]
      ,[Campaign.Id]
      ,[BusinessUnit.Id]
      ,[Customer.Id]
      ,[CallScriptAnswerRecord.Id]
      ,[Location.Id]
      ,[Type.Id]
      ,[RecallFor.Id]
      ,[WarrantyFor.Id]
      ,[Priority]
      ,[Start]
      ,[End]
      ,[Duration]
      ,[Status]
      ,[Summary]
      ,[Total]
         */
         
        public int Id { get; set; }
        public Customer Customer { get; set; }
    }
}
