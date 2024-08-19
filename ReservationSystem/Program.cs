using ReservationSystem.Entities;
using ReservationSystem.Entities.Exceptions;

namespace ReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine("\n[@] Enter data to update reservation:");
                Console.Write(" |- Check-in date (dd/MM/yyyy)");
                DateTime updateCheckIn = DateTime.Parse(Console.ReadLine());

                Console.Write(" |- Check-out date (dd/MM/yyyy)");
                DateTime updateCheckOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(updateCheckIn, updateCheckOut);

                Console.WriteLine(reservation);

            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Error in reservation: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format error in rerservation: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in rerservation: {ex.Message}");
            }



        }
    }
}
