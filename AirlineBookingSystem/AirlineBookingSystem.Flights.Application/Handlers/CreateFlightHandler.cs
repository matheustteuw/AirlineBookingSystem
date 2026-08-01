using AirlineBookingSystem.Flights.Application.Commands;
using AirlineBookingSystem.Flights.Core.Entities;
using AirlineBookingSystem.Flights.Core.Repositories;
using MediatR;

namespace AirlineBookingSystem.Flights.Application.Handlers
{
    public class CreateFlightHandler : IRequestHandler<CreateFlightCommand, Guid>
    {
        private readonly IFlighRepository _repository;

        public CreateFlightHandler(IFlighRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateFlightCommand request, CancellationToken cancellation)
        {
            var flight = new Flight
            {
                Id = Guid.NewGuid(),
                FlightNumber = request.FlightNumber,
                Origin = request.Origin,
                Destination = request.Destination,
                DepartureTime = request.DepartureTime,  
                ArrivalTime = request.ArrivalTime
            };

            await _repository.AddFlightAsync(flight);

            return flight.Id;
        }
    }
}
