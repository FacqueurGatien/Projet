using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class Operation
    {
        private List<int> numList;

        public Operation()
        {
            numList = new List<int>();
        }

        public List<int> NumList { get => numList; }

        public void Vider()
        {
            numList.Clear();
        }
        public void Ajouter(int _nombre)
        {
            numList.Add(_nombre);
        }
        public void Ajouter(List<int> _nombres)
        {
            foreach (int nombre in _nombres)
            {
                Ajouter(nombre);
            }
        }
        public int ResultatAddition()
        {
            int result = 0;
            foreach (var num in numList)
            {
                result += num;
            }
            return result;
        }
    }
}
