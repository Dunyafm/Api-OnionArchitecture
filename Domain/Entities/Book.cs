using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public  class Book : BaseEntity
   {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Page { get; set; }
        public float Price { get; set; }


    }
}
