namespace MineSweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные(m,n,p) через пробел: ");
            
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            int.TryParse(values[0], out int m);
            int.TryParse(values[1], out int n);
            int.TryParse(values[2], out int p);

            Field field = new Field(m, n, p);

        }
    }
}