using Domain.Entities;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class BookRepository : Repository<Book>, BookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {

        }
    }
}