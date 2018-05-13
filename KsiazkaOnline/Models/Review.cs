using KsiazkaOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplikacjaWebowa.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        public string Text { get; set; }
        public DateTime? PublishDate { get; set; }

        public int? RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }

        public string Email { get; set; }

        public void SetEmail(string _Email) {

            Email = _Email;
        }

        public void SetId(int id)
        {
            RecipeId = id;
        }
    }


}