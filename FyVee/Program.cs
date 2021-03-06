﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO - create a name generator for character names

namespace FyVee
{
    class Program
    {
        static void Main(string[] args)
        {
            string PressAnyKey = "Press any key to continue...";
            #region Races
            
            //list of available races
            List<string> Races = new List<string>();
            Races.Add("Dwarf");
            Races.Add("Elf");
            Races.Add("Halfling");
            Races.Add("Human");
            Races.Add("Dragonborn");
            Races.Add("Gnome");
            Races.Add("Half-Elf");
            Races.Add("Half-Orc");
            Races.Add("Tiefling");

            #endregion
            #region Languages
            //List of available languages in 5E
            List<string> Languages = new List<string>();
            //Standard Languages:
            Languages.Add("Common");
            Languages.Add("Dwarvish");
            Languages.Add("Elvish");
            Languages.Add("Giant");
            Languages.Add("Gnomish");
            Languages.Add("Goblin");
            Languages.Add("Halfling");
            Languages.Add("Orc");
            //Exotic languages:
            Languages.Add("Abyssal");
            Languages.Add("Celestial");
            Languages.Add("Deep Speech");
            Languages.Add("Draconic");
            Languages.Add("Infernal");
            Languages.Add("Primordial");
            Languages.Add("Sylvan");
            Languages.Add("Undercommon");
            #endregion
            //Create a new hero
            var CurrentHero = new Hero();

            //Greet the user
            Console.WriteLine("Welcome to FyVee, the 5th edition character creater!");
            Console.WriteLine(PressAnyKey);
            Console.ReadLine();
            
            //Get player name
            Console.WriteLine("What is the name of the person who will be playing the role of this character?");
            CurrentHero.PlayerName = Console.ReadLine();

            //Get character name
            Console.WriteLine("What is the name of the new character?");
            CurrentHero.Name = Console.ReadLine();

            //TODO - Select a race

        }
    }
}
