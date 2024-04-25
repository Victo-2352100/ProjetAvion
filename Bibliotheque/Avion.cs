using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente un avion avec ses propriétés et des méthodes implémentant ses fonctionnalités.
    /// </summary>
    public class Avion
    {
        private Equipe? _equipe;
        private Habitacle _habitacle;

        /// <summary>
        /// Construction d'un avion en fonction de sa taille en nombre de places.
        /// </summary>
        /// <param name="tailleHorizontale">Nombre de rangées.</param>
        /// <param name="tailleVerticale">Nombres de colonnes.</param>
        public Avion(int tailleHorizontale, int tailleVerticale)
        {
            _habitacle = new Habitacle(tailleHorizontale, tailleVerticale);
        }
        /// <summary>
        /// Ajoute un passager au premier siège trouvé.
        /// </summary>
        /// <param name="personne">Le passager à ajouter.</param>
        /// <returns>Si l'ajout a bien fonctionné. (Si l'avion n'était pas plein.)</returns>
        public bool AjouterPassager(Personne personne)
        {
            return _habitacle.AjouterPassager(personne);
        }
        /// <summary>
        /// Retire le dernier passager et le retourne.
        /// </summary>
        /// <returns>Le passager retiré. Null S'il n'y en a pas trouvé.</returns>
        public Personne? DebarquerPassager()
        {
            return _habitacle.DebarquerPassager();
        }
        /// <summary>
        /// Assignation d'une équipe à l'avion.
        /// </summary>
        /// <param name="equipe">L'équipe à assigner.</param>
        public void Assigner(Equipe equipe)
        {
            this._equipe = equipe;
        }
    }
}
