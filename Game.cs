using System;
using TheDevilisme;

namespace TheDevilIsMe
{
    class Game
    {
        private gamestate state;


    private Character protagonist;
        private Character elena;
        private Character sorcerer;

        public Game()
        {
            state = new gamestate();

            protagonist = new Character(
                "???",
                "A mysterious man who has lost his memories."
            );

            elena = new Character(
                "Elena",
                "A young traveler who knows more about the protagonist than she admits."
            );

            sorcerer = new Character(
                "Malachor",
                "An ancient sorcerer connected to the protagonist's forgotten past."
            );
        }

        // ==========================================
        // START
        // ==========================================

        public void Start()
        {
            Console.Title = "The Devil Is Me";

            TitleScreen();

            Console.ReadLine();

            ChapterOne();

            Console.ReadLine();
        }

        private void TitleScreen()
        {
            Console.Clear();

            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("              THE DEVIL IS ME");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("        A Story of Memory and Identity");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to begin...");
        }

        // ==========================================
        // CHAPTER 1
        // THE AWAKENING
        // ==========================================

        private void ChapterOne()
        {
            Console.Clear();

            ChapterTitle(
                "CHAPTER 1",
                "THE AWAKENING"
            );

            Dialogue(
                "Narrator",
                "Cold."
            );

            Dialogue(
                "Narrator",
                "That was the first thing you felt."
            );

            Dialogue(
                "Narrator",
                "Cold stone beneath your body."
            );

            Dialogue(
                "Narrator",
                "The smell of rain filled the air."
            );

            Dialogue(
                "Narrator",
                "You slowly opened your eyes."
            );

            Dialogue(
                "???",
                "Where... am I?"
            );

            Dialogue(
                "Narrator",
                "You tried to remember your name."
            );

            Dialogue(
                "Narrator",
                "Nothing."
            );

            Dialogue(
                "Narrator",
                "You tried to remember your family."
            );

            Dialogue(
                "Narrator",
                "Nothing."
            );

            Dialogue(
                "Narrator",
                "Your home."
            );

            Dialogue(
                "Narrator",
                "Nothing."
            );

            Dialogue(
                "???",
                "Who am I?"
            );

            Dialogue(
                "Narrator",
                "You looked down at your hands."
            );

            Dialogue(
                "Narrator",
                "There was a strange black mark on your palm."
            );

            state.FoundStrangeMark = true;

            FirstChoice();
        }

        private void FirstChoice()
        {
            Console.Clear();

            Console.WriteLine("What do you do?");
            Console.WriteLine();

            Console.WriteLine("1. Examine the strange mark.");
            Console.WriteLine("2. Search the area.");
            Console.WriteLine("3. Leave immediately.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:

                    Dialogue(
                        "Narrator",
                        "The mark felt strangely warm."
                    );

                    Dialogue(
                        "Narrator",
                        "For a brief moment, something appeared in your mind."
                    );

                    MemoryFragment(
                        "A burning village.",
                        "People running.",
                        "A man screaming.",
                        "And you standing in the middle of the flames."
                    );

                    state.recovermemory();

                    break;

                case 2:

                    Dialogue(
                        "Narrator",
                        "You searched the ruined area."
                    );

                    Dialogue(
                        "Narrator",
                        "You found an old metal pendant."
                    );

                    state.additem("Old Pendant");

                    Dialogue(
                        "Narrator",
                        "You don't remember owning it."
                    );

                    break;

                case 3:

                    Dialogue(
                        "Narrator",
                        "You decided that staying here was dangerous."
                    );

                    break;
            }

            MeetElena();
        }

        // ==========================================
        // CHAPTER 1.5
        // ELENA
        // ==========================================

