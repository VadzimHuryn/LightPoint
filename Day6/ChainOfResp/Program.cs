using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient(false, false, false, true, false);
            Doctor ophtalmologist = new Ophtalmologist();
            Doctor otorhinolaryngologist = new Otorhinolaryngologist();
            Doctor surgeon = new Surgeon();
            surgeon.NextDoctor = otorhinolaryngologist;
            otorhinolaryngologist.NextDoctor = ophtalmologist;

            surgeon.Complaints(patient);
            Console.ReadKey();
        }
    }
}
