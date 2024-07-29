using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ListTask
    {
        List<string> fruit = new List<string>() { "Apple", "Pear", "Orange", "Melon" };

        public void TaskLoop(string userInput)
        {
            fruit.Add(userInput);
            PrintList();
        }

        public void PrintList()
        {
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }
        }
    }
}
