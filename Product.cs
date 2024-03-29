using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Product{

        public Product(int id, string name, string description, decimal price) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
   
        }
                public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Price { get; set; }

        public decimal IGV => Price * 0.18m; // 18% del precio
    }
}