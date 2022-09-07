using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Holaweb.App.Dominio;

namespace Holaweb.App.Persistencia.AppRepositorios
{
    public class RepositorioSaludosMemoria : IRepositorioSaludos
    {
        List<Saludo> saludos;
        public RepositorioSaludosMemoria()
        {
            saludos = new List<Saludo>()
            {
                new Saludo{Id = 1, InSpanish = "Buenos Días", InEnglish = "GoodMorning", InItalian = "Bungiorno"},
                new Saludo{Id = 2, InSpanish = "Buenas tardes", InEnglish = "Good Afternoon", InItalian = "Buon pomeriggio"},
                new Saludo{Id = 3, InSpanish = "Buenas Noches", InEnglish = "Good Evening", InItalian = "Buona notte"},
            };
        }
        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }
    }
}