using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente une section de trois sièges
    /// </summary>
    public class Section
    {
        private Siege[] _sieges;

        public Section(int taille)
        {
            if (taille < 1) throw new ArgumentException("La taille verticale doit être plus grande que 0.");

            _sieges = new Siege[taille];
            for(int i=0; i< taille; i++)
            {
                _sieges[i] = new Siege();
            }
        }
        public bool AjouterPassager(Personne personne)
        {
            for (int i = 0; i < _sieges.Length; i++)
            {
                if (_sieges[i].AjouterPassager(personne))
                {
                    return true;
                }
            }
            return false;
        }
        public Personne? DebarquerPassager()
        {
            Personne? retour;
            for (int i = _sieges.Length - 1; i >= 0; i--)
            {
                retour = _sieges[i].DebarquerPassager();
                if (retour != null)
                {
                    return retour;
                }
            }
            return null;
        }
    }
}
