using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollectionsStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program prog = new Program();
                prog.CompareArraysWithLists();
            }
            catch (Exception ex)
            {
                Console.WriteLine("TODO: Error handling has not beein built-in. You will have to start again.");
            }

            Console.ReadKey();
        }

        private void CompareArraysWithLists()
        {
            List<string> predList = new List<string>(10);
            try
            {
                Console.WriteLine("The number of predictions in the list is {0}",
                    predList.Count);

                Console.WriteLine("The capacity of the prediction list is {0}",
                    predList.Capacity);

                Console.WriteLine("Fifth prediction is {0}", predList[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string[] predArray = new string[10];
                Console.WriteLine("The length of the array is {0}",
                    predArray.Length);

                string fifthElement = predArray[4];
                Console.WriteLine("Fifth prediction in the array is {0}", (fifthElement == null) ? "null" : fifthElement);
                //attempt to use the element "extracted" from the array
                bool isWin = fifthElement.StartsWith("Win");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
