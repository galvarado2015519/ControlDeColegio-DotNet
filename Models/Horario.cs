using System;

namespace ControlDeColegio.Models
{
    public class Horario
    {
        public string HorarioId {get; set;}
        public DateTime HorarioFinal {get; set;}
        public DateTime HorarioInicio {get;set;}

        public Horario()
        {

        }

        public Horario(string HorarioId, DateTime HorarioFinal, DateTime HorarioInicial)
        {
            this.HorarioId = HorarioId;
            this.HorarioFinal = HorarioFinal;
            this.HorarioInicio = HorarioInicio;
        }
    }
}