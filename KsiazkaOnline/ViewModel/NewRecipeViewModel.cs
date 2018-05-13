using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KsiazkaOnline.Models;

namespace KsiazkaOnline.ViewModels
{
    public class NewRecipeViewModel
    {

        public Recipe recipe = new Recipe();
        public List<RecipeType> types = new List<RecipeType>();
        public string Title
        {
            get
            {
                if (recipe != null && recipe.ID != 0)
                    return "Zmień Przepis";

                return "Nowy przepis";
            }
        }
    }
}