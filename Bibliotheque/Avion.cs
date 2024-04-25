using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Avion
    {
        private Equipe _equipe;
        private Habitacle _habitacle;

        public Avion(int tailleHorizontale, int tailleVerticale)
        {
            _habitacle = new Habitacle(tailleHorizontale, tailleVerticale);
        }
        public bool AjouterPassager(Personne personne)
        {
            return _habitacle.AjouterPassager(personne);
        }
        public Personne DebarquerPassager()
        {
            
            return _habitacle.AjouterPersonne(personne);
        }
        public void Assigner(Equipe equipe)
        {
            this._equipe = equipe;
        }
    }
}
