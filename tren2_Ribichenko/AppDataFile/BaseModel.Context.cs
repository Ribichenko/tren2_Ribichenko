﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tren2_Ribichenko.AppDataFile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Ribichenko_2Entities : DbContext
    {
        private static Ribichenko_2Entities _context;

        public Ribichenko_2Entities()
            : base("name=Ribichenko_2Entities")
        {
        }

        public static Ribichenko_2Entities GetContext()
        {
            if (_context == null)
            {
                _context = new Ribichenko_2Entities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<agents> agents { get; set; }
        public virtual DbSet<history_sales> history_sales { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<type_agent> type_agent { get; set; }
        public virtual DbSet<type_product> type_product { get; set; }
    }
}