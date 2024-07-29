namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Choose the task 1 2 3
            Console.WriteLine("Choose the task: 1, 2, 3");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    // Do the ListTask
                    if (result == 1)
                    {
                        Console.WriteLine("Write some fruit:");
                        
                        
                        break;
                    }
                    
                    // Do the DictionaryTask
                    if (result == 2)
                    {
                        
                        break;
                    }
                    
                    // Do the LinkedListTask
                    if (result == 3)
                    {

                        break;
                    }
                                        
                }
            } while (true);

        }
    }
}
