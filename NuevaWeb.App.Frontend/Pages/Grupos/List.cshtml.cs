using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NuevaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private String[] grupos = {"Grupo 1", "Grupo 2", "Grupo 3", "Grupo 4"};

        public List <string> GruposMision {get; set;}

        public void OnGet()
        {
            GruposMision = new List<string>();
            GruposMision.AddRange(grupos);
        }
    }
}
