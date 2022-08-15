using Phonebook.Library.DTO;
using Phonebook.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Library.Data
{
    public interface IPhonebookService
    {
        List<PhoneBook> Delete(int id);
        List<PhoneBook> GetAll();
        PhoneBook GetById(int id);
        PhonebookViewModel Insert(PhonebookViewModel phonebook);
        PhonebookViewModel Update(int id, PhonebookViewModel phonebook);
    }
}
