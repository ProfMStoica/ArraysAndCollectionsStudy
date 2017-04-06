using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollectionsStudy
{
    class Horoscope
    {
        //single-dimensional array of string objects to store the zodiac sign names
        protected string[] _zodiacSignArray;

        //static storage for predictions
        protected static string[] s_actions = { "Buy", "Sell", "Get", "Win", "Catch", "Loose", "Search", "Find", "Take", "Give" };
        protected static string[] s_things = { "job", "car", "cold", "prize", "lottery ticket", "game", "book", "knowledge", "bus", "drink" };
        protected static Random s_randomizer = new Random();

        public Horoscope()
        {
            //create and initialize the array of signs in the same time
            _zodiacSignArray = new string[] { "Aries", "Taurus", "Gemini", "Cancer", "Leo",
                                              "Virgin", "Libra", "Scorpio", "Sagittarius", "Capricorn",
                                              "Aquarius", "Pisces"
                                            };

            Console.WriteLine("_zodiacSignArray.Length = {0}", _zodiacSignArray.Length);
            Console.WriteLine("_zodiacSignArray.GetLength(0) = {0}", _zodiacSignArray.GetLength(0));
            Console.WriteLine("_zodiacSignArray.Rank = {0}", _zodiacSignArray.Rank);
        }

        public virtual void EnumerateElements()
        {
            //print the zodiac sign names
            Console.WriteLine("Zodiac Sign Names in the Horoscope Base Class:");
            foreach (string signName in _zodiacSignArray)
            {
                Console.WriteLine(signName);
            }
        }        

        public static string GeneratePrediction()
        {
            int iAction = s_randomizer.Next(s_actions.Length);
            int iThing = s_randomizer.Next(s_things.Length);
            return String.Format("{0} a(n) {1}.", s_actions[iAction], s_things[iThing]);
        }
    }
}
