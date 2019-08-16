using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    class Card
    {
        private string name;
        private string type;
        private string effect;

        public Card(string namec, string typec, string effectc)
        {
            name = namec;
            type = typec;
            effect = effectc;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Effect
        {
            get
            {
                return effect;
            }
            set
            {
                effect = value;
            }
        }
    }
}
