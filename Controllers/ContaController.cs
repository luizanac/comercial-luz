using AutoMapper;
using ContaLuz.Data;
using ContaLuz.Domain;
using ContaLuz.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaLuz.Controllers
{    
	public class ContaController : Controller
	{
		private readonly IMapper _mapper;
		private readonly IRepository<Conta> _contaRepository;

		public ContaController(IMapper mapper, IRepository<Conta> contaRepository){
			_mapper = mapper;
			_contaRepository = contaRepository;
		}

		public IActionResult Index(){
			var contas = _contaRepository.GetAll();
			return View(contas);
		}
		
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(ContaViewModel contaModel)
		{

			if (!ModelState.IsValid)
			{			
				return View(contaModel);
			}
			
			var conta = _mapper.Map<Conta>(contaModel);
			_contaRepository.Save(conta);
			_contaRepository.Commit();
			return RedirectToAction("Index");
		}
		
		[HttpGet]
		public IActionResult Update(int id)
		{
			var conta = _contaRepository.GetById(id);
			var contaModel = _mapper.Map<ContaViewModel>(conta);
			return View(contaModel);
		}

		[HttpPost]
		public IActionResult Update(ContaViewModel contaModel)
		{
			var conta = _mapper.Map<Conta>(contaModel);
			_contaRepository.Update(conta);
			_contaRepository.Commit();
			return RedirectToAction("Index");
		}
		
		[HttpGet]
		public IActionResult Delete(int id)
		{
			_contaRepository.Delete(id);
			_contaRepository.Commit();
			return RedirectToAction("Index");
		}

	}
}