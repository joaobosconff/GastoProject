using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace GastoProject.DATA.Model
{
    public class Gasto
    {
        public int Id { get; set; }

        public DateTime DataDeRegistro { get; set; }

        [Column(TypeName = "decimal(32,2)")]
        public decimal Preco { get; set; }

        public string Descricao { get; set; }

    }
}
