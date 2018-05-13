using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplikacjaWebowa.Models;
using KsiazkaOnline.Models;

namespace KsiazkaOnline.ViewModels
{
    public class RecipeWithReview
    {

        public Recipe recipe = new Recipe();
        public List<RecipeType> types = new List<RecipeType>();
        public List<Review> reviews = new List<Review>();
        public Review review { get; set; }

    }
}