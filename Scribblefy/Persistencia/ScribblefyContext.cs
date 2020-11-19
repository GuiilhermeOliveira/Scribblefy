using Microsoft.EntityFrameworkCore;
using Scribblefy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribblefy.Persistencia
{
    public class ScribblefyContext : DbContext
    {
        public DbSet<Localizacao> Localizacaos { get; set; }


        public ScribblefyContext(DbContextOptions op) : base(op)
        {
                
        }

       
    }
}
