namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int magic() => 10;
            for (int i = 0; i < magic(); i++) 
                Console.WriteLine("Hello, World!");
        }
    }
}
