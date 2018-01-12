using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelWeb.Data
{
    public class HotelWebDbContext: DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }

        public HotelWebDbContext(DbContextOptions<HotelWebDbContext> options)
            : base(options)
        { }
    }
}
