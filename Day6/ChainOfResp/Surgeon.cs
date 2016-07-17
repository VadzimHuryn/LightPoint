using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Surgeon:Doctor
    {
        public override void Complaints(Patient patient)
        {
            Console.WriteLine("Пришли к хирургу");
            if (patient.InternalOrgans == true)
            {
                Console.WriteLine("Проводим операцию");
            }
            else if (NextDoctor != null)
            {
                Console.WriteLine("Вали к другому доктору! Я по другой части!");
                NextDoctor.Complaints(patient);
            }
        }
    }
}
