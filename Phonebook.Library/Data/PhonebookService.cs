using AutoMapper;
using Phonebook.Library.DTO;
using Phonebook.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Data
{
    public class PhonebookService:IPhonebookService
    {
        private readonly IMapper _mapper;
        ApplicationDbContext context;
        public PhonebookService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public List<PhoneBook> GetAll()
        {
            return context.phonebook.ToList();
        }
        public PhoneBook GetById(int id)
        {
            return context.phonebook.FirstOrDefault(p => p.ID == id);
        }
        public PhonebookViewModel Insert(PhonebookViewModel phonebook)
        {
            context.phonebook.Add(new PhoneBook
            {
                ID = phonebook.ID,
                FirstName = phonebook.FirstName,
                LastName = phonebook.LastName,
                Contact = phonebook.Contact,
            });
            context.SaveChanges();
            return phonebook;
        }


        public PhonebookViewModel Update(int id, PhonebookViewModel phonebook)
        {
            PhoneBook oldcontact = GetById(id);
            if (oldcontact != null)
            {
                oldcontact.FirstName = phonebook.FirstName;
                oldcontact.LastName = phonebook.LastName;
                oldcontact.Contact = phonebook.Contact;


                context.SaveChanges();
            }
            return phonebook;
        }

        //public int Delete(int id)
        //{
        //    PhoneBook oldcontact = GetById(id);
        //    context.phonebook.Remove(oldcontact);
        //    return context.SaveChanges();
        //}
        public List<PhoneBook> Delete(int id)
        {
            PhoneBook oldcontact = GetById(id);
            context.phonebook.Remove(oldcontact);
             context.SaveChanges();
            return context.phonebook.ToList();
        }


    }
}
