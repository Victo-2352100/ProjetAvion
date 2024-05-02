using System;

namespace Bibliotheque
{
    /// <summary>
    /// Repr�sente le si�ge de l'avion en fonction de son passager
    /// </summary>
    public class Siege
    {
        private Personne? _personne;
        /// <summary>
        /// Ajoute un passager � la place du si�ge s'il est vide.
        /// </summary>
        /// <param name="personne">La personne � ajouter.</param>
        /// <returns>Si l'ajout s'est bien effectu� (si le si�ge �tait libre).</returns>
        public bool AjouterPassager(Personne personne)
        {
            if(_personne == null)
            {
                _personne = personne;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Retire le passager.
        /// </summary>
        /// <returns>Le passager retir�. Null s'il n'y en avait pas.</returns>
        public Personne? DebarquerPassager()
        {
            Personne? retour = _personne;
            _personne = null;
            return retour;
        }
        public override string ToString()
        {
            if (_personne == null) return " ";
            return _personne.Nom[0].ToString();
        }
    }
}