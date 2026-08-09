
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace TheDevilisme
{

    class gamestate { 
      public int companiontrust {  get; set; }
        
        public int memoriesrecovered { get; set; }

        public bool FoundStrangeMark { get; set; }
        public bool FoundOldJournal { get; set; }
        public bool MetTheSorcerer { get; set; }
        public bool LearnedTheTruth { get; set; }
        public bool AcceptedTheDevil { get; set; }
        public bool RejectedTheDevil { get; set; }

        public List<string> inventory { get; set; }

        public  gamestate()

        {
            companiontrust = 0;
            memoriesrecovered = 0;

            FoundStrangeMark = false;
            FoundOldJournal = false;
            MetTheSorcerer = false;
            LearnedTheTruth = false;
            AcceptedTheDevil = false;
            RejectedTheDevil = false;

            inventory  = new List<string>();
        }
        public void additem(string item)
        {
            if (inventory.Contains(item))
            {
                inventory.Add(item);
            }
        }
        public bool HasItem(string item)
        {
            return inventory.Contains(item);
        }

        public void recovermemory()
        {
            memoriesrecovered++;
        }
    }

}


