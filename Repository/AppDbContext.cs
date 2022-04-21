using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository
{
   public  class AppDbContext : DbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
      {

      }

   }
}
