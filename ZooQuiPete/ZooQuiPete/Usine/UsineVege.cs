using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    internal class UsineVege : Usine
    {
        #region Ctor
        public UsineVege()
        {
            Production = 1;
            PrixAmelioration = 50;
            TypeNouriture = "🥬";
        } 
        #endregion
    }
}
