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
            for (int e = 0; e < 5; e++)
            {
                restaurants.Add(new Pizzeria(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            }            

            List<Clients> personne = new List<Clients>();
            for (int i = 0; i < 20; i++)
            {
                personne.Add(new Clients(RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT)));
            }

            // D�marrage
            Application.Run(new AirSpace(fleet, restaurants, personne));
        }
    }
}