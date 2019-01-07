using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyVee
{
    class Hero
    {

        //Player name...the name of the person who is playing the role of the character
        private string playerName;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        //characer name...the name of the character
        private string characterName;

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

    }
}
