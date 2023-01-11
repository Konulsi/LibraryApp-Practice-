using DomainLayer.Models;
using RepositoryLayer.Repositories;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class LibraryService : ILibraryService
    {

        private readonly LibraryRepository _repo;
        private int _count = 1;
        public LibraryService()
        {
            _repo = new LibraryRepository();
        }


        public Library Create(Library library)
        {
            library.Id = _count;
            _repo.Create(library);
            _count++;   
            return library;
        }

        public Library Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Library> Search(string searchtext)
        {
            throw new NotImplementedException();
        }
    }
}
