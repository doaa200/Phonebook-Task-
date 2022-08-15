using MediatR;
using Phonebook.Library.Commands;
using Phonebook.Library.Data;
using Phonebook.Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Handlers
{
    public class AddPhonebookHandler:IRequestHandler<AddPhonebookCommand, PhonebookViewModel>
    {
        private readonly IPhonebookService _dataService;

        public AddPhonebookHandler(IPhonebookService dataService)
        {
            _dataService = dataService;
        }
        public Task<PhonebookViewModel> Handle(AddPhonebookCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataService.Insert(request.viewmodel));
        }
    }
}
