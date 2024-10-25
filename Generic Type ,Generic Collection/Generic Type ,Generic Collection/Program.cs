namespace Generic_Type__Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("ListInt sinifinin testi:");
                ListInt listInt = new ListInt();
                listInt.Add(1);
                listInt.Add(2);
                listInt.Add(3);
                listInt.AddRange(40, 50, 60);
                Console.WriteLine("ListInt elementleri " + listInt);
                Console.WriteLine("Sum: " + listInt.Sum());
                Console.WriteLine("3 var?");
                Console.WriteLine( listInt.Contains(3));
                listInt.Remove(2);
                Console.WriteLine("2 silinenden sonra:");
                Console.WriteLine( listInt);

                Console.WriteLine("CustomList<int> sinifinin testi");
                CustomList<int> customList = new CustomList<int>();
                customList.Add(100);
                customList.Add(200);
                customList.Add(300);
                customList.AddRange(400, 500);
                Console.WriteLine("CustomList elementleri " + customList);
                Console.WriteLine("Sum: " + customList.Sum());
                Console.WriteLine("Capacity: " + customList.Capacity);
                Console.WriteLine("Count: " + customList.Count);

            }
        }
    }
    