using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Ophtalmologist:Doctor
    {
        public override void Complaints(Patient patient)
        {
            Console.WriteLine("Пришли к окулисту");
            if(patient.Eyes==true)
            {
                Console.WriteLine("Лечим глаза");
            }
            else if (NextDoctor!=null)
            {
                Console.WriteLine("Вали к другому доктору! Я по другой части!");
                NextDoctor.Complaints(patient);
            }
        }
    }
}
