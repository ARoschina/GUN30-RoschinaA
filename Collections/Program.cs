namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            // Choose the task 1 2 3
            Console.WriteLine("Choose the task: 1, 2, 3");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    // Do the ListTask
                    if (result == 1)
                    {
                        var listTask = new ListTask();
                        listTask.TaskLoop(); 
                        break;
                    }
                    
                    // Do the DictionaryTask
                    if (result == 2)
                    {
                        var dictionaryTask = new DictionaryTask();
                        dictionaryTask.TaskLoop();
                        break;
                    }
                    
                    // Do the LinkedListTask
                    if (result == 3)
                    {
                        var linkedListTask = new LinkedListTask();
                        linkedListTask.TaskLoop();
                        break;
                    }                                        
                }
            } while (true);
        }
    }
}
