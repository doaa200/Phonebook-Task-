using MediatR;
using Phonebook.Library.Data;
using Phonebook.Library.Models;
using Phonebook.Library.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Handlers
{
    public class GetPhonebookbyIdHandler : IRequestHandler<GetPhonebookbyIdQuery, PhoneBook>
    {
        //private readonly IMediator _mediator;

        //public GetPhonebookbyIdHandler(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}
        private readonly IPhonebookService _dataService;

        public GetPhonebookbyIdHandler(IPhonebookService dataService)
        {
            _dataService = dataService;
        }
        public async Task<PhoneBook> Handle(GetPhonebookbyIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_dataService.GetById(request.Id));
        }
    }
}
