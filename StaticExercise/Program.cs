namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your temp");
            var userinput = int.Parse(Console.ReadLine());
           var celcius = TempConveter.FahrenheitToCelsius(userinput);


            Console.WriteLine($"celcius {celcius}");


            Console.WriteLine($"what is your temp");
            var userinput1 = int.Parse(Console.ReadLine());

            var fahrenheit = TempConveter.CelsiusToFahrenhiet(userinput1);

            Console.WriteLine($"fahrenheit {fahrenheit}");
        }


    }
}