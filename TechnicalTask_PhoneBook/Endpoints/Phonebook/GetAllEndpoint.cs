using Phonebook.Library.Models;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Phonebook.Library.Queries;

namespace TechnicalTask_PhoneBook.Endpoints.Phonebook
{
    public class GetAllEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<List<PhoneBook>>
    {
        private readonly IMediator _mediator;

        public GetAllEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAll")]
        public override async Task<ActionResult<List<PhoneBook>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetPhonebookListQuery());
        }
    }
}
