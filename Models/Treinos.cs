using System.ComponentModel.DataAnnotations;

namespace HealthBreath.Models
{
    public class Treino
    {
        public int ID { get; set; }
        public string DiaSemana { get; set; }
        public string Musculo { get; set; }
        public string Exercicios { get; set; }
    }
}