using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente la rangée d'un habitacle de l'avion en fonction de ses sections
    /// </summary>
    public class Rangee
    {
        private Section[] _sections = new Section[2];
        private int _tailleVerticaleHabitacle;

        /// <summary>
        /// Constructeur de rangée en fonction de sa taille et de celle de l'habitacle le contenant
        /// </summary>
        /// <param name="tailleRangee">Taille de la rangée(paire)</param>
        /// <param name="tailleHabitacle">Taille verticale de l'habitacle</param>
        /// <exception cref="ArgumentException">Se lance si la taille des rangées est impaires ou <=0 ou > capacité</exception>
        public Rangee(int tailleRangee, int tailleHabitacle)
        {
            if (tailleRangee % 2 == 1)
            {
                throw new ArgumentException("La taille des rangées doit être paire");
            }
            if (tailleRangee > 26 || tailleRangee < 1)
            {
                throw new ArgumentException("La taille des rangées est de maximum 26");
            }
            if(tailleRangee>tailleHabitacle)
            {
                throw new ArgumentException("La taille de la rangée est plus grande que celle de l'habitable");
            }
            _sections[0] = new Section(tailleRangee / 2, false);
            _sections[1] = new Section(tailleRangee / 2, true);
            _tailleVerticaleHabitacle = tailleHabitacle;
        }
        /// <summary>
        /// Constructeur de rangée en fonction d'un tableau de Sections et de la taille de l'habitacle
        /// </summary>
        /// <param name="sec">Tableau de 2 sections</param>
        /// <param name="tailleHabitacle">Taille verticale de l'habitacle</param>
        /// <exception cref="ArgumentException">Se lance si la rangée n'a pas deux sections</exception>
        public Rangee(Section[] sec, int tailleHabitacle)
        {
            if (sec.Length != 2)
            {
                throw new ArgumentException("Une rangée doit contenir 2 sections.");
            }
            _sections = sec;
            _tailleVerticaleHabitacle = tailleHabitacle;
        }
        /// <summary>
        /// Accesseur pour le nombres de sièges, compte le nombre de sièges dans la rangée
        /// </summary>
        public int NombreSieges
        {
            get
            {
                return _sections[0].NombreSieges + _sections[1].NombreSieges;
            }
        }
        /// <summary>
        /// Accesseur pour la taille verticale de l'habitacle, existe pour notre maître à tous, Simon
        /// </summary>
        public int TailleVerticaleHabitacle {
            get => _tailleVerticaleHabitacle;
        }
        /// <summary>
        /// Ajoute un passager au premier siège trouvé.
        /// </summary>
        /// <param name="personne">Le passager à ajouter.</param>
        /// <returns>Si l'ajout a bien fonctionné(Si la rangée n'était pas pleine).</returns>
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
        /// <summary>
        /// Retire le dernier passager et le retourne.
        /// </summary>
        /// <returns>Le passager retiré. Null S'il n'y en a pas trouvé.</returns>
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int espaces = TailleVerticaleHabitacle - (_sections[0].NombreSieges + _sections[1].NombreSieges); // nombre places vides entre sections
            sb.Append(_sections[0]);
            sb.Append(' ', (espaces * 2) + 1); // nombre de ' '
            sb.Append(_sections[1]);
            return sb.ToString();
        }
    }
}
