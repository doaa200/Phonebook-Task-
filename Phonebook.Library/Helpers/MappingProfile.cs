using AutoMapper;
using Phonebook.Library.DTO;
using Phonebook.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<PhoneBook, PhonebookViewModel>();
            CreateMap<PhonebookViewModel,PhoneBook >();
        }
    }
}
