using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Library.Attributes;
using Phonebook.Library.Commands;
using Phonebook.Library.Models;

namespace TechnicalTask_PhoneBook.Endpoints.Phonebook
{
    public class Delete
    {
        [FromRoute(Name = "id")] public int Id { get; init; }
    }
    public class DeleteEndpoint : EndpointBaseAsync.WithRequest<Delete>.WithActionResult<List<PhoneBook>>
    {
        private readonly IMediator _mediator;

        public DeleteEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("{id}")]
        public override async Task<ActionResult<List<PhoneBook>>> HandleAsync([FromRoute] Delete request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new DeletePhonebookCommand(request.Id));
        }
    }
}
