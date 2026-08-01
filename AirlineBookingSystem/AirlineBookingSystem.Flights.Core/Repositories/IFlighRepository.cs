using AirlineBookingSystem.Flights.Core.Entities;

namespace AirlineBookingSystem.Flights.Core.Repositories
{
    public interface IFlighRepository
    {
        Task<IEnumerable<Flight>> GetFlightsAsync();
        Task AddFlightAsync(Flight flight);
        Task DeleteFlightAsync(Guid id);
    }
}
