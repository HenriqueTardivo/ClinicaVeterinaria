using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string TipoAnimal { get; set; }
        public string Raca { get; set; }
        public string Observacoes { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
