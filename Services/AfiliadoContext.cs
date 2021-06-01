using DiazPierri_Ezequiel_LPPA_Parcial1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DiazPierri_Ezequiel_LPPA_Parcial1.Services
{
    public class AfiliadoContext : DbContext
    {
        public AfiliadoContext()
            :base("DefaultConnection")
        {

        }
        public DbSet<Afiliado> Afiliados { get; set; }
    }
}