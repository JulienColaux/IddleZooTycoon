using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    public class Affichage
    {

        #region Méthodes
        public void AfficherZoo(Zoo zoo)
        {
            Console.Clear();
            int lignes = zoo.Map.GetLength(0);
            int colonnes = zoo.Map.GetLength(1);

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    Console.Write(zoo.Map[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void AfficherNewAnimal(Zoo zoo)
        {
            #region Singe
            if (zoo.EnclotSinge.AnimalListe.Count == 1)
            {
                zoo.Map[3, 8] = "🐒";
            }
            else if (zoo.EnclotSinge.AnimalListe.Count == 2)
            {
                zoo.Map[4, 4] = "🐒";
                zoo.Map[3, 8] = "🐒";
            }
            else if (zoo.EnclotSinge.AnimalListe.Count == 3)
            {
                zoo.Map[4, 9] = "🐒";
                zoo.Map[4, 4] = "🐒";
                zoo.Map[3, 8] = "🐒";
            }
            else if (zoo.EnclotSinge.AnimalListe.Count == 4)
            {
                zoo.Map[3, 5] = "🐒";
                zoo.Map[4, 9] = "🐒";
                zoo.Map[4, 4] = "🐒";
                zoo.Map[3, 8] = "🐒";
            }
            else if (zoo.EnclotSinge.AnimalListe.Count == 5)
            {
                zoo.Map[7, 4] = "🐒";
                zoo.Map[3, 5] = "🐒";
                zoo.Map[4, 9] = "🐒";
                zoo.Map[4, 4] = "🐒";
                zoo.Map[3, 8] = "🐒";
            }
            #endregion

            #region Oiseau
            if (zoo.EnclotOiseau.AnimalListe.Count == 1)
            {
                zoo.Map[8, 16] = "🦜";
            }
            else if (zoo.EnclotOiseau.AnimalListe.Count == 2)
            {
                zoo.Map[4, 12] = "🦆";
                zoo.Map[8, 16] = "🦜";
            }
            else if (zoo.EnclotOiseau.AnimalListe.Count == 3)
            {
                zoo.Map[4, 17] = "🦢";
                zoo.Map[4, 12] = "🦆";
                zoo.Map[8, 16] = "🦜";
            }
            else if (zoo.EnclotOiseau.AnimalListe.Count == 4)
            {
                zoo.Map[3, 15] = "🪿";
                zoo.Map[4, 17] = "🦢";
                zoo.Map[4, 12] = "🦆";
                zoo.Map[8, 16] = "🦜";
            }
            else if (zoo.EnclotOiseau.AnimalListe.Count == 5)
            {
                zoo.Map[7, 14] = "🦩";
                zoo.Map[3, 15] = "🪿";
                zoo.Map[4, 17] = "🦢";
                zoo.Map[4, 12] = "🦆";
                zoo.Map[8, 16] = "🦜";
            }
            #endregion

            #region Lion
            if (zoo.EnclotLion.AnimalListe.Count == 1)
            {
                zoo.Map[8, 26] = "🦁";
            }
            else if (zoo.EnclotLion.AnimalListe.Count == 2)
            {
                zoo.Map[4, 24] = "🦁";
                zoo.Map[8, 26] = "🦁";
            }
            else if (zoo.EnclotLion.AnimalListe.Count == 3)
            {
                zoo.Map[4, 22] = "🦁";
                zoo.Map[4, 24] = "🦁";
                zoo.Map[8, 26] = "🦁";
            }
            else if (zoo.EnclotLion.AnimalListe.Count == 4)
            {
                zoo.Map[3, 22] = "🦁";
                zoo.Map[4, 22] = "🦁";
                zoo.Map[4, 24] = "🦁";
                zoo.Map[8, 26] = "🦁";
            }
            else if (zoo.EnclotLion.AnimalListe.Count == 5)
            {
                zoo.Map[7, 28] = "🦁";
                zoo.Map[3, 22] = "🦁";
                zoo.Map[4, 22] = "🦁";
                zoo.Map[4, 24] = "🦁";
                zoo.Map[8, 26] = "🦁";
            }
            #endregion

            #region panda
            if (zoo.EnclotPanda.AnimalListe.Count == 1)
            {
                zoo.Map[8, 31] = "🐼";
            }
            else if (zoo.EnclotPanda.AnimalListe.Count == 2)
            {
                zoo.Map[4, 36] = "🐼";
                zoo.Map[8, 31] = "🐼";
            }
            else if (zoo.EnclotPanda.AnimalListe.Count == 3)
            {
                zoo.Map[4, 37] = "🐼";
                zoo.Map[8, 31] = "🐼";
                zoo.Map[4, 36] = "🐼";

            }
            else if (zoo.EnclotPanda.AnimalListe.Count == 4)
            {
                zoo.Map[4, 36] = "🐼";
                zoo.Map[3, 34] = "🐼";
                zoo.Map[4, 37] = "🐼";
                zoo.Map[8, 31] = "🐼";
            }
            else if (zoo.EnclotPanda.AnimalListe.Count == 5)
            {
                zoo.Map[4, 36] = "🐼";
                zoo.Map[7, 33] = "🐼";
                zoo.Map[3, 34] = "🐼";
                zoo.Map[4, 37] = "🐼";
                zoo.Map[8, 31] = "🐼";
            }
            #endregion

            #region poisson
            if (zoo.EnclotPoisson.AnimalListe.Count == 1)
            {
                zoo.Map[12, 4] = "🐟";
            }
            else if (zoo.EnclotPoisson.AnimalListe.Count == 2)
            {
                zoo.Map[13, 8] = "🐠";
                zoo.Map[12, 4] = "🐟";
            }
            else if (zoo.EnclotPoisson.AnimalListe.Count == 3)
            {
                zoo.Map[14, 3] = "🐡";
                zoo.Map[13, 8] = "🐠";
                zoo.Map[12, 4] = "🐟";
            }
            else if (zoo.EnclotPoisson.AnimalListe.Count == 4)
            {
                zoo.Map[16, 6] = "🐟";
                zoo.Map[14, 3] = "🐡";
                zoo.Map[13, 8] = "🐠";
                zoo.Map[12, 4] = "🐟";
            }
            else if (zoo.EnclotPoisson.AnimalListe.Count == 5)
            {
                zoo.Map[14, 6] = "🦈";
                zoo.Map[16, 6] = "🐟";
                zoo.Map[14, 3] = "🐡";
                zoo.Map[13, 8] = "🐠";
                zoo.Map[12, 4] = "🐟";
            }
            #endregion

            #region pinguin
            if (zoo.EnclotPinguin.AnimalListe.Count == 1)
            {
                zoo.Map[17, 15] = "🐧";
            }
            else if (zoo.EnclotPinguin.AnimalListe.Count == 2)
            {
                zoo.Map[13, 15] = "🐧";
                zoo.Map[17, 15] = "🐧";

            }
            else if (zoo.EnclotPinguin.AnimalListe.Count == 3)
            {
                zoo.Map[14, 13] = "🐧";
                zoo.Map[13, 15] = "🐧";
                zoo.Map[17, 15] = "🐧";
            }
            else if (zoo.EnclotPinguin.AnimalListe.Count == 4)
            {
                zoo.Map[16, 13] = "🐧";
                zoo.Map[14, 13] = "🐧";
                zoo.Map[13, 15] = "🐧";
                zoo.Map[17, 15] = "🐧";
            }
            else if (zoo.EnclotPinguin.AnimalListe.Count == 5)
            {
                zoo.Map[14, 16] = "🐧";
                zoo.Map[16, 13] = "🐧";
                zoo.Map[14, 13] = "🐧";
                zoo.Map[13, 15] = "🐧";
                zoo.Map[17, 15] = "🐧";
            }
            #endregion
        }

        public void MajInfo(Zoo zoo)
        {
            zoo.Map[0, 41] = $"   Argent du zoo     : {zoo.Argent} $";
            zoo.Map[1, 41] = $"   Stock viande      : {zoo.NouritureCarni} 🍖";
            zoo.Map[2, 41] = $"   Stock plante      : {zoo.NouritureVege} \U0001f96c";
            zoo.Map[3, 41] = $"   Place de Parking  : {zoo.Parking.NombreDePlace} ";


            zoo.Map[5, 41] = $"   Argent généré : ";
            zoo.Map[6, 41] = $"   Enclos des Singes   : +{zoo.EnclotSinge.GetRentabilitee(1)} $/clic     -{zoo.EnclotSinge.ConsomationPlante * zoo.EnclotSinge.NombreAnimaux} \U0001f96c/clic ";
            zoo.Map[7, 41] = $"   Enclos des Oiseaux  : +{zoo.EnclotOiseau.GetRentabilitee(1)} $/clic     -{zoo.EnclotOiseau.ConsomationPlante * zoo.EnclotOiseau.NombreAnimaux} \U0001f96c/clic";
            zoo.Map[8, 41] = $"   Enclos des Lions    : +{zoo.EnclotLion.GetRentabilitee(2)} $/clic     -{zoo.EnclotLion.ConsomationViande * zoo.EnclotLion.NombreAnimaux} 🍖/clic";
            zoo.Map[9, 41] = $"   Enclos des Pandas   : +{zoo.EnclotPanda.GetRentabilitee(2)} $/clic     -{zoo.EnclotPanda.ConsomationPlante * zoo.EnclotPanda.NombreAnimaux} \U0001f96c/clic";
            zoo.Map[10, 41] = $"   Enclos des Poissons : +{zoo.EnclotPoisson.GetRentabilitee(3)} $/clic     -{zoo.EnclotPoisson.ConsomationPlante * zoo.EnclotPoisson.NombreAnimaux} \U0001f96c/clic";
            zoo.Map[11, 41] = $"   Enclos des Pinguins : +{zoo.EnclotPinguin.GetRentabilitee(3)} $/clic     -{zoo.EnclotPinguin.ConsomationViande * zoo.EnclotPinguin.NombreAnimaux} 🍖/clic ";

            zoo.Map[13, 41] = $"   Poduction de Viande 🍖  : {zoo.UsineCarnivore.Production} $";
            zoo.Map[14, 41] = $"   Production de Plante \U0001f96c : {zoo.UsineVege.Production} $";

            zoo.Map[16, 41] = "   1. Acheter des animaux ";
            zoo.Map[17, 41] = "   2. Ameliorer les usines ";
            zoo.Map[18, 41] = "   3. Ameliorer le parking ";
        }

        public void MenuDeBase(Zoo zoo, Affichage affichage, Shop shop)
        {
            if (zoo.NouritureCarni < 0 || zoo.NouritureVege < 0)
            {
                Console.Clear();
                Console.WriteLine("Vous n'avez plus de quoi nourir vos animaux...");
                Console.WriteLine("Vous devez fermer le zoo quelque instant...");
                Console.WriteLine("Veuillez patientez...");
                Thread.Sleep(10000);
                zoo.NouritureCarni += 100;
                zoo.NouritureVege += 100;
                affichage.MenuDeBase(zoo, affichage, shop);
            }
            else
            {
                affichage.AfficherNewAnimal(zoo);
                affichage.MajInfo(zoo);
                affichage.AfficherZoo(zoo);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                string choice = keyInfo.KeyChar.ToString();
                if (choice == "1")
                {
                    shop.BuyAnimal(zoo, affichage, shop);
                }
                else if (choice == "2")
                {
                    shop.UpgradeFactory(zoo, affichage, shop);
                }
                else if (choice == "3")
                {
                    shop.UpgradeParking(zoo, affichage, shop);
                }
                else
                {
                    zoo.Argent += zoo.EnclotSinge.GetRentabilitee(1);
                    zoo.Argent += zoo.EnclotOiseau.GetRentabilitee(1);
                    zoo.Argent += zoo.EnclotLion.GetRentabilitee(2);
                    zoo.Argent += zoo.EnclotPanda.GetRentabilitee(2);
                    zoo.Argent += zoo.EnclotPoisson.GetRentabilitee(3);
                    zoo.Argent += zoo.EnclotPinguin.GetRentabilitee(3);
                    zoo.Argent += (zoo.Parking.NombreDePlace/50);

                    zoo.NouritureVege += zoo.UsineVege.Production;
                    zoo.NouritureCarni += zoo.UsineCarnivore.Production;

                    zoo.NouritureCarni -= ((zoo.EnclotLion.ConsomationViande * zoo.EnclotLion.NombreAnimaux) + (zoo.EnclotPinguin.ConsomationViande * zoo.EnclotPinguin.NombreAnimaux));
                    zoo.NouritureVege -= ((zoo.EnclotPanda.ConsomationPlante * zoo.EnclotPanda.NombreAnimaux) + (zoo.EnclotSinge.ConsomationPlante * zoo.EnclotSinge.NombreAnimaux) + (zoo.EnclotOiseau.ConsomationPlante * zoo.EnclotOiseau.NombreAnimaux));
                    Thread.Sleep(100);
                    affichage.MenuDeBase(zoo, affichage, shop);
                }
            }
        } 
        #endregion
    }
}

