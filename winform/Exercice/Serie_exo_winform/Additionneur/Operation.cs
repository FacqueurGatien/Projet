using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    public class Operation
    {
        private int result;
        private bool declencheur;

        public Operation()
        {
            result = 0;
            declencheur = false;
        }

        public int Result { get => result; }
        public bool Declencheur { get => declencheur; }

        public void Vider()
        {
            result=0;
            declencheur = false;
        }

        public void Addition(int nombre)
        {
            result+=nombre;
            declencheur=true;
        }
    }
}
