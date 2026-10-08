using Microsoft.AspNetCore.Mvc.Rendering;
using Mission.Models;

namespace Mission.ViewModels
{
    public class Produit_VM
    {
        public Produit Produit { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }

        public DateTime DateCreation { get; set; }

        public decimal PrixVente { get; set; }

        public int CategorieId
        {
            get; set;
        }
        public IEnumerable<SelectListItem> CategorieList { get; set; }


    }
}
