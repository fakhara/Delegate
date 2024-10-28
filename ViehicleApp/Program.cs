namespace ViehicleApp
{
    public delegate IVehicle VehicleDelegate();
    public class Program
    {
        static void Main(string[] args)
        {
            // Visa meny till användaren
            Console.WriteLine("Välj ett fordon:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Formula Car");
            Console.Write("Ditt val: ");
            string choice = Console.ReadLine();

            // Steg 6: Använd VehicleDelegate för att tilldela rätt fordon från Factory
            VehicleDelegate vehicleDelegate = () => VehicleFactory.GetVehicle(choice);

            IVehicle selectedVehicle = vehicleDelegate();

            // Kontrollera om ett fordon valdes och kör Drive-metoden
            if (selectedVehicle != null)
            {
                Console.WriteLine(selectedVehicle.Drive());
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Försök igen.");
            }
        }
    }
}