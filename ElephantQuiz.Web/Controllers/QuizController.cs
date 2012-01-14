using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElephantQuiz.Web.Extensions;
using ElephantQuiz.Web.Infrastructure.AutoMapper;
using ElephantQuiz.Web.Models;
using ElephantQuiz.Web.ViewModels;
using Ninject;
using Raven.Client;

namespace ElephantQuiz.Web.Controllers
{
    public class QuizController : Controller
    {
        [Inject]
        public IDocumentSession RavenSession { get; set; }
        //
        // GET: /Quiz/

        public ActionResult Index()
        {
            return View(new QuizListViewModel());
        }

        //
        // GET: /Quiz/Details/5

        public ActionResult Details(int id)
        {
            var quiz = RavenSession
                .Load<Quiz>(id);

            if (quiz == null)
                return HttpNotFound();

            return View("Details", new DisplayQuizViewModel
                                       {
                                           Title = quiz.Title,
                                       } );
        }

        //
        // GET: /Quiz/Add

        public ActionResult Add()
        {
            return View("Edit", new EditQuizViewModel());
        } 

        //
        // POST: /Quiz/Add

        [HttpPost]
        public ActionResult Add(EditQuizViewModel input)
        {
            if (!ModelState.IsValid)
                return View("Edit", input);

            var quiz = input.MapTo<Quiz>();

            RavenSession.Store(quiz);

            return RedirectToAction("Details", new { id = quiz.Id.ToIntId()});
        }
        
        //
        // GET: /Quiz/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(new EditQuizViewModel());
        }

        //
        // POST: /Quiz/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, EditQuizViewModel input)
        {
            if (!ModelState.IsValid)
                return View("Edit", input);

            return RedirectToAction("Details", new { id = input.Id });
        }
    }
}
