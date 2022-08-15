using MediatR;
using Phonebook.Library.Commands;
using Phonebook.Library.Data;
using Phonebook.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Handlers
{
    public class DeletePhonebookHandler : IRequestHandler<DeletePhonebookCommand, List<PhoneBook>>
    {
        private readonly IPhonebookService _dataService;

        public DeletePhonebookHandler(IPhonebookService dataService)
        {
            _dataService = dataService;
        }
        public Task<List<PhoneBook>> Handle(DeletePhonebookCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataService.Delete(request. id));
        }
    }
}
