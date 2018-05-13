
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KsiazkaOnline.ViewModels;
using KsiazkaKucharska.Controllers;
using KsiazkaOnline.Models;

namespace AplikacjaWebowa.Controllers
{
    public class ReviewsController : Controller
    {


        private ApplicationDbContext _context;

        public ReviewsController()
        {
            _context = new ApplicationDbContext();
        }


        [HttpPost]
        public ActionResult Save(RecipeWithReview recipeWithReview)
        {
            if (!ModelState.IsValid)
            {
                //return Content("");
            }
            var id = RecipesController.tempModel.recipe.ID;

            // recipeWithReview.review.ReviewId = recipeWithReview.recipe.ID;
            
            recipeWithReview.review.SetId(id);
            recipeWithReview.review.PublishDate = DateTime.Now;
            recipeWithReview.review.SetEmail(User.Identity.Name);
            _context.Reviews.Add(recipeWithReview.review);
            _context.SaveChanges();


            var model = new RecipeWithReview { recipe = _context.Recipes.SingleOrDefault(r => r.ID == id), reviews = _context.Reviews.Where(r => r.RecipeId == id).ToList(), types = _context.RecipesTypes.ToList() };
            

            // return RedirectToAction("List", "Recipes");
            //return Content("Pomyślne logowanie");
            return RedirectToAction("Details",
            "Recipes", new { id = id });
            // RedirectToAction("actionName", "controllerName", new {/* routeValues, for example: */ id = 5 });


        }




    }
}