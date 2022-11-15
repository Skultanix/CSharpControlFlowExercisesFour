namespace ControlFlowExercisesFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Speed Camera Calulator.");
            Console.WriteLine("Please enter the Speed Limit in the locality where you were driving (mph).");
            var speedLimit = Console.ReadLine();
            Console.WriteLine("Very good. Now please input the speed of your vehicle (again, in mph)");
            var carSpeed = Console.ReadLine();

            var speedLimitValue = int.Parse(speedLimit);
            var carSpeedValue = int.Parse(carSpeed);

            var speedingAmount = carSpeedValue - speedLimitValue;
            decimal demeritBase = speedingAmount / 5;

            var demeritCount = Math.Round(demeritBase);

            if ((demeritCount > 0) && (demeritCount <= 2))
            {
                System.Console.WriteLine("You're speeding but it's negligible.");
            }
            else if ((demeritCount > 2) && (demeritCount <= 3))
            {
                System.Console.WriteLine("You're definately speeding, and will likely get ticked if caught.");
            }
            else
            {
                System.Console.WriteLine("Liscense suspended.");
            }
        }
    }
}