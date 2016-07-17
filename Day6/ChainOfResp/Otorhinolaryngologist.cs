using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Otorhinolaryngologist:Doctor
    {
        public override void Complaints(Patient patient)
        {
            Console.WriteLine("Пришли к ЛОРу");
            if (patient.Ear == true || patient.Nose == true || patient.Throat == true)
            {
                Console.WriteLine("Лечим уши/горло/нос");
            }
            else if (NextDoctor != null)
            {
                Console.WriteLine("Вали к другому доктору! Я по другой части!");
                NextDoctor.Complaints(patient);
            }
        }
    }
}
