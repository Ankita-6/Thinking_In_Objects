using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Thinking_In_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Airlines
    {
        List<Flight> flights = new List<Flight>();
    }
    public class Flight
    {
        public bool IsAvailable { get; set; }
        List<Route> routes = new List<Route>();
    }
    public class Route
    {

    }
    public class Passenger
    {
        Flight flight = new Flight();
        Route route = new Route();
    }
    public class User
    {
        List<Passenger> pasengers = new List<Passenger>();

        public void BookTicket()
        {

        }

        public void Payment()
        {

        }
    }
}