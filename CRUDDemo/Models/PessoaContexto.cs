using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDDemo.Models
{
    public class PessoaContexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set;} 

    }
}