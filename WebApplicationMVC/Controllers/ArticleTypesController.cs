using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC;

namespace WebApplicationMVC.Controllers
{
    public class ArticleTypesController : Controller
    {
        private TinaBlogEntities db = new TinaBlogEntities();

        // GET: ArticleTypes
        public ActionResult Index()
        {
            List<ArticleType> c = db.ArticleType.ToList();
            return View(c);
        }

        // GET: ArticleTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleType articleType = db.ArticleType.Find(id);
            if (articleType == null)
            {
                return HttpNotFound();
            }
            return View(articleType);
        }

        // GET: ArticleTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleTypes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ArticleTypeName,ArticleCounts,DelFlag")] ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                db.ArticleType.Add(articleType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(articleType);
        }

        // GET: ArticleTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleType articleType = db.ArticleType.Find(id);
            if (articleType == null)
            {
                return HttpNotFound();
            }
            return View(articleType);
        }

        // POST: ArticleTypes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ArticleTypeName,ArticleCounts,DelFlag")] ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articleType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(articleType);
        }

        // GET: ArticleTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleType articleType = db.ArticleType.Find(id);
            if (articleType == null)
            {
                return HttpNotFound();
            }
            return View(articleType);
        }

        // POST: ArticleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArticleType articleType = db.ArticleType.Find(id);
            db.ArticleType.Remove(articleType);
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
