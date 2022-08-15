using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Library.Attributes;
using Phonebook.Library.DTO;
using Phonebook.Library.Models;
using Phonebook.Library.Queries;

namespace TechnicalTask_PhoneBook.Endpoints.Phonebook
{
    public class getbyid
    {
        [FromRoute(Name = "id")] public int Id { get; init; }
    }
    public class GetbyIdEndpoint : EndpointBaseAsync.WithRequest<getbyid>.WithActionResult<PhoneBook>
    {
        private readonly IMediator _mediator;

        public GetbyIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public override async Task<ActionResult<PhoneBook>> HandleAsync([FromRoute]getbyid request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetPhonebookbyIdQuery(request.Id));
        }
    }
}
