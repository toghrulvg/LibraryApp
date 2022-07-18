using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface ILibraryService
    {
        Library Create(Library library);

        Library Update(int id, Library librarys);

        void Delete(int id);
        Library GetById(int id);
        List<Library> GetAll();
    }
}
