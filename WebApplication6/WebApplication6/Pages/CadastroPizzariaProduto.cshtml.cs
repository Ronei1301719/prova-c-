using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class CadastroPizzariaProdutoModel : PageModel
    {
        public string Message { get; set; }
        public string Result { get; set; }
        public string Result1 { get; set; }
        public string Result2 { get; set; }
        public string Result3 { get; set; }


        public void OnPost(string queijo, string calabresa, string frango, string refri)
        {
            Result = "Quantidade de queijo: " + queijo + " kg. //";
            Result1 = "Quantidade de calabresa: " + calabresa + " kg. //";
            Result2 = "Quantidade de frango: " + frango + " kg. //";
            Result3 = "Quantidade de refrigerante: " + refri + " kg. //";


        }

    }
}