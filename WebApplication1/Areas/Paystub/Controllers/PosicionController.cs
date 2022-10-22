using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Models.ViewModel;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Areas.Paystub.Controllers
{
    [Area("paystub")]
    public class PosicionController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public PosicionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Index
        public IActionResult Index()
        {
            PositionVM model = new PositionVM
            {
                Posiciones = _unitOfWork.Posicion.PosicionesConProyecto()
            };

            return View(model);
        }

        #endregion


        #region Create
        public IActionResult Create()
        {
            PositionVM model = new PositionVM()
            {
                Posicion = new Posicion(),
                ListaProyectos = new System.Web.Mvc.SelectList(_unitOfWork.Proyecto.GetAll().ToList(), "proyecto_id", "compania")
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PositionVM model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Posicion.Add(model.Posicion);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        #endregion


    }
}
