using System;
using System.Collections.Generic;
using System.Text;
using GastoProject.DATA.Model;
using Microsoft.EntityFrameworkCore;

namespace GastoProject.DATA
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Gasto> Gasto { get; set; }

    }
}
