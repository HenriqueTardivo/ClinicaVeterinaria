using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Models
{
    public class ClinicaVeterinariaContext : DbContext
    {
        public ClinicaVeterinariaContext(DbContextOptions<ClinicaVeterinariaContext> options)
            : base(options)
        {
        }


        public DbSet<ClinicaVeterinaria.Models.Usuario> Usuario { get; set; }





        public DbSet<ClinicaVeterinaria.Models.Exame> Exame { get; set; }





        public DbSet<ClinicaVeterinaria.Models.Animal> Animal { get; set; }





        public DbSet<ClinicaVeterinaria.Models.Medicamento> Medicamento { get; set; }





        public DbSet<ClinicaVeterinaria.Models.Consulta> Consulta { get; set; }
    }
}
