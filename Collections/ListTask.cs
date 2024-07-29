namespace Collections
{
    public class ListTask
    {
        private string userInput;
        List<string> fruit = new List<string>() { "Apple", "Pear", "Orange", "Melon" };

        public void TaskLoop()
        {
            // Add new element
            do
            {
                Console.WriteLine("\nWrite some fruit:");
                userInput = Console.ReadLine();
            } while (userInput == null);

            if (userInput == "exit")
            {
                Environment.Exit(0);                        // abort????
            }
            
            fruit.Add(userInput);
            PrintList();

            // Add new element in the middle
            do
            {
                Console.WriteLine("\nWrite one more fruit:");
                userInput = Console.ReadLine();
            } while (userInput == null);
            
            if (userInput == "exit")
            {
                Environment.Exit(0);                         // abort????
            }

            fruit.Insert(fruit.Count / 2, userInput);
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
