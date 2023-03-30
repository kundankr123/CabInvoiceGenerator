namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to master branch of Cab Invoice Generator.");

            double distance, time, fare;

            Console.WriteLine("Enter the distance travelled in km: ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the time taken in minutes: ");
            time = Convert.ToDouble(Console.ReadLine());

            fare = (distance * 10) + (time * 1);

            if (fare < 5)
            {
                fare = 5;
            }

            Console.WriteLine("Total fare: Rs. " + fare);
        }
    }
}