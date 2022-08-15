using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Library.Attributes;
using Phonebook.Library.Commands;
using Phonebook.Library.DTO;

namespace TechnicalTask_PhoneBook.Endpoints.Phonebook
{
    public class UpdatePhonebook
    {
        [FromRoute(Name = "id")] public int Id { get; init; }
        [FromBody] public PhonebookViewModel viewmodel { get; set; } = default!;
    }
    public class UpdateEndpoint : EndpointBaseAsync.WithRequest<UpdatePhonebook>.WithActionResult<PhonebookViewModel>
    {
        private readonly IMediator _mediator;

        public UpdateEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("{id:int}")]
        public override async Task<ActionResult<PhonebookViewModel>> HandleAsync([FromMultiSource]UpdatePhonebook request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new EditPhonebookCommand(request.viewmodel,request.Id));
        }
    }
}
