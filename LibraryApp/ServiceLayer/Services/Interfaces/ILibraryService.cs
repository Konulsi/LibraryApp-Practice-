using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Create(Library library);
        Library Delete(int Id);
        Library GetById(int Id);
        List<Library> Search(string searchtext);
        List<Library> GetAll();


    }
}
