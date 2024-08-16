using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    internal class Parking
    {
        #region Fields
        private int _nombreDePlace;
        private double _prixAmelioration;
        #endregion

        #region Accesseurs
        public int NombreDePlace { get => _nombreDePlace; set => _nombreDePlace = value; }
        public double PrixAmelioration { get => _prixAmelioration; set => _prixAmelioration = value; } 
        #endregion

        #region Ctor
        public Parking()
        {
            NombreDePlace = 50;
            PrixAmelioration = 500;
        }
        #endregion

    }
}
