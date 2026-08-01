using AirlineBookingSystem.Flights.Application.Commands;
using AirlineBookingSystem.Flights.Core.Repositories;
using MediatR;

namespace AirlineBookingSystem.Flights.Application.Handlers
{
    public class DeleteFlightHandler : IRequestHandler<DeleteFlightCommand>
    {
        private readonly IFlighRepository _repository;

        public DeleteFlightHandler(IFlighRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteFlightCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteFlightAsync(request.id);
        }
    }
}
