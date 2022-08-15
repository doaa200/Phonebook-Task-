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
    public class GetPhonebookListHandler : IRequestHandler<GetPhonebookListQuery, List<PhoneBook>>
    {
        private readonly IPhonebookService _dataService;

        public GetPhonebookListHandler(IPhonebookService dataService)
        {
            _dataService = dataService;
        }
        public Task<List<PhoneBook>> Handle(GetPhonebookListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataService.GetAll());
        }
    }
}
