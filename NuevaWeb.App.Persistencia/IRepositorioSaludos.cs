using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuevaWeb.App.Dominio;

namespace NuevaWeb.App.Persistencia
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();
    }
}
