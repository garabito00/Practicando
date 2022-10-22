using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ViewModel;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Areas.Paystub.Controllers
{
    [Area("Paystub")]
    public class ProyectoController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProyectoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Index
        public IActionResult Index()
        {
            ProyectoVM model = new ProyectoVM
            {
                ProyectosLista = _unitOfWork.Proyecto.GetAll()
            }; 

            return View(model);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProyectoVM model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Proyecto.Add(model.Proyecto);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        #endregion

        #region Edit
        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            ProyectoVM model = new ProyectoVM();
            model.Proyecto = _unitOfWork.Proyecto.FindOne(p => p.Proyecto_Id == id);

            if(model.Proyecto == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProyectoVM model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Proyecto.Update(model.Proyecto);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            ProyectoVM model = new ProyectoVM();
            model.Proyecto = _unitOfWork.Proyecto.FindOne(p => p.Proyecto_Id == id);

            if (model.Proyecto == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ProyectoVM model)
        {
            _unitOfWork.Proyecto.Delete(model.Proyecto);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        #endregion
    }
}
