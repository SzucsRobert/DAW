using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokemon_Web_App.Models;

namespace Pokemon_Web_App.Data
{
    public class PokemonAppContext:DbContext
    {
        public PokemonAppContext(DbContextOptions<PokemonAppContext> options) : base(options)
        {

        }
        public DbSet<Pokemon> PokemonTable { get; set; }
        public DbSet<Account> AccountTable { get; set; }
        public DbSet<Team> TeamTable { get; set; }
    }
}
