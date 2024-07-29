namespace Collections
{
    public class DictionaryTask
    {
        private string userInputName;
        private float userInputMark;
        Dictionary<string, float> students = new Dictionary<string, float>()
        {
            ["Sam"] = 4.5f,
            ["Mike"] = 5.0f,
            ["Sue"] = 4.1f,
            ["Kate"] =3.7f
        };

        public void TaskLoop()
        {
            Console.WriteLine("\nStudents:");
            PrintDictionary();

            // Add new element
            do
            {
                Console.WriteLine("\nWrite student's name:");
                userInputName = Console.ReadLine();
            } while (userInputName == null);

            if (userInputName == "exit")
            {
                Environment.Exit(0);                        // abort????
            }

            do
            {
                Console.WriteLine("\nWrite student's mark:");
                userInputMark = float.Parse(Console.ReadLine());
            } while (userInputMark < 2 && userInputMark > 5);

            students.Add(userInputName, userInputMark);
            PrintDictionary();

            // Check the mark of a student
            do
            {
                Console.WriteLine("\nWrite student's name you want to check:");
                userInputName = Console.ReadLine();
            } while (userInputName == null);

            if (userInputName == "exit")
            {
                Environment.Exit(0);                        // abort????
            }

            if (students.TryGetValue(userInputName, out float value))
            {
                Console.WriteLine($"{userInputName} : {value}");
            }
            else
            {
                Console.WriteLine("There is no such student");
            }
        }

        public void PrintDictionary()
        {
            foreach (var person in students)
            {
                Console.WriteLine($"{person.Key} : {person.Value}"); 
            }
        }
    }
}
