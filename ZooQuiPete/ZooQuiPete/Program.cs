// See https://aka.ms/new-console-template for more information


using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ZooQuiPete;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Zoo zoo = new Zoo();
        Affichage affichage = new Affichage();
        Shop shop = new Shop();

        affichage.MenuDeBase(zoo,affichage,shop);
    }
}
