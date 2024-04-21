using BusinessLayer;
using Microsoft.Build.Execution;

namespace PresentationLayer.Models
{
    public class FlightPageManagerViewModel
    {
        public IEnumerable<Flight> Flights { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public int Pages { get; set; }

        public FlightPageManagerViewModel()
        {
            Flights = new List<Flight>();
        }

        public FlightPageManagerViewModel(List<Flight> Flights, int currentPage = 1, int pageSize = 5)
        {
            this.Flights = Flights;
            CurrentPage = currentPage;
            PageSize = pageSize;
            Pages = Flights.Count / PageSize + 1;
        }

    }
}
