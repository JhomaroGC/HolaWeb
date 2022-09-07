using Holaweb.App.Dominio;
using Holaweb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioSaludos repositorioSaludos;
        public IEnumerable<Saludo> Saludos {get; set;}
        public ListModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }
        public void OnGet()
        {
            Saludos = repositorioSaludos.GetAll();
        }
    }
}
