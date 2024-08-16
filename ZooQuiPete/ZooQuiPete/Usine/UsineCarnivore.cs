using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    internal class UsineCarnivore : Usine
    {
        #region Ctor
        public UsineCarnivore()
        {
            Production = 1;
            PrixAmelioration = 100;
            TypeNouriture = "🍖";
        } 
        #endregion
    }
}
