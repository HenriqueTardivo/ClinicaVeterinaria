using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public Animal Animal { get; set; }
        public string Resumo { get; set; }
        public float Preco { get; set; }
        public int MedicamentoId { get; set; }
        public int ExameId { get; set; }
        public List<Medicamento> medicamentos { get; set; }
        public List<Exame> exames { get; set; }

    }
}
