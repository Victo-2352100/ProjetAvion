using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente un passager d'un avion.
    /// </summary>
    public class Passager : Personne
    {
        //variables à ajouter éventuellement
        /// <summary>
        /// Constructeur du passager selon le nom de la personne
        /// </summary>
        /// <param name="nom">Nom du passager</param>
        public Passager(string nom) : base(nom)
        {

        }
    }
}