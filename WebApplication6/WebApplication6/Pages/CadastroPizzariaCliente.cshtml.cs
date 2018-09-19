using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class CadastroPizzariaClienteModel : PageModel
    {
        public string Message { get; set; }
        public string Result { get; set; }
        public string RelatorioCliente { get; set; }
            

                public RedirectToPageResult OnPost(string bairro, string idade, string pessoas, string consumo, string sabor, string ponto,
                          string entrega, string bebida, string promo, string whats)
        {
            ArrayList Pizzas = new ArrayList() { bairro, idade, pessoas, consumo, sabor, ponto, entrega, bebida, promo, whats };
            Pizzas.Add("O seu bairro é: " + bairro + ". Sua idade está entre: " + idade + ". Na sua casa moram " + pessoas + ". Você consome " + consumo + " por mês. Seu sabor preferido é: " 
            + sabor + ". A massa deve estar " + ponto + ". Você costuma " + entrega + ". Você " + bebida + 
            ". Você " + promo + ". Você "+ whats);


            foreach (string var in Pizzas)
        {
            Console.WriteLine(var);
            RelatorioCliente = var;
        }
        return RedirectToPage("RelatorioCliente", new {Teste = RelatorioCliente });


        }

    }
}
