using System;

namespace Bibliotheque
{
    public class Siege
    {
        private string _classe;
        private Personne _personne;
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
        /// <returns>Le passager retiré. Null s'il n'y en avait pas.</returns>
        public Personne DebarquerPassager()
        {
            Personne retour = _personne;
            _personne = null;
            return retour;
        }
    }
}
