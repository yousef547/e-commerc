
using E_commerce.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        #region Tables
        public virtual DbSet<TbCatagery> TbCatageries{ get; set; }
        public virtual DbSet<TbProduct> TbProducts{ get; set; }
        public virtual DbSet<TbColor> TbColors{ get; set; }
        public virtual DbSet<TbSize> TbSizes{ get; set; }



        #endregion




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
