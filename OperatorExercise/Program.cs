namespace OperatorExercise
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int division = a / b;
            int mod = a % b;
            Console.WriteLine($"{a}/{b} = {division} remainder {mod}");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

           
           
            double myarea = AreaOfCircle(3);
            Console.WriteLine(myarea);

            Console.WriteLine(myarea + b);
            Console.WriteLine(myarea * b);
            Console.WriteLine(myarea - b);
            Console.WriteLine(myarea / b);
            Console.WriteLine(myarea % b);

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
            
        }
        


    }
}
