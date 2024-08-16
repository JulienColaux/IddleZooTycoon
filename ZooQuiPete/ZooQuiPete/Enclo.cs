using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZooQuiPete
{
    internal class Enclo
    {
        #region Fields
        private string _name;
        private int _maxAnimaux;
        private int _nombreAnimaux;
        private int _rentabilitee;
        private List<Animal> _animalListe;
        private double _consomationViande;
        private double _consomationPlante;
        private double _prixAnimal;
        #endregion

        #region Accesseurs
        public string Name { get => _name; set => _name = value; }
        public int MaxAnimaux { get => _maxAnimaux; set => _maxAnimaux = value; }
        public int NombreAnimaux { get => _nombreAnimaux; set => _nombreAnimaux = value; }
        public int Rentabilité { get => _rentabilitee; set => _rentabilitee = value; }
        internal List<Animal> AnimalListe { get => _animalListe; set => _animalListe = value; }
        public double PrixAnimal { get => _prixAnimal; set => _prixAnimal = value; }
        public double ConsomationViande { get => _consomationViande; set => _consomationViande = value; }
        public double ConsomationPlante { get => _consomationPlante; set => _consomationPlante = value; }
        #endregion

        #region Ctor
        public Enclo(string name, double prix, double consomationViande, double consomationPlante)
        {
            _name = name;
            _maxAnimaux = 5;
            _nombreAnimaux = 0;
            AnimalListe = new List<Animal>();
            _prixAnimal = prix;
            _consomationViande = consomationViande;
            _consomationPlante = consomationPlante;
        }
        #endregion

        #region Méthodes
        public double GetRentabilitee(int renta)
        {
            double consomation = NombreAnimaux * renta;

            return consomation;
        }
        //méthode générique
        public void Add<T>()
            where T: Animal, new()
        {
            T a = new T();
            AnimalListe.Add(a);
            NombreAnimaux++;
        } 
        #endregion
    }
}
