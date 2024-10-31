using ControleFinanceiro.Data.Repositorio.Interfaces;
using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class Despesascontroller : Controller
    {
        private readonly IDespesasRepositorio _despesasrepositorio;

        public Despesascontroller(IDespesasRepositorio despesasRepositorio)
        {
            _despesasrepositorio = despesasRepositorio;
        }

        public IActionResult Index()
        {
            var despesas = _despesasrepositorio.BuscarDespesas();
            var totalDespesas = despesas.Sum(d => d.Valor);

            ViewBag.TotalDespesas = totalDespesas; 
            return View(despesas);
        }

        public ActionResult GraficoPizza()
        {
            var despesas = _despesasrepositorio.BuscarDespesas();

            var dadosGrafico = despesas
        .GroupBy(v => v.Categoria)
        .Select(g => new
        {
            Categoria = g.Key,
            Total = g.Sum(v => v.Valor)
        })
        .ToList();

          
            var viewModel = new DespesasViewModel
            {
                Despesas = despesas,
                DadosGrafico = dadosGrafico
            };

            return View(viewModel);
        }

        public IActionResult AdicionarDespesas()
        {
            return View();
        }

        public IActionResult IncluirDespesas(DespesasModel despesas)
        {
            
           
            if (despesas.DataTransacao == DateTime.MinValue)
            {
                despesas.DataTransacao = DateTime.Now; 
            }

           
            if (!ModelState.IsValid)
            {
                return View(despesas);
            }

            _despesasrepositorio.AddDespesas(despesas);
            return RedirectToAction("Index");

           
        }

        public IActionResult Editar(int id)
        {
            var despesas = _despesasrepositorio.BuscarId(id);
            return View(despesas);
        }

        public IActionResult EditarDespesas(DespesasModel despesas)
        {
            _despesasrepositorio.EditarDespesas(despesas);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(DespesasModel despesas)
        {
            _despesasrepositorio.Excluir(despesas);
            return RedirectToAction("Index");
        }
    }
}




