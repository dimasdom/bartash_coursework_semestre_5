using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.DataBase.ApplicationDbContext
{
    public class AppDbContext : IdentityDbContext<UserModel>
    {
        /// <summary>
        /// Конструктор класу контексту додатка.
        /// </summary>
        /// <param name="options">Параметри конфігурації контексту.</param>
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Таблиця автобаз.
        /// </summary>
        public DbSet<AutoBase> AutoBases { get; set; }

        /// <summary>
        /// Таблиця постачальників.
        /// </summary>
        public DbSet<Supplier> Suppliers { get; set; }

        /// <summary>
        /// Таблиця співробітників.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Таблиця витрат палива.
        /// </summary>
        public DbSet<FuelConsumption> FuelConsumption { get; set; }
    }

}
