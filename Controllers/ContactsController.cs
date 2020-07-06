using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Phone.DAL;

namespace Phone.Controllers
{
    public class ContactsController : Controller
    {
        private PhoneDb db = new PhoneDb();

        // GET: Contacts
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            List<SelectListItem> countryList = new List<SelectListItem>();
            countryList.Add(new SelectListItem {Text = "India", Value = "India" });
            countryList.Add(new SelectListItem { Text = "Japan", Value = "Japan" });
            countryList.Add(new SelectListItem { Text = "USA", Value = "USA" });
            ViewData["country"] = countryList;
            return View();
        }

        public JsonResult GetStates(string id)
        {
            List<SelectListItem> states = new List<SelectListItem>();
            switch(id)
            {
                case "India":
                    states.Add(new SelectListItem { Text = "Select", Value = "0" });
                    states.Add(new SelectListItem { Text = "Telengana", Value = "Telengana" });
                    states.Add(new SelectListItem { Text = "AndhraPradesh", Value = "AndhraPradesh" });
                    states.Add(new SelectListItem { Text = "TamilNadu", Value = "TamilNadu" });
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
            return Json(new SelectList(states, "Value", "Text"));
        }
        public JsonResult GetCity(string id)
        {
            List<SelectListItem> cities = new List<SelectListItem>();
            switch (id)
            {
                case "Telengana":
                    cities.Add(new SelectListItem { Text = "Select", Value = "0" });
                    cities.Add(new SelectListItem { Text = "Hyderabad", Value = "Hyderabad" });
                    cities.Add(new SelectListItem { Text = "Karimnagar", Value = "Karimnagar" });
                    cities.Add(new SelectListItem { Text = "Wrangal", Value = "Wrangal" });
                    break;
                case "AndhraPradesh":
                    cities.Add(new SelectListItem { Text = "Select", Value = "0" });
                    cities.Add(new SelectListItem { Text = "Guntur", Value = "Hyderabad" });
                    cities.Add(new SelectListItem { Text = "Ongole", Value = "Karimnagar" });
                    cities.Add(new SelectListItem { Text = "Vizag", Value = "Wrangal" });
                    break;


            }
            return Json(new SelectList(cities, "Value", "Text"));
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address_line_1,Address_line_2,Country,State,City,Pincode,Phonenumber")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address_line_1,Address_line_2,Country,State,City,Pincode,Phonenumber")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
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
