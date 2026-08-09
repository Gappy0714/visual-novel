using System;

namespace TheDevilisme
{
    class choice
    { 
      public string Text { get; set; }
        public Action Action { get; set; }

        public choice(string text, Action action)
        {
            Text = text;
            Action = action;
        }
    }

}

