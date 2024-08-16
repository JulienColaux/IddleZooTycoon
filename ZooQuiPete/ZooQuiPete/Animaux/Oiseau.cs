using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    internal class Oiseau : Animal
    {
        #region Ctor
        public Oiseau()
        {
            Type = "V";
            Prix = 350;
        } 
        #endregion
    }
}
