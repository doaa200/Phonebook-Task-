using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Library.Commands;
using Phonebook.Library.DTO;

namespace TechnicalTask_PhoneBook.Endpoints.Phonebook
{
    public class CreateEndpoint : EndpointBaseAsync.WithRequest<PhonebookViewModel>.WithActionResult<PhonebookViewModel>
    {
        private readonly IMediator _mediator;

        public CreateEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Phonebook")]
        public override async Task<ActionResult<PhonebookViewModel>> HandleAsync(PhonebookViewModel request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new AddPhonebookCommand(request));
        }
    }
}
