using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente une personne ainsi que quelques-unes de ses propriétés.
    /// </summary>
    public class Personne
    {
        private string _nom;
        int? _age;

        public Personne(string nom)
        {
            _nom = nom;
        }
    }
}
