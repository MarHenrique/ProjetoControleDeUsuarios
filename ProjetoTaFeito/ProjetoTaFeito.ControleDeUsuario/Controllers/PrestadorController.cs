using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoTaFeito.ControleDeUsuario.Models;

namespace ProjetoTaFeito.ControleDeUsuario.Controllers
{
    public class PrestadorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Prestador
        public ActionResult Index()
        {
            return View(db.Prestadors.ToList());
        }

        // GET: Prestador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestador prestador = db.Prestadors.Find(id);
            if (prestador == null)
            {
                return HttpNotFound();
            }
            return View(prestador);
        }

        // GET: Prestador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prestador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,SobreNome,Email,TelefoneFixo,TelefoneCelular,DataAtendimentoInicio,DataAtendimentoFinal")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                db.Prestadors.Add(prestador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prestador);
        }

        // GET: Prestador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestador prestador = db.Prestadors.Find(id);
            if (prestador == null)
            {
                return HttpNotFound();
            }
            return View(prestador);
        }

        // POST: Prestador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,SobreNome,Email,TelefoneFixo,TelefoneCelular,DataAtendimentoInicio,DataAtendimentoFinal")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prestador);
        }

        // GET: Prestador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestador prestador = db.Prestadors.Find(id);
            if (prestador == null)
            {
                return HttpNotFound();
            }
            return View(prestador);
        }

        // POST: Prestador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prestador prestador = db.Prestadors.Find(id);
            db.Prestadors.Remove(prestador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
