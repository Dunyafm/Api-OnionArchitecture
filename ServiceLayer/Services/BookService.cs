using AutoMapper;
using RepositoryLayer.Repositories;
using ServiceLayer.DTOs.Book;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
        public class BookService : IBookService
        {
            private readonly BookRepository _repository;
            private readonly IMapper _mapper;

            public BookService(BookRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public async Task<List<BookListDto>> GetAllAsync()
            {
                var model = await _repository.GetAllAsync();
                var res = _mapper.Map<List<BookListDto>>(model);

                return res;
            }
        }


 
}
