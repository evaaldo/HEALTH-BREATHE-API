using System.ComponentModel.DataAnnotations;

namespace HealthBreath.Models
{
    public class Dieta
    {
        public int ID { get; set; }
        [DataType(DataType.Time)]
        public DateTime Horario { get; set; }
        public string Refeicao { get; set; }
    }
}