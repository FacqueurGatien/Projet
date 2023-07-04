using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEListBox2Model
{
    [Serializable]
    public class FichierPays : Fichier , IComparable<FichierPays>
    {
        private string nomPays;
        private string capitale;
        public FichierPays(string _nomPays,string _capitale)
        {
            nomPays = _nomPays;
            capitale = _capitale;
            base.Nom=nomPays;
        }
        public string NomPays { get => nomPays; }
        public string Capitale { get => capitale; }


        /*public override string ToString()
        {
            string temp = string.Format("{0,11}{1,0}\n","Nom : ", NomPays);
            temp += string.Format("{0,11}{1,0}\n", "Capitale : ", Capitale);
            return base.ToString()+"\n"+temp;
        }*/
        public int CompareTo(FichierPays? other)
        {
            return NomPays.CompareTo(other.NomPays);
            throw new NotImplementedException();
        }

        public override string afficher()
        {
            return ToString();
        }
    }
}
