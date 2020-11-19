using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Scribblefy.Models
{
    [Table("TB_LOCALIZACAO")]
    public class Localizacao
    {
        [Column("Id")]
        public int LocalizacaoId { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(100)]
        public string Latitude { get; set; }

        [Required, MaxLength(100)]
        public string Longitude { get; set; }

    }
}
