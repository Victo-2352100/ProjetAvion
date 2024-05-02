using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente un employé d'un avion.
    /// </summary>
    public class Employe: Personne
    {
        //variables à ajouter éventuellement
        /// <summary>
        /// Constructeur pour la classe employé, hérite le nom de la personne
        /// </summary>
        /// <param name="nom">Nom de l'employé et donc de la personne</param>
        public Employe(string nom) : base(nom)
        {

        }
    }
}