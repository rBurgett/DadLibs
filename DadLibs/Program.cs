using System;

namespace DadLibs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DadLibs!\n");
            while (true)
            {
                var random = new Random();
                var randomInt = random.Next(0, 7);
                var story = "";
                switch (randomInt)
                {
                    case 0:
                        story = Abraham();
                        break;
                    case 1:
                        story = Jonah();
                        break;
                    case 2:
                        story = Moses();
                        break;
                    case 3:
                        story = Esther();
                        break;
                    case 4:
                        story = Paul();
                        break;
                    case 5:
                        story = David();
                        break;
                    case 6:
                        story = Mary();
                        break;
                }
                Console.WriteLine("\n" + story + "\n");
            }
        }
        
        private static string RequestAdjective()
        {
            Console.Write("Enter an adjective: ");
            return Console.ReadLine();
        }
        
        private static string RequestPlace()
        {
            Console.Write("Enter a place: ");
            return Console.ReadLine();
        }
        
        private static string RequestVerb()
        {
            Console.Write("Enter a verb: ");
            return Console.ReadLine();
        }

        private static string RequestNoun()
        {
            Console.Write("Enter a noun: ");
            return Console.ReadLine();
        }

        private static string RequestBoyName()
        {
            Console.Write("Enter a boy name: ");
            return Console.ReadLine();
        }
        
        private static string RequestGirlName()
        {
            Console.Write("Enter a girl name: ");
            return Console.ReadLine();
        }

        private static string Abraham() {
            return
                $"Abraham was a man of God. He had a son named {RequestBoyName()}. God told him to go to {RequestPlace()} and {RequestVerb()} there. Abraham was very {RequestAdjective()} and God blessed him for it.";
        }
        
        private static string Jonah()
        {
            return
                $"Jonah was a {RequestNoun()} of God. He was commanded to go to {RequestPlace()} and preach the {RequestNoun()}. Jonah was very {RequestAdjective()}. Instead, he decided to {RequestVerb()}. God sent a big fish to {RequestVerb()} him.";
        }
        
        private static string Moses()
        {
            return
                $"Moses grew up in {RequestPlace()}. He was a son of Pharaoh {RequestBoyName()}. He was a very {RequestAdjective()} prince. God commanded him to {RequestVerb()} the people. He followed God and witnessed him {RequestVerb()} the Red Sea.";
        }
        
        private static string Esther()
        {
            return
                $"Esther was a young Jewish woman, a captive of {RequestPlace()}. King {RequestBoyName()} chose her to be his queen because she was so {RequestAdjective()}. When a man named {RequestBoyName()} threatened to kill her people, she decided to {RequestVerb()} the king. She was {RequestAdjective()} and God used her to save his people.";
        }
        
        private static string Paul()
        {
            return
                $"Paul was a {RequestNoun()} until God appeared to him on the road to {RequestPlace()}. When he heard God's voice, he was {RequestAdjective()}. He decided to {RequestVerb()} Jesus. God used him in very {RequestAdjective()} ways to spread the gospel.";
        }
        
        private static string David()
        {
            return
                $"David was a shepherd until one day his father, {RequestBoyName()} asked him to take {RequestNoun()} to his brothers in the war against the Philistines. David was {RequestAdjective()} at the request and hurried to the battle. While there, he saw the giant, {RequestBoyName()}, with his mighty {RequestNoun()}. God was with David and he killed the giant using his {RequestNoun()}.";
        }

        private static string Mary()
        {
            return
                $"Mary was a teenage girl, engaged to {RequestBoyName()}. One day, an angel appeared to her and told her that she would have a {RequestNoun()}! She was completely {RequestAdjective()}, but she trusted God. She knew that he would {RequestVerb()} her. In a {RequestNoun()} in {RequestPlace()}, she gave birth to Jesus. She was a {RequestAdjective()} mother.";
        }
    }
}
