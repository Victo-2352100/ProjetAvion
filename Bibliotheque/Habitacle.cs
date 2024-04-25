using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Habitacle
    {
        private Rangee[] _rangees;

        public Habitacle(int tailleHorizontale, int tailleVerticale)
        {
            if (tailleHorizontale < 1) throw new ArgumentException("La taille horizontale doit être plus grande que 0.");

            _rangees = new Rangee[tailleHorizontale];
            for (int i = 0; i < _rangees.Length ; i++)
            {
                _rangees[i] = new Rangee(tailleVerticale);
            }
        }
        public bool AjouterPassager(Personne personne)
        {
            for (int i = 0; i < _rangees.Length; i++)
            {
                if (_rangees[i].AjouterPassager(personne) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public Personne? DebarquerPassager()
        {
            Personne? retour;
            for (int i = _rangees.Length - 1; i >= 0; i--)
            {
                retour = _rangees[i].DebarquerPassager();
                if (retour != null)
                {
                    return retour;
                }
            }
            return null;
        }
    }
    
}