        private void MeetElena()
        {
            Console.Clear();

            Dialogue(
                "Narrator",
                "You walked through the forest."
            );

            Dialogue(
                "Narrator",
                "After several hours, you heard footsteps."
            );

            Dialogue(
                "Elena",
                "Stop!"
            );

            Dialogue(
                "Narrator",
                "A woman pointed a sword at you."
            );

            Dialogue(
                "Elena",
                "Don't move."
            );

            Console.WriteLine();

            Console.WriteLine("How do you respond?");
            Console.WriteLine();

            Console.WriteLine("1. Tell her you don't remember anything.");
            Console.WriteLine("2. Ask why she's pointing a sword at you.");
            Console.WriteLine("3. Threaten her.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:

                    Dialogue(
                        "???",
                        "I don't know who I am."
                    );

                    Dialogue(
                        "???",
                        "I don't even remember how I got here."
                    );

                    state.companiontrust += 15;

                    Dialogue(
                        "Elena",
                        "You really have no idea?"
                    );

                    break;

                case 2:

                    Dialogue(
                        "???",
                        "Why are you pointing that at me?"
                    );

                    Dialogue(
                        "Elena",
                        "Because people who look like you aren't usually harmless."
                    );

                    state.companiontrust += 5;

                    break;

                case 3:

                    Dialogue(
                        "???",
                        "Put the sword down."
                    );

                    Dialogue(
                        "Elena",
                        "You don't want to test me."
                    );

                    state.companiontrust -= 15;

                    break;
            }

            Dialogue(
                "Elena",
                "My name is Elena."
            );

            Dialogue(
                "Elena",
                "If you really lost your memories, I might know where you can find answers."
            );

            Console.WriteLine();

            Console.WriteLine("Will you travel with Elena?");
            Console.WriteLine();

            Console.WriteLine("1. Yes.");
            Console.WriteLine("2. No.");

            choice = GetChoice(2);

            if (choice == 1)
            {
                state.companiontrust += 10;

                Dialogue(
                    "???",
                    "I'll go with you."
                );

                Dialogue(
                    "Elena",
                    "Then let's find out who you are."
                );
            }
            else
            {
                state.companiontrust -= 10;

                Dialogue(
                    "Elena",
                    "Fine. But don't say I didn't warn you."
                );
            }

            ChapterTwo();
        }

        // ==========================================
        // CHAPTER 2
        // THE VILLAGE
        // ==========================================

        private void ChapterTwo()
        {
            Console.Clear();

            ChapterTitle(
                "CHAPTER 2",
                "THE VILLAGE OF ASH"
            );

            Dialogue(
                "Narrator",
                "Several days later, you arrived at a village surrounded by mountains."
            );

            Dialogue(
                "Narrator",
                "The villagers became silent when they saw you."
            );

            Dialogue(
                "Narrator",
                "Some looked frightened."
            );

            Dialogue(
                "Narrator",
                "Others looked angry."
            );

            Dialogue(
                "???",
                "Why are they looking at me like that?"
            );

            Dialogue(
                "Elena",
                "I don't know."
            );

            Dialogue(
                "Elena",
                "But something isn't right."
            );

            VillageInvestigation();
        }

        private void VillageInvestigation()
        {
            Console.Clear();

            Console.WriteLine("What should you investigate?");
            Console.WriteLine();

            Console.WriteLine("1. The abandoned church.");
            Console.WriteLine("2. The old library.");
            Console.WriteLine("3. Ask the villagers.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:

                    Dialogue(
                        "Narrator",
                        "The church had been abandoned for decades."
                    );

                    Dialogue(
                        "Narrator",
                        "Inside, you found a painting."
                    );

                    Dialogue(
                        "Narrator",
                        "It showed a man standing over a burning kingdom."
                    );

                    Dialogue(
                        "Narrator",
                        "The man's face looked exactly like yours."
                    );

                    MemoryFragment(
                        "A throne.",
                        "A black crown.",
                        "A voice calling you by another name."
                    );

                    state.recovermemory();

                    break;

                case 2:

                    Dialogue(
                        "Narrator",
                        "The library was covered in dust."
                    );

                    Dialogue(
                        "Narrator",
                        "You found an ancient journal."
                    );

                    state.FoundOldJournal = true;
                    state.additem("Ancient Journal");

                    Dialogue(
                        "Narrator",
                        "The first page contained a single sentence."
                    );

                    Dialogue(
                        "Narrator",
                        "\"The weapon will awaken when the seal breaks.\""
                    );

                    break;

                case 3:

                    Dialogue(
                        "Narrator",
                        "You approached an old villager."
                    );

                    Dialogue(
                        "Villager",
                        "You..."
                    );

                    Dialogue(
                        "Villager",
                        "It can't be."
                    );

                    Dialogue(
                        "???",
                        "Do you know me?"
                    );

                    Dialogue(
                        "Villager",
                        "I know what you are."
                    );

                    Dialogue(
                        "Villager",
                        "And you should pray that you never remember."
                    );

                    break;
            }

            StrangeMemory();
        }

