using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Rangee
    {
        private Section[] _sections = new Section[2];

        public Rangee(int _taille)
        {
            if(_taille%2 == 1)
            {
                throw new ArgumentException("La taille des rangées doit être paire");
            }
            for(int i = 0; i < 2; i++)
            {
                _sections[i] = new Section(_taille/2);
            }
        }
        public bool AjouterPassager(Personne personne)
        {
            for (int i = 0; i < _sections.Length; i++)
            {
                if (_sections[i].AjouterPassager(personne))
                {
                    return true;
                }
            }
            return false;
        }
        public Personne? DebarquerPassager()
        {
            Personne? retour;
            for (int i = _sections.Length - 1; i >= 0; i--)
            {
                retour = _sections[i].DebarquerPassager();
                if (retour != null)
                {
                    return retour;
                }
            }
            return null;
        }
    }
}
