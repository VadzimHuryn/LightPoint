using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4WebApiCRUD.Models
{
    public class Railcar
    {
        public Railcar()
        {
            Places = new HashSet<Place>();
        }
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int RailcarNum { get; set; }

        public virtual Train Train { get; set; }

        public virtual ICollection<Place> Places { get; set; }
    }
}
