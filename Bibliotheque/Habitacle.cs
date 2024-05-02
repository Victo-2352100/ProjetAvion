using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    /// <summary>
    /// Représente l'habitacle de l'avion en fonction de l'arrangement de ses sièges
    /// </summary>
    public class Habitacle
    {
        private Rangee[] _rangees;
        private int _tailleVerticale;

        /// <summary>
        /// Constructeur de l'habitacle en fonction de sa taille verticale et horizontale
        /// </summary>
        /// <param name="tailleHorizontale">Taille horizontale de l'habitacle</param>
        /// <param name="tailleVerticale">Taille verticale de l'habitacle</param>
        /// <exception cref="ArgumentException">Se lance si la taille horizontale est plus petite ou égale à zéro</exception>
        public Habitacle(int tailleHorizontale, int tailleVerticale)
        {
            if (tailleHorizontale < 1) throw new ArgumentException("La taille horizontale doit être plus grande que 0.");

            _rangees = new Rangee[tailleHorizontale];
            for (int i = 0; i < _rangees.Length ; i++)
            {
                _rangees[i] = new Rangee(tailleVerticale, tailleVerticale);
            }
            _tailleVerticale = tailleVerticale;
        }
        /// <summary>
        /// Construction d'un habitacle selon ses rangées et sa taille verticale.
        /// </summary>
        /// <param name="rangees"></param>
        /// <param name="tailleVerticale"></param>
        public Habitacle(Rangee[] rangees, int tailleVerticale) {
            _rangees = rangees;
            _tailleVerticale = tailleVerticale;
            /*
            for (int i = 0; i < _rangees.Length ; i++) 
            {
                _rangees[i]._tailleVerticale = this._tailleVerticale;
            }
            */
        }
        /// <summary>
        /// Ajoute un passager au premier siège trouvé.
        /// </summary>
        /// <param name="personne">Le passager à ajouter.</param>
        /// <returns>Si l'ajout a bien fonctionné(Si l'habitacle n'était pas plein).</returns>
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
        /// <summary>
        /// Retire le dernier passager et le retourne.
        /// </summary>
        /// <returns>Le passager retiré. Null S'il n'y en a pas trouvé.</returns>
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', (_tailleVerticale.ToString().Length) + 1);
            // Boucle ajoutant les lettres
            for (int i = 0; i < _tailleVerticale; i++)
            {
                sb.Append((char)(i + 65));
                if (i < _tailleVerticale - 1) sb.Append(' ');
            }
            sb.Append('\n');
            // Boucle ajoutant les nombres + les rangées
            for (int i = 0; i < _rangees.Length; i++)
            {
                sb.Append($"{ i.ToString().PadLeft(_rangees.Length.ToString().Length) } { _rangees[i].ToString() }\n");
            }
            return sb.ToString();
        }

    }
}