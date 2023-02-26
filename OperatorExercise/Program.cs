namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // for division ,create two integer variables called a and b.

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine($"Please enter the radius of a cicle?");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)

        {

            var area = Math.PI * Math.Pow(radius, 2);
          
            return area;

        }








        













































    }
































}
    
    