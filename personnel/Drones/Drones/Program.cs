using Drones.Helpers;
using Drones.Model;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(Config.AIRSPACE_WIDTH / 2, Config.AIRSPACE_HEIGHT / 2, "Romain"));

            List<Pizzeria> restaurants = new List<Pizzeria>();
            restaurants.Add(new Pizzeria(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            restaurants.Add(new Pizzeria(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            restaurants.Add(new Pizzeria(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            restaurants.Add(new Pizzeria(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            restaurants.Add(new Pizzeria(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));

            List<Clients> personne = new List<Clients>();
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));

            // D�marrage
            Application.Run(new AirSpace(fleet, restaurants, personne));
        }
    }
}