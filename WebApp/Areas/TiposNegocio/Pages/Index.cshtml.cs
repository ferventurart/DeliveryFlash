using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Areas.TiposNegocio.Pages
{
    public class IndexModel : PageModel
    {
        public List<TipoNegocio> TiposNegocio { get; set; }
        public UIPaginationModel UIPagination { get; set; }
        public void OnGet()
        {
            UIPagination = new UIPaginationModel(1, string.Empty, 10, 0);
            TiposNegocio = new List<TipoNegocio>();
        }
    }
}
