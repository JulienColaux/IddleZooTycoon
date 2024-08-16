using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooQuiPete
{
    internal abstract class Animal
    {
        #region Fields

        private int _prix;
        private string _type;
        private int _revenu;
        #endregion

        #region Factories
        public int Prix { get => _prix; set => _prix = value; }
        public string Type { get => _type; set => _type = value; }
        public int Revenu { get => _revenu; set => _revenu = value; }
        #endregion
    }
}
