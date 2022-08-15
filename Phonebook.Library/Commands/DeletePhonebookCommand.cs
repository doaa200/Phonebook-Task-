using MediatR;
using Phonebook.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Commands
{
        public record DeletePhonebookCommand(int id) : IRequest<List<PhoneBook>>;

}
