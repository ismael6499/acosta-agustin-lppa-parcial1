using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica1parciallppa1.Business;
using practica1parciallppa1.Data.Entities;

namespace primerparciallppa.Controllers
{
    public class AfiliadoController : Controller
    {
        AfiliadoBiz afiliadoBiz = new AfiliadoBiz();

        // GET: Producto
        public ActionResult Index()
        {
            var lista = afiliadoBiz.Listar();
            return View(lista);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            afiliadoBiz.Agregar(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var producto = afiliadoBiz.Get(id);
            if (producto == null)
            {
                return View();
            }

            return View(producto);
        }
        [HttpPost]
        public ActionResult Edit(Afiliado model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }

            afiliadoBiz.Update(model);

            return RedirectToAction("Index");
        }
        //por defecto es GET
        public ActionResult Delete(int id)
        {
            var afiliado = afiliadoBiz.Get(id);
            if (afiliado == null)
            {
                return View();
            }

            return View(afiliado);
        }

        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {
            if (model == null)
            {
                return View();
            }

            var afiliado = afiliadoBiz.Get(model.Id);

            afiliadoBiz.Eliminar(afiliado);
            return RedirectToAction("Index");
        }

       
    }
}
