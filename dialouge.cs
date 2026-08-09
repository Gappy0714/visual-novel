using System;

namespace TheDevilisme
{
    class dialouge
    {
        public string Speaker { get; set; }
        public string Text { get; set; }

        public dialouge (string speaker, string text)
        {
            Speaker = speaker;
            Text = text;
        }
        public void display()
        {
            Console.WriteLine();

            if (Speaker == "Narrator")
            {
                Console.WriteLine(Text);
            }
            else
            {
                Console.WriteLine($"{Speaker}:");
                Console.WriteLine($"\"{Text}\"");
            }
        }
    }

}




