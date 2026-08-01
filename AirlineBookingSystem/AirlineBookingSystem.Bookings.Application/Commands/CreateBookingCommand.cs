using MediatR;

namespace AirlineBookingSystem.Bookings.Application.Commands
{
    public record CreateBookingCommand(Guid FlightId, string PassengerName, string seatNumber) : IRequest<Guid>;
}
