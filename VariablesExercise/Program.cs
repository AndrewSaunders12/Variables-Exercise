namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dog = "Nick";

            int age = 12;

            char middleinitial = 'k';

            bool superHero = true;

            double days = 5000.00;

            decimal power = 50000.01m;

            Console.WriteLine($"{dog} is a good doggy. his age is {age}, and his middle name starts with a {middleinitial}" +
                $". {dog} is a {superHero} superhero that will reign for {days} years" +
              $", and his doggy power is at {power}." );
        }
    }
}
