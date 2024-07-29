namespace Collections
{
    public class LinkedListTask
    {
        private string userInput;
        LinkedList<string> symbols = new LinkedList<string>();

        public void TaskLoop()
        {
            Console.WriteLine("Write 3 to 6 elements for the list (divide with 'Space'):");
            userInput = Console.ReadLine();
            if (userInput == "exit")
            {
                Environment.Exit(0);                        // abort????
            }

            string[] values = userInput.Split(' ');
            foreach (string value in values)
            {
                symbols.AddLast(value);
            }

            // Printing forward
            Console.WriteLine("\nFrom the beginning:");
            var currentNode = symbols.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            // Printing backwards
            Console.WriteLine("\nFrom the end:");
            currentNode = symbols.Last;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }
    }
}
