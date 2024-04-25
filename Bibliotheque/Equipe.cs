using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Equipe
    {
        private Employe _pilote;
        private Employe _copilote;
        private Employe _ingenieur;
        private Employe[] _agentBord;

        public Equipe(Employe pilote, Employe copilote, Employe ingenieur, Employe agent1, Employe agent2, Employe agent3)
        {
            _pilote = pilote;
            _copilote = copilote;
            _ingenieur = ingenieur;
            _agentBord = new Employe[3];
            _agentBord[0] = agent1;
            _agentBord[1] = agent2;
            _agentBord[2] = agent3;
        }
    }
}
