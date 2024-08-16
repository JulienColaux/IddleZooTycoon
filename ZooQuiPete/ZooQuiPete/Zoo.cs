using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    public class Zoo
    {
        #region Fields
        private double _argent;
        private double _nouritureCarni;
        private double _nouritureVege;
        private string[,] _map;
        private Enclo _enclotSinge;
        private Enclo _enclotOiseau;
        private Enclo _enclotLion;
        private Enclo _enclotPanda;
        private Enclo _enclotPoisson;
        private Enclo _enclotPinguin;
        private Usine _usineVege;
        private Usine _usineCarnivore;
        private Parking _parking;
        #endregion

        #region Accesseurs
        public double Argent { get => _argent; set => _argent = value; }
        public double NouritureCarni { get => _nouritureCarni; set => _nouritureCarni = value; }
        public double NouritureVege { get => _nouritureVege; set => _nouritureVege = value; }
        public string[,] Map { get => _map; set => _map = value; }
        internal Enclo EnclotSinge { get => _enclotSinge; set => _enclotSinge = value; }
        internal Enclo EnclotOiseau { get => _enclotOiseau; set => _enclotOiseau = value; }
        internal Enclo EnclotLion { get => _enclotLion; set => _enclotLion = value; }
        internal Enclo EnclotPanda { get => _enclotPanda; set => _enclotPanda = value; }
        internal Enclo EnclotPoisson { get => _enclotPoisson; set => _enclotPoisson = value; }
        internal Enclo EnclotPinguin { get => _enclotPinguin; set => _enclotPinguin = value; }
        internal Usine UsineVege { get => _usineVege; set => _usineVege = value; }
        internal Usine UsineCarnivore { get => _usineCarnivore; set => _usineCarnivore = value; }
        internal Parking Parking { get => _parking; set => _parking = value; }
        #endregion

        #region Ctor

        public Zoo()
        {
            _map = InitMap();
            _argent = 200;
            _nouritureCarni= 0;
            _nouritureVege= 0;
            _enclotSinge = new Enclo("Enclo des singes",100,0,2);
            _enclotOiseau = new Enclo("Enclo des oiseaux",350,0,1);
            _enclotLion = new Enclo("Enclo des lions",1000,3,1);
            _enclotPanda = new Enclo("Enclo des pandas",1500,0,3);
            _enclotPoisson = new Enclo("Enclo des poissons",2000,0,0);
            _enclotPinguin = new Enclo("Enclo des pinguins",2500,2,0);
            _usineCarnivore = new UsineCarnivore();
            _usineVege= new UsineVege();
            _parking = new Parking();
        }
        #endregion

        #region Méthode
        public string[,] InitMap()
        {
            #region Creation Map
            string[,] map = new string[20, 42];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 41; j++)
                {
                    map[i, j] = "  ";
                }
            }

            #region Enclos general
            int x = 0;
            int y = 0;

            for (int i = 0; i < 20; i++)
            {
                map[i, 0] = "🌳";
            }

            for (int i = 0; i < 41; i++)
            {
                map[0, i] = "🌳";
            }

            for (int i = 0; i < 20; i++)
            {
                map[i, 40] = "🌳";
            }

            for (int i = 0; i < 41; i++)
            {
                map[19, i] = "🌳";
            }
            map[19, 20] = "  ";

            for (int i = 2; i < 20; i++)
            {
                map[i, 20] = "🟫";
            }

            for (int i = 10; i < 19; i++)
            {
                map[i, 25] = "🟫";
            }

            map[12, 22] = "🚽";
            map[12, 23] = "🚽";
            map[14, 22] = "🚽";
            map[14, 23] = "🚽";
            map[16, 22] = "🚽";
            map[16, 23] = "🚽";

            for (int i = 10; i < 19; i++)
            {
                map[i, 35] = "🟫";
            }
            map[11, 26] = "🚕";
            map[11, 28] = "🚎";
            map[12, 26] = "🚎";
            map[13, 30] = "🚗";
            map[15, 28] = "🚕";
            map[15, 34] = "🚗";
            map[14, 26] = "🚕";
            map[18, 28] = "🚕";
            map[16, 32] = "🚎";
            map[16, 32] = "🚕";
            map[19, 31] = "🚧";
            map[19, 29] = "🚧";
            map[19, 30] = "  ";
            map[13, 37] = "🏭";
            map[16, 37] = "🏭";
            map[13, 38] = "🥬";
            map[16, 38] = "🥩";
            for (int i = 2; i < 18; i++)
            {
                map[i, 19] = "🎋";
            }
            for (int i = 2; i < 18; i++)
            {
                map[i, 10] = "🎋";
            }

            for (int i = 1; i < 40; i++)
            {
                map[9, i] = "🎋";
            }

            for (int i = 2; i < 9; i++)
            {
                map[i, 21] = "🎋";
            }

            for (int i = 2; i < 9; i++)
            {
                map[i, 30] = "🎋";
            }

            for (int i = 2; i < 9; i++)
            {
                map[i, 39] = "🎋";
            }

            for (int i = 1; i < 40; i++)
            {
                map[1, i] = "🎋";
            }

            for (int i = 1; i < 20; i++)
            {
                map[11, i] = "🎋";
            }

            for (int i = 1; i < 20; i++)
            {
                map[18, i] = "🎋";
            }

            for (int i = 1; i < 18; i++)
            {
                map[i, 1] = "🎋";
            }

            for (int i = 1; i < 40; i++)
            {
                map[10, i] = "🟫";
            }

            map[9, 20] = "🟫";
            map[11, 20] = "🟫";
            #endregion
            #region Enclos Singe
            map[4, 7] = "🌴";
            map[3, 4] = "🌴";
            map[7, 5] = "🌴";
            map[4, 9] = "🌴";
            map[2, 8] = "🌳";
            map[8, 3] = "🌳";
            map[4, 3] = "🌳";
            map[8, 8] = "🌳";

            #endregion
            #region enclos oisaux
            map[2, 15] = "🌳";
            map[2, 16] = "🌳";
            map[2, 13] = "🌳";
            map[2, 12] = "🌳";
            map[2, 17] = "🌳";
            map[2, 18] = "🌳";
            map[3, 18] = "🌳";
            map[3, 16] = "🌳";
            map[3, 17] = "🌳";
            map[4, 18] = "🌳";
            map[5, 16] = "🌷";
            map[6, 12] = "🌷";
            map[8, 15] = "🌷";
            #endregion
            #region Lion
            map[2, 22] = "🛕";
            map[2, 23] = "🛕";
            map[8, 28] = "⚱️";
            map[8, 29] = "⚱️";
            map[6, 26] = "🌱";
            #endregion
            #region Poissons
            for (int i = 12; i < 18; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    map[i, j] = "🟦";
                }
            }
            #endregion
            #region enclos pinguin
            map[16, 17] = "⛲";
            map[16, 12] = "⛲";
            map[15, 17] = "\U0001f9ca";
            map[15, 16] = "\U0001f9ca";
            map[14, 14] = "\U0001f9ca";
            map[15, 14] = "\U0001f9ca";
            map[14, 15] = "\U0001f9ca";
            map[15, 15] = "\U0001f9ca";
            map[16, 15] = "\U0001f9ca";
            map[16, 15] = "\U0001f9ca";
            map[13, 15] = "⛄";
            map[13, 12] = "⛄";
            map[17, 12] = "\U0001f9ca";
            map[17, 11] = "\U0001f9ca";
            #endregion
            #region panda
            map[5, 33] = "⛩️";
            map[5, 34] = "🏯";
            map[5, 35] = "⛩️";
            map[4, 34] = "⛩️";
            map[6, 33] = "🎍";
            map[6, 35] = "🎍";
            map[2, 33] = "🎍";
            map[2, 34] = "🎍";
            map[2, 35] = "🎍";
            map[2, 32] = "🎍";
            map[2, 31] = "🎍";
            map[2, 36] = "🎍";
            map[2, 37] = "🎍";
            map[2, 38] = "🎍";
            #endregion



            #endregion
            return map;
        } 
        #endregion
    }
}
