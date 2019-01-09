using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyVee
{
    class Hero
    {

        //Note: "Hero" is synonymous with character
        
        //Player name...the name of the person who is playing the role of the character
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        //Character name...the name of the character
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region CharacterAbilityScores

        private int strength;

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private int dexterity;

        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }

        private int constitution;

        public int Constituition
        {
            get { return constitution; }
            set { constitution = value; }
        }

        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        private int wisdom;

        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }

        private int charisma;

        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }

        #endregion

        //The character's race
        private string race;

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        //The character's subrace...this is only applicable for certain races
        private string subRace;

        public string SubRace
        {
            get { return subRace; }
            set { subRace = value; }
        }


        //List of all of the languages that the character knows
        public List<string> Languages = new List<string>();


    }
}
