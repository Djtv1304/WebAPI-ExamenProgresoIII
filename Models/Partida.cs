using System.ComponentModel.DataAnnotations;

namespace WebAPI_Productos_ProgramacionIV.Models
{
    public class Partida
    {
        [Key]
        public int PartidaId { get; set; }
        [Required]
        public int JugadorUnoID { get; set; }
        [Required]
        public int JugadorDosID { get; set; }

        public bool JugadorUnoIsWin { get; set; }

        public bool JugadorDosIsWin { get; set; }

        public DateTime fechaPartida { get; set; }

    }
}
