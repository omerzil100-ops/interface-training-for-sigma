namespace interface_training_for_sigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 3);
            Fraction c = (Fraction)a.Add(b);
            Fraction d = (Fraction)a.Subtract(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
