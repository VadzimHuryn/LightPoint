using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4WebApiCRUD.Models
{
    public class Train
    {
        public Train()
        {
            Railcars = new HashSet<Railcar>();
        }
        public int Id { get; set; }
        public int TrainNum { get; set; }

        public virtual ICollection<Railcar> Railcars { get; set; }
    }
}
