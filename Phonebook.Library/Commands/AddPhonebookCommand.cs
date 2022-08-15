using MediatR;
using Phonebook.Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Commands
{
    public record AddPhonebookCommand(PhonebookViewModel viewmodel) : IRequest<PhonebookViewModel>;
}
