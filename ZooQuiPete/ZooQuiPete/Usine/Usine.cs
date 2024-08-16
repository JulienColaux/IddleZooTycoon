using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    internal class Usine
    {
        #region Fields
        private double _production;
        private double _prixAmelioration;
        private string _typeNouriture;
        #endregion

        #region Accesseurs
        public double Production { get => _production; set => _production = value; }
        public double PrixAmelioration { get => _prixAmelioration; set => _prixAmelioration = value; }
        public string TypeNouriture { get => _typeNouriture; set => _typeNouriture = value; } 
        #endregion
    }
}
