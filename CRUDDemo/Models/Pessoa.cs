using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDDemo.Models
{
    public class Pessoa
    {
        public int Id { get; set;} 
        public string Nome { get; set;}
        public DateTime DataNascimento { get; set;}
        public decimal Saldo { get; set;}

    }
}