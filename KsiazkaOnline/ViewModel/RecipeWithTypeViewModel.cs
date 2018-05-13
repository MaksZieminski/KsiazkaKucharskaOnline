using KsiazkaOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KsiazkaOnline.ViewModels
{
    public class RecipeWithTypeViewModel
    {
        public List<Recipe> recipes = new List<Recipe>();
        public List<RecipeType> types = new List<RecipeType>();
        public string searchPhrase { get; set; }
    }
}