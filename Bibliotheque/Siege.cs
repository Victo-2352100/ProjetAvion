using System;

namespace Bibliotheque
{
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
    }
}
