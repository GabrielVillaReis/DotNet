namespace exercicios8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Rent[] r = new Rent[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent #{0}:", i+1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                r[room] = new Rent(name,email,room);
            }
            for (int i = 0;i < 10; i++)
            {
                if (r[i] != null)
                {
                    Console.WriteLine(r[i]);
                }
            }
        }
    }
}