using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuevaWeb.App.Dominio;

namespace NuevaWeb.App.Persistencia
{
    public class RepositorioSaludos : IRepositorioSaludos
    {
        List<Saludo> saludos;

        public RepositorioSaludos()
        {
            saludos = new List<Saludo>()
        {
            new Saludo{Id=1,Italiano = "Buongiorno", Japones = "Ohayo", Ruso ="dobroye utro"},
            new Saludo{Id=2,Italiano = "Buon Pomeriggio", Japones = "Kon'nichiwa", Ruso ="Ddobryy den"},
            new Saludo{Id=3,Italiano = "Buona Notte", Japones = "Oyasumi", Ruso ="Spokoynoy nochi"},
        };
        }
        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }

    }


}
