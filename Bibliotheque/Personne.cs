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
        /// <summary>
        /// Constructeur d'une personne selon son nom
        /// </summary>
        /// <param name="nom">Nom de la personne(surprenant)</param>
        public Personne(string nom)
        {
            _nom = nom;
        }
        /// <summary>
        /// Accesseur du nom de la personne
        /// </summary>
        public string Nom {
            get => _nom; 
        }
    }
}