        // ==========================================
        // STRANGE MEMORY
        // ==========================================

        private void StrangeMemory()
        {
            Console.Clear();

            Dialogue(
                "Narrator",
                "That night, you dreamed."
            );

            Dialogue(
                "Narrator",
                "You stood inside a massive stone chamber."
            );

            Dialogue(
                "Narrator",
                "An old man stood in front of you."
            );

            Dialogue(
                "Sorcerer",
                "Rise."
            );

            Dialogue(
                "Sorcerer",
                "My greatest creation."
            );

            Dialogue(
                "???",
                "Who are you?"
            );

            Dialogue(
                "Sorcerer",
                "I am your creator."
            );

            Dialogue(
                "Narrator",
                "You suddenly woke up."
            );

            Dialogue(
                "???",
                "My creator..."
            );

            Dialogue(
                "Elena",
                "You were dreaming again."
            );

            Console.WriteLine();

            Console.WriteLine("What do you tell Elena?");
            Console.WriteLine();

            Console.WriteLine("1. Tell her everything.");
            Console.WriteLine("2. Hide the dream.");
            Console.WriteLine("3. Tell her you saw a sorcerer.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:

                    state.companiontrust += 15;

                    Dialogue(
                        "???",
                        "I saw a man who called himself my creator."
                    );

                    Dialogue(
                        "Elena",
                        "Then we need to find him."
                    );

                    break;

                case 2:

                    state.companiontrust -= 5;

                    Dialogue(
                        "???",
                        "It was nothing."
                    );

                    Dialogue(
                        "Elena",
                        "You're lying."
                    );

                    break;

                case 3:

                    state.companiontrust += 5;

                    Dialogue(
                        "???",
                        "There was a sorcerer."
                    );

                    Dialogue(
                        "Elena",
                        "Then the legends might be true."
                    );

                    break;
            }

            ChapterThree();
        }

        // ==========================================
        // CHAPTER 3
        // THE SORCERER
        // ==========================================

        private void ChapterThree()
        {
            Console.Clear();

            ChapterTitle(
                "CHAPTER 3",
                "THE CREATOR"
            );

            Dialogue(
                "Narrator",
                "Your journey eventually led you to an ancient castle."
            );

            Dialogue(
                "Narrator",
                "The castle had been abandoned for centuries."
            );

            Dialogue(
                "Narrator",
                "Yet somehow, the front door opened as you approached."
            );

            Dialogue(
                "Elena",
                "This place feels wrong."
            );

            Dialogue(
                "???",
                "I've been here before."
            );

            state.MetTheSorcerer = true;

            Dialogue(
                "Unknown Voice",
                "Welcome home."
            );

            Dialogue(
                "Narrator",
                "A man appeared at the end of the hallway."
            );

            Dialogue(
                "Sorcerer",
                "You finally returned."
            );

            Dialogue(
                "???",
                "Who are you?"
            );

            Dialogue(
                "Sorcerer",
                "You truly don't remember?"
            );

            Dialogue(
                "Sorcerer",
                "Interesting."
            );

            SorcererChoice();
        }

        private void SorcererChoice()
        {
            Console.Clear();

            Console.WriteLine("How do you respond?");
            Console.WriteLine();

            Console.WriteLine("1. Demand the truth.");
            Console.WriteLine("2. Ask who you were.");
            Console.WriteLine("3. Attack him.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:

                    Dialogue(
                        "???",
                        "Tell me the truth!"
                    );

                    Dialogue(
                        "Sorcerer",
                        "Very well."
                    );

                    RevealTruth();

                    break;

                case 2:

                    Dialogue(
                        "???",
                        "Who was I?"
                    );

                    Dialogue(
                        "Sorcerer",
                        "You were never a human being."
                    );

                    RevealTruth();

                    break;

                case 3:

                    Dialogue(
                        "Narrator",
                        "You attacked."
                    );

                    Dialogue(
                        "Narrator",
                        "The sorcerer stopped your attack with a single hand."
                    );

                    Dialogue(
                        "Sorcerer",
                        "Still violent."
                    );

                    Dialogue(
                        "Sorcerer",
                        "Just like I made you."

                    );

                    state.companiontrust -= 5;

                    RevealTruth();

                    break;
            }
        }

