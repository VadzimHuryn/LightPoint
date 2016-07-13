using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4WebApiDapper.ViewModels
{
    public class PersonWithSalesPersonModel
    {
        public string FIO { get; set; }
        public int PERSON_ID { get; set; }
        public int Sales_Person_ID { get; set; }
    }
}
