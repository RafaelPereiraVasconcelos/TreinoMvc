using System.ComponentModel.DataAnnotations;
using TreinoMvc.Models;
using TreinoMvc.Models.Enuns;


namespace TreinoMvc.Models
{
    public class ExercicioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Repeticao { get; set; }
        public int Execucao { get; set; }
        public int TempoMin { get; set; }
        public ClasseEnum Classe { get; set; }
    }
}