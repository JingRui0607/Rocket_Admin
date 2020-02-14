using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rocket_Admin.Models;

namespace Rocket_Admin.Areas.Areas.Controllers
{
    public class StudentsController : Controller
    {
        private Model1 db = new Model1();
        [Authorize]
        // GET: Areas/Students
        public ActionResult Index()
        {
            return View(db.Student.ToList());
        }

        // GET: Areas/Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Areas/Students/Create
        public ActionResult Create()
        {

            ViewBag.Class = db.Class.Max(x => x.Session);

            return View();
        }

        // POST: Areas/Students/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string classNum, string name, string oldOccupation, string targetOccupation, string presence, HttpPostedFileBase upfile)
        {
            Student student = new Student();

            if (upfile != null)
            {
                if (upfile.ContentType.IndexOf("image", System.StringComparison.Ordinal) == -1)
                {

                    return Content("檔案型態錯誤");
                }
                //取得副檔名
                string extension = upfile.FileName.Split('.')[upfile.FileName.Split('.').Length - 1];
                //新檔案名稱
                string fileName = String.Format("{0}-{1:yyyyMMddhhmmsss}.{2}", name, DateTime.Now, extension);
                string savedName = Path.Combine(Server.MapPath("/Areas/Areas/orid_admin/assets/img/user"), fileName);
                upfile.SaveAs(savedName);

     

                student.image = fileName;




            }
            else
            {
                student.image = "user.png";
            }


            student.CId = Convert.ToInt16(classNum);
            student.name = name;
            student.exOccupation = oldOccupation;
            student.futureOccupation = targetOccupation;
            if (presence == "0")
            {
                student.presence = EnumList.presenceType.結訓;
            }


            else if (presence == "1")
            {
                student.presence = EnumList.presenceType.陪訓中;
            }

            else
            {
                student.presence = EnumList.presenceType.退訓;
            }

            ViewBag.Class = db.Class.Max(x => x.Session);

            db.Student.Add(student);
            db.SaveChanges();
            ViewBag.close ="true";
            return View();

        }

        // GET: Areas/Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.Class = db.Class.Max(x => x.Session);
            return View(student);
        }

        // POST: Areas/Students/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,CId,exOccupation,futureOccupation,presence")] Student student, HttpPostedFileBase upfile,string hiddenImage)
        {
            if (ModelState.IsValid)
            {
                if (upfile != null)
                {
                    if (upfile.ContentType.IndexOf("image", System.StringComparison.Ordinal) == -1)
                    {

                        return Content("檔案型態錯誤");
                    }
                    //取得副檔名
                    string extension = upfile.FileName.Split('.')[upfile.FileName.Split('.').Length - 1];
                    //新檔案名稱
                    string fileName = String.Format("{0}-{1:yyyyMMddhhmmsss}.{2}", student.name, DateTime.Now, extension);
                    string savedName = Path.Combine(Server.MapPath("/Areas/Areas/orid_admin/assets/img/user"), fileName);
                    upfile.SaveAs(savedName);



                    student.image = fileName;




                }
                else
                {
                    student.image = hiddenImage;
                }





                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Areas/Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Areas/Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Student.Find(id);
            db.Student.Remove(student);
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
