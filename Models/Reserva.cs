using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeGestãodeSalas.Models
{
    public class Reserva
    {
    public int Codigo { get; set; }
    public int ProfessorCodigo { get; set; }
    public int SalaCodigo { get; set; }
    public DateTime DataReserva { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }

    }
}
