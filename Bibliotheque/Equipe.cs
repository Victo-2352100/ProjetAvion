using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Classe pour une équipe de l'avion
    /// </summary>
    public class Equipe
    {
        private Employe _pilote;
        private Employe _copilote;
        private Employe _ingenieur;
        private Employe[] _agentBord;
        /// <summary>
        /// Constructeur pour une équipe d'avion
        /// </summary>
        /// <param name="pilote">Pilote de l'avion</param>
        /// <param name="copilote">Copilote de l'avion</param>
        /// <param name="ingenieur">L'ingénieur de service</param>
        /// <param name="agent1">Premier agent de bord</param>
        /// <param name="agent2">Deuxième agent de bord</param>
        /// <param name="agent3">Troisième agent debord</param>
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