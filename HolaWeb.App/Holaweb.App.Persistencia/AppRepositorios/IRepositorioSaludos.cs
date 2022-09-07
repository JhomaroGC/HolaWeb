using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Holaweb.App.Dominio;

namespace Holaweb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();
    }
}