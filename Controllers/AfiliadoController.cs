using DiazPierri_Ezequiel_LPPA_Parcial1.Models;
using DiazPierri_Ezequiel_LPPA_Parcial1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiazPierri_Ezequiel_LPPA_Parcial1.Controllers
{
    public class AfiliadoController : Controller
    {
        private AfiliadoDataServices _services;

        public AfiliadoController()
        {
            _services = new AfiliadoDataServices();
        }

        // GET: Afiliado
        public ActionResult Index()
        {
            var model = _services.TraerTodo();
            return View(model);
        }

        // GET: Afiliado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Afiliado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Afiliado/Create
        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _services.Crear(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                //  Log
            }
            return View(model);
        }

        // GET: Afiliado/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _services.TraerUno(id);
            return View(model);
        }

        // POST: Afiliado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Afiliado model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _services.Editar(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                //  Log
            }
            return View(model);
        }

        // GET: Afiliado/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _services.TraerUno(id);
            return View(model);
        }

        // POST: Afiliado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Afiliado model)
        {
            try
            {
                _services.Eliminar(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //  Log
            }
            return View(model);
        }
    }
}
