using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Port_classes_console
{
    class Navire
    {
        private string _noLloyds;
        private string _nomNavire;
        private string _libelleFret;
        private int _qteFret;
        public int QteFret {
            get { return _qteFret; }
            set{ _qteFret = value; }
        }
        public string LibelleFret
        {
            get
            {
                return _libelleFret;
            }
            set
            {
                _libelleFret = value;
            }
        }
        public string NomNavire
        {
            get
            {
                return _nomNavire;
            }
            set
            {
                _nomNavire = value;
            }
        }
        public string NoLloyds
        {
            get
            {
                return _noLloyds;
            }
            set
            {
                _noLloyds = value;
            }
        }
        /// <summary>
        /// Fonction qui permet de savoir si le navire est déchargé, renvoie True;
        /// </summary>
        /// <returns></returns>
        public bool EstDecharge() { return (QteFret == 0); }
        /// <summary>
        /// Fonction décharger
        /// </summary>
        /// <param name="qte"> La quantité à décharger : int</param>
        public void Decharger(int qte)
        {
            if (qte <= 0) throw new Exception("Impossible de décharger, la quantité est inférieur à 0");
            else if (qte > this.QteFret) throw new Exception(" la quantité est supérieur à la quantité disponible");
            else this.QteFret = this.QteFret - qte;
        }
        /// <summary>
        /// Constructeur de la classe Navire
        /// </summary>
        /// <param name="noLloyds"></param>
        /// <param name="nomNavire"></param>
        /// <param name="LibelleFret"></param>
        /// <param name="Qte"></param>
        public Navire(string noLloyds, string nomNavire, string LibelleFret, int Qte)
        {
            this.NoLloyds = noLloyds;
            this.NomNavire = nomNavire;
            this.QteFret = Qte;
            this.LibelleFret = LibelleFret;
        }
    }
}