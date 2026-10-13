namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char choice;
            Console.WriteLine("p_ print number");
            Console.WriteLine("A_ Add number");
            Console.WriteLine("M_ desbly mean of numbers");
            Console.WriteLine("s_ desbly smalest numbers");
            Console.WriteLine("L _ desbly largest numbers");
            Console.WriteLine("F_ find a number in the list ");
            Console.WriteLine("C _ clear the list ");
            Console.WriteLine("Q _ Quit ");

            choice = char.Parse(Console.ReadLine());
            switch(choice)
            {
                case 'p':
                    for(int i = 0;i<numbers.Count;i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                    break;

                case 'a':
                    break;

                case 'm':
                    break;

                case 's':
                    break;

                case 'l':
                    break;

                case 'f':
                    break;


                case 'c':
                    break;

                case 'q':
                    break;

            }
                
            
        }
    }
}
