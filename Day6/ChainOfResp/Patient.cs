using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Patient
    {
        public bool Ear { get; set; }
        public bool Throat { get; set; }
        public bool Nose { get; set; }
        public bool Eyes { get; set; }
        public bool InternalOrgans { get; set; }

        public Patient(bool ear, bool throat, bool nose, bool eyes, bool internalorgans)
        {
            Ear = ear;
            Throat = throat;
            Nose = nose;
            Eyes = eyes;
            InternalOrgans = internalorgans;
        }
    }
}
