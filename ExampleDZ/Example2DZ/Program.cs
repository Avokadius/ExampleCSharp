namespace Example2DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            var numberTwo = Convert.ToInt32(Console.ReadLine());

            var sum = numberOne + numberTwo;
            var sumdifference = numberOne - numberTwo;
            var multiplication = numberOne * numberTwo;
            double privatee = 0;

            try
            {
                privatee = numberOne / (double)numberTwo;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль невозможно.");
            }
            Console.WriteLine($" Сумма: {sum}\n Разность: {sumdifference}\n Произведение: {multiplication}\n Частное: {privatee}");

        }
    }
}