        // ==========================================
        // THE TRUTH
        // ==========================================

        private void RevealTruth()
        {
            Console.Clear();

            ChapterTitle(
                "THE TRUTH",
                "THE DEVIL"
            );

            Dialogue(
                "Sorcerer",
                "You were created by me."
            );

            Dialogue(
                "Sorcerer",
                "Your body was made from human flesh."
            );

            Dialogue(
                "Sorcerer",
                "But your soul was created through forbidden magic."
            );

            Dialogue(
                "Sorcerer",
                "You were my ultimate weapon."
            );

            Dialogue(
                "???",
                "Weapon..."
            );

            Dialogue(
                "Sorcerer",
                "You were designed to destroy kingdoms."
            );

            Dialogue(
                "Sorcerer",
                "To destroy armies."
            );

            Dialogue(
                "Sorcerer",
                "And eventually..."
            );

            Dialogue(
                "Sorcerer",
                "To destroy the entire world."
            );

            Dialogue(
                "???",
                "No..."
            );

            Dialogue(
                "Sorcerer",
                "You were the Devil."
            );

            state.LearnedTheTruth = true;

            MemoryFragment(
                "Thousands of soldiers.",
                "A burning city.",
                "Your own hands covered in blood.",
                "The world screaming your name."
            );

            state.recovermemory();

            FinalChoice();
        }

        // ==========================================
        // FINAL CHOICE
        // ==========================================

        private void FinalChoice()
        {
            Console.Clear();

            ChapterTitle(
                "FINAL CHAPTER",
                "THE CHOICE"
            );

            Dialogue(
                "Sorcerer",
                "You were created to destroy the world."
            );

            Dialogue(
                "Sorcerer",
                "Nothing can change that."
            );

            Dialogue(
                "Elena",
                "That's not true."
            );

            Dialogue(
                "Elena",
                "He can choose."
            );

            Dialogue(
                "Sorcerer",
                "Can he?"
            );

            Dialogue(
                "Sorcerer",
                "You cannot escape what you were created to be."
            );

            Console.WriteLine();

            Console.WriteLine("What will you choose?");
            Console.WriteLine();

            Console.WriteLine("1. Accept your identity as the Devil.");
            Console.WriteLine("2. Reject your creator.");
            Console.WriteLine("3. Ask Elena what she thinks.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:

                    state.AcceptedTheDevil = true;

                    Dialogue(
                        "???",
                        "If I am the Devil..."
                    );

                    Dialogue(
                        "???",
                        "Then perhaps the world deserves to burn."
                    );

                    EndingDevil();

                    break;

                case 2:

                    state.RejectedTheDevil = true;

                    Dialogue(
                        "???",
                        "You created my body."
                    );

                    Dialogue(
                        "???",
                        "But you don't control my choices."
                    );

                    EndingHuman();

                    break;

                case 3:

                    Dialogue(
                        "Elena",
                        "You are not the things you were created to be."
                    );

                    Dialogue(
                        "Elena",
                        "You're the person you choose to become."
                    );

                    state.companiontrust += 20;

                    FinalDecision();

                    break;
            }
        }

        // ==========================================
        // FINAL DECISION
        // ==========================================

        private void FinalDecision()
        {
            Console.Clear();

            Console.WriteLine("One final decision remains.");
            Console.WriteLine();

            Console.WriteLine("1. Destroy the world.");
            Console.WriteLine("2. Destroy the sorcerer.");
            Console.WriteLine("3. Sacrifice yourself.");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    EndingDevil();
                    break;

                case 2:
                    EndingRebellion();
                    break;

                case 3:
                    EndingTrue();
                    break;
            }
        }

        // ==========================================
        // ENDINGS
        // ==========================================

        private void EndingDevil()
        {
            Console.Clear();

            EndingTitle("ENDING I", "THE DEVIL");

            Dialogue(
                "Narrator",
                "The seal inside you broke."
            );

            Dialogue(
                "Narrator",
                "The earth shook."
            );

            Dialogue(
                "Narrator",
                "The sky turned black."
            );

            Dialogue(
                "Sorcerer",
                "Yes!"
            );

            Dialogue(
                "Sorcerer",
                "Become what I created!"
            );

            Dialogue(
                "Narrator",
                "You looked at the world one final time."
            );

            Dialogue(
                "???",
                "I am the Devil."
            );

            Dialogue(
                "Narrator",
                "And the world burned."

            );

            GameOver();
        }

        private void EndingHuman()
        {
            Console.Clear();

            EndingTitle("ENDING II", "THE HUMAN");

            Dialogue(
                "???",
                "I was created as a weapon."
            );

            Dialogue(
                "???",
                "But a weapon cannot choose."
            );

            Dialogue(
                "???",
                "I can."
            );

            Dialogue(
                "Narrator",
                "You destroyed the magic inside your body."
            );

            Dialogue(
                "Narrator",
                "The power that once made you the Devil disappeared."
            );

            Dialogue(
                "Elena",
                "Who are you now?"
            );

            Dialogue(
                "???",
                "I don't know."
            );

            Dialogue(
                "???",
                "But I'll find out."

            );

            GameOver();
        }

        private void EndingRebellion()
        {
            Console.Clear();

            EndingTitle("ENDING III", "THE REBELLION");

            Dialogue(
                "Narrator",
                "You turned toward the sorcerer."
            );

            Dialogue(
                "???",
                "You gave me power."
            );

            Dialogue(
                "???",
                "But you never gave me obedience."
            );

            Dialogue(
                "Narrator",
                "The sorcerer's smile disappeared."
            );

            Dialogue(
                "Sorcerer",
                "What are you doing?"
            );

            Dialogue(
                "Narrator",
                "For the first time, the creator feared his creation."
            );

            Dialogue(
                "Narrator",
                "The castle collapsed around them."
            );

            GameOver();
        }

        private void EndingTrue()
        {
            Console.Clear();

            EndingTitle("TRUE ENDING", "THE CHOICE OF MAN");

            Dialogue(
                "Narrator",
                "You finally understood."
            );

            Dialogue(
                "Narrator",
                "Your memories were never the real answer."
            );

            Dialogue(
                "Narrator",
                "The past explained what you were."
            );

            Dialogue(
                "Narrator",
                "But it did not decide what you would become."
            );

            Dialogue(
                "???",
                "I was the Devil."
            );

            Dialogue(
                "???",
                "I was a weapon."
            );

            Dialogue(
                "???",
                "I was created to destroy."
            );

            Dialogue(
                "???",
                "But I choose to be human."

            );

            Dialogue(
                "Elena",
                "Then let's go."

            );

            Dialogue(
                "Narrator",
                "The two of you walked away from the ruins."
            );

            Dialogue(
                "Narrator",
                "For the first time..."
            );

            Dialogue(
                "Narrator",
                "you walked toward a future that belonged to you."

            );

            GameOver();
        }

        // ==========================================
        // MEMORY SYSTEM
        // ==========================================

        private void MemoryFragment(params string[] memories)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       MEMORY FRAGMENT");
            Console.WriteLine("================================");
            Console.WriteLine();

            foreach (string memory in memories)
            {
                Console.WriteLine(memory);
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Memories recovered: {state.memoriesrecovered}");
            Console.ReadLine();
        }

        // ==========================================
        // HELPER METHODS
        // ==========================================

        private void Dialogue(string speaker, string text)
        {
            dialouge dialogue = new dialouge(speaker, text);

            dialogue.display();
        }

        private int GetChoice(int numberOfChoices)
        {
            while (true)
            {
                Console.Write("\nChoose: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice >= 1 && choice <= numberOfChoices)
                    {
                        return choice;
                    }
                }

                Console.WriteLine("Invalid choice. Please choose again.");
            }
        }

        private void ChapterTitle(string chapter, string title)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine(chapter);
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
        }

        private void EndingTitle(string ending, string title)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine(ending);
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
        }

        private void GameOver()
        {
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("                  THE END");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            Console.WriteLine($"Memories recovered: {state.memoriesrecovered}");
            Console.WriteLine($"Elena's trust: {state.companiontrust}");

            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit.");

            Console.ReadLine();
        }
    }


}

