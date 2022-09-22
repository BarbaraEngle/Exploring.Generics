using System.Collections;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring Generic Collections\n" +
                              "-----------------------------\n");

            Console.WriteLine("It is recommended that you use Generic Collections over non-generic Collections.\n" +
                                "Why??\n" +
                                "Because non-generic collections are only maintain for compatibility\n" +
                                "There are generic collections equivalents for all non-generic collections \n"+
                                "Generic collections provide Type safety\n" +
                                "https://docs.microsoft.com/en-us/dotnet/standard/collections \n" +
                                "----------------------------------------------------------------------------------\n");

            //A non-generic collection
            //------------------------

            ArrayList ngList = new()
            {
                "one",
                2,
                null
            };

            //Generic collection
            //------------------
            List<string> strList = new();

            strList.Add("one");
           
            //Compiler does not let you add a int
            //strList.Add(2);

            strList.Remove("one");

            strList.Add("Patrol");
            strList.Add("Mustang");
            strList.Add("Frontier");
            strList.Add("Discovery");

            Console.WriteLine(strList.Count);

            foreach(string itm in strList)
            {
                Console.WriteLine(itm);
            }

            Console.WriteLine("You can also add non-primitive types to a generic list:");

            List<Car> cars = new();

            cars.Add(new Car(1111,4,"Pink"));
            cars.Add(new Car(2222, 1, "Green"));

            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("The Generic Dictionary\n" +
                              "-----------------------\n");

            Console.WriteLine("A dictionary entry consists of a key and a value.\n" +
                               "You need to specify the type of the key and the value.\n");

            Dictionary<string, string> carDictionary = new ();

            carDictionary.Add("Mustang","red");
            carDictionary.Add("Cadillac", "Blue");

            foreach (var item in carDictionary)
            {
                Console.Write($"{item.Key} \t {item.Value} \n");
            }

            //can't add an int, the code won't compile
            //carDictionary.Add("Ford", 33);

            Console.WriteLine("The HashSet\n" +
                              "-----------");
            Console.WriteLine("Is not sorted, and can't contain duplicate elements\n");
            HashSet<int> evenNumbers = new ();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);
            }

            var count=0;
            foreach (var item in evenNumbers)
            {
                count++;

                if (count <evenNumbers.Count)
                {
                    Console.Write($"{item}, \t");
                }
                else
                {
                    Console.Write($"{item}\n");
                }
            }

            Console.WriteLine();
            {
                Console.Write($"Goodbye \t");
            }
        }
    }
}