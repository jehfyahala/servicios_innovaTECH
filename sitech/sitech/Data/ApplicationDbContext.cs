using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sitech.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sitech.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //ingreso del nombre de las tablas nuevas y lista de objetos de tipos de productos
        //Tabla tipos de productos
        public DbSet<ProductType> ProductTypes { get; set; }
        //Tabla Productos
        public DbSet<Product> Products { get; set; }

    }
}
