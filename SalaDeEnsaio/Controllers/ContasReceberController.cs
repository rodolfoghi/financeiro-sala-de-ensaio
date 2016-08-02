﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalaDeEnsaio.Models;

namespace SalaDeEnsaio.Controllers
{
    public class ContasReceberController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ContasReceber
        public ActionResult Index()
        {
            var contasReceber = db.ContasReceber.Include(c => c.Pessoa);
            return View(contasReceber.ToList());
        }

        // GET: ContasReceber/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaReceber contaReceber = db.ContasReceber.Find(id);
            if (contaReceber == null)
            {
                return HttpNotFound();
            }
            return View(contaReceber);
        }

        // GET: ContasReceber/Create
        public ActionResult Create()
        {
            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome");
            return View();
        }

        // POST: ContasReceber/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Valor,Recebido,PessoaId,Vencimento")] ContaReceber contaReceber)
        {
            if (ModelState.IsValid)
            {
                db.ContasReceber.Add(contaReceber);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome", contaReceber.PessoaId);
            return View(contaReceber);
        }

        // GET: ContasReceber/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaReceber contaReceber = db.ContasReceber.Find(id);
            if (contaReceber == null)
            {
                return HttpNotFound();
            }
            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome", contaReceber.PessoaId);
            return View(contaReceber);
        }

        // POST: ContasReceber/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Valor,Recebido,PessoaId,Vencimento")] ContaReceber contaReceber)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contaReceber).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PessoaId = new SelectList(db.Pessoas, "Id", "Nome", contaReceber.PessoaId);
            return View(contaReceber);
        }

        // GET: ContasReceber/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContaReceber contaReceber = db.ContasReceber.Find(id);
            if (contaReceber == null)
            {
                return HttpNotFound();
            }
            return View(contaReceber);
        }

        // POST: ContasReceber/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ContaReceber contaReceber = db.ContasReceber.Find(id);
            db.ContasReceber.Remove(contaReceber);
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
