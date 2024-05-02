using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Bibliotheque
{
    /// <summary>
    /// Représente une section d'une rangée en fonction de ses sièges
    /// </summary>
    public class Section
    {
        private Siege[] _sieges;
        private bool _inverse;

        /// <summary>
        /// Constructeur permettant de créer des sièges selon la taille de la section
        /// </summary>
        /// <param name="taille">Taille de la section</param>
        /// <param name="inverse">Permet de savoir si on la remplit de la droite ou de la gauche</param>
        /// <exception cref="ArgumentException">Se lance si la taille de la section est plus petite ou égale que 0</exception>
        public Section(int taille, bool inverse)
        {
            if (taille < 1) throw new ArgumentException("La taille verticale doit être plus grande que 0.");
            this._inverse = inverse;
            _sieges = new Siege[taille];
            for (int i = 0; i < taille; i++)
            {
                _sieges[i] = new Siege();
            }
        }
        /// <summary>
        /// Constructeur de section à partir d'un tableau de sièges
        /// </summary>
        /// <param name="sieges">Tableau de classes sièges</param>
        /// <param name="inverse">Permet de savoir si on remplit la section en commencant par la gauche ou la droite</param>
        /// <exception cref="ArgumentException">Se lance si la taille de la section est plus petite ou égale que 0</exception>
        public Section(Siege[] sieges, bool inverse)
        {
            if (sieges.Length < 1) throw new ArgumentException("La taille verticale doit être plus grande que 0.");
            this._inverse = inverse;
            _sieges = sieges;
            for (int i = 0; i < sieges.Length; i++)
            {
                _sieges[i] = new Siege();
            }
        }
        /// <summary>
        /// Accesseur pour le nombre de sièges, compte le nombre total dans la section
        /// </summary>
        public int NombreSieges 
        {
            get
            {
                return _sieges.Length;
            }    
        }
        /// <summary>
        /// Accesseur pour l'inversion du remplissage des sièges
        /// </summary>
        public bool Inverse {
            get => _inverse;
        }
        /// <summary>
        /// Ajoute un passager au premier siège trouvé.
        /// </summary>
        /// <param name="personne">Le passager à ajouter.</param>
        /// <returns>Si l'ajout a bien fonctionné(Si la section n'était pas pleine).</returns>
        public bool AjouterPassager(Personne personne)
        {
            if (this.Inverse)
            {
                for (int i = _sieges.Length-1; i >= 0; i--)
                {
                    if (_sieges[i].AjouterPassager(personne))
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < _sieges.Length; i++)
                {
                    if (_sieges[i].AjouterPassager(personne))
                    {
                        return true;
                    }
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
            if(this.Inverse)
            {
                for (int i = 0; i < _sieges.Length; i++)
                {
                    retour = _sieges[i].DebarquerPassager();
                    if (retour != null)
                    {
                        return retour;
                    }
                }
            }
            else
            {
                for (int i = _sieges.Length - 1; i >= 0; i--)
                {
                    retour = _sieges[i].DebarquerPassager();
                    if (retour != null)
                    {
                        return retour;
                    }
                }
            }
            
            return null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _sieges.Length; i++)
            {
                sb.Append(_sieges[i].ToString());
                if (i < _sieges.Length - 1) sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
