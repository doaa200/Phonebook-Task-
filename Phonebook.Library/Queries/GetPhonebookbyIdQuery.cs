using MediatR;
using Phonebook.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Queries
{
    public record GetPhonebookbyIdQuery(int Id) : IRequest<PhoneBook>;
}
