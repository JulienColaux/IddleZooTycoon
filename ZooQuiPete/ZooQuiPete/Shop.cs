using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooQuiPete
{
    public class Shop
    {
        #region Méthodes
        public void BuyAnimal(Zoo zoo, Affichage affichage, Shop shop)
        {
            Console.Clear();
            Console.WriteLine("Quelle animal desirez-vous acheter?");
            Console.WriteLine($"1. Singe   : {zoo.EnclotSinge.PrixAnimal} $");
            Console.WriteLine($"2. Oiseau  : {zoo.EnclotOiseau.PrixAnimal} $");
            Console.WriteLine($"3. Lion    : {zoo.EnclotLion.PrixAnimal} $");
            Console.WriteLine($"4. Panda   : {zoo.EnclotPanda.PrixAnimal} $");
            Console.WriteLine($"5. Poisson : {zoo.EnclotPoisson.PrixAnimal} $");
            Console.WriteLine($"6. Pinguin : {zoo.EnclotPinguin.PrixAnimal} $");
            Console.WriteLine($"7. Quitter le Shop");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            string choice = keyInfo.KeyChar.ToString();

            switch (choice)
            {
                case "1":
                    Singe singe = new Singe();
                    if (zoo.Argent >= zoo.EnclotSinge.PrixAnimal)
                    {
                        zoo.EnclotSinge.Add<Singe>();
                        zoo.Argent -= zoo.EnclotSinge.PrixAnimal;
                        zoo.EnclotSinge.PrixAnimal += (zoo.EnclotSinge.PrixAnimal);
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent.");
                        Thread.Sleep(2000);
                    }
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                case "2":
                    Oiseau oiseau = new Oiseau();
                    if (zoo.Argent >= zoo.EnclotOiseau.PrixAnimal)
                    {
                        zoo.EnclotOiseau.Add<Oiseau>();
                        zoo.Argent -= zoo.EnclotOiseau.PrixAnimal;
                        zoo.EnclotOiseau.PrixAnimal += (zoo.EnclotOiseau.PrixAnimal);
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent.");
                        Thread.Sleep(2000);
                    }
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                case "3":
                    Lion lion = new Lion();
                    if (zoo.Argent >= zoo.EnclotLion.PrixAnimal)
                    {
                        zoo.EnclotLion.Add<Lion>();
                        zoo.Argent -= zoo.EnclotLion.PrixAnimal;
                        zoo.EnclotLion.PrixAnimal += (zoo.EnclotLion.PrixAnimal) / 2;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent.");
                        Thread.Sleep(2000);
                    }
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                case "4":
                    Panda panda = new Panda();
                    if (zoo.Argent >= zoo.EnclotPanda.PrixAnimal)
                    {
                        zoo.EnclotPanda.Add<Panda>();
                        zoo.Argent -= zoo.EnclotPanda.PrixAnimal;
                        zoo.EnclotPanda.PrixAnimal += (zoo.EnclotPanda.PrixAnimal) / 3;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent.");
                        Thread.Sleep(2000);
                    }
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                case "5":
                    Poisson poisson = new Poisson();
                    if (zoo.Argent >= zoo.EnclotPoisson.PrixAnimal)
                    {
                        zoo.EnclotPoisson.Add<Poisson>();
                        zoo.Argent -= zoo.EnclotPoisson.PrixAnimal;
                        zoo.EnclotPoisson.PrixAnimal += (zoo.EnclotPoisson.PrixAnimal) / 4;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent.");
                        Thread.Sleep(2000);
                    }
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                case "6":
                    Pinguin pinguin = new Pinguin();
                    if (zoo.Argent >= zoo.EnclotPinguin.PrixAnimal)
                    {
                        zoo.EnclotPinguin.Add<Pinguin>();
                        zoo.Argent -= zoo.EnclotPinguin.PrixAnimal;
                        zoo.EnclotPinguin.PrixAnimal += (zoo.EnclotPinguin.PrixAnimal) / 4;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas assez d'argent.");
                        Thread.Sleep(2000);
                    }
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                case "7":
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;

                default:
                    affichage.MenuDeBase(zoo, affichage, shop);
                    break;
            }
        }

        public void UpgradeFactory(Zoo zoo, Affichage affichage, Shop shop)
        {
            Console.Clear();
            Console.WriteLine("Quelle usine souhaitez-vous ameliorer?");
            Console.WriteLine($"1. Usine Vege      : {zoo.UsineVege.PrixAmelioration} $");
            Console.WriteLine($"2. Usine Carnivore : {zoo.UsineCarnivore.PrixAmelioration} $");
            Console.WriteLine("3. Quitter le shop");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            string choice = keyInfo.KeyChar.ToString();
            if (choice == "1")
            {
                if (zoo.Argent >= zoo.UsineVege.PrixAmelioration)
                {
                    zoo.Argent -= zoo.UsineVege.PrixAmelioration;
                    zoo.UsineVege.Production += (1);
                    zoo.UsineVege.PrixAmelioration += (zoo.UsineVege.Production);
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                }
                affichage.MenuDeBase(zoo, affichage, shop);
            }
            else if (choice == "2")
            {
                if (zoo.Argent >= zoo.UsineCarnivore.PrixAmelioration)
                {
                    zoo.Argent -= zoo.UsineCarnivore.PrixAmelioration;
                    zoo.UsineCarnivore.Production += (1);
                    zoo.UsineCarnivore.PrixAmelioration += (zoo.UsineCarnivore.Production);
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                }
                affichage.MenuDeBase(zoo, affichage, shop);

            }
            else if (choice == "3")
            {
                affichage.MenuDeBase(zoo, affichage, shop);
            }
            else
            {
                affichage.MenuDeBase(zoo, affichage, shop);
            }

        }

        public void UpgradeParking(Zoo zoo, Affichage affichage, Shop shop)
        {
            Console.Clear();
            Console.WriteLine($"Voulez-vous agrandir le parking de 5 places pour {zoo.Parking.PrixAmelioration} $");
            Console.WriteLine("1. OUI");
            Console.WriteLine("2. NON");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            string choice = keyInfo.KeyChar.ToString();
            if (choice == "1")
            {
                if (zoo.Argent >= zoo.Parking.PrixAmelioration)
                {
                    zoo.Argent -= zoo.Parking.PrixAmelioration;
                    zoo.Parking.NombreDePlace += (50);
                    zoo.Parking.PrixAmelioration += (zoo.Parking.PrixAmelioration);
                    if (zoo.Parking.NombreDePlace > 50)
                    {
                        zoo.Map[11, 34] = "🚕";
                        zoo.Map[17, 34] = "🚎";
                        zoo.Map[14, 32] = "\U0001f6fb";
                    }
                    if (zoo.Parking.NombreDePlace > 100)
                    {
                        zoo.Map[17, 30] = "🚎";
                        zoo.Map[14, 28] = "🚕";
                        zoo.Map[18, 34] = "\U0001f6fb";
                    }
                    if (zoo.Parking.NombreDePlace > 150)
                    {
                        zoo.Map[11, 30] = "🚎";
                        zoo.Map[11, 32] = "\U0001f6fb";
                        zoo.Map[17, 28] = "🚕";
                    }
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                }
                affichage.MenuDeBase(zoo, affichage, shop);
            }
            else
            {
                affichage.MenuDeBase(zoo, affichage, shop);
            }
        } 
        #endregion
    }
}
