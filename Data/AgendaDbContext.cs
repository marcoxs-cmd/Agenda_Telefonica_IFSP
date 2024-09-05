using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agenda.Models;

namespace Agenda.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext (DbContextOptions<AgendaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agenda.Models.Contato> Contato { get; set; } = default!;
    }
}
