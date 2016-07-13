using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4WebApiCRUD.Models
{
    public class Place
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public int RailcarId { get; set; }
        public virtual Railcar Railcar { get; set; }
    }
}
