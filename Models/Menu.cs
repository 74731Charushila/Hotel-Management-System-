using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        
        public string MenuName { get; set; }
       
        public string Menu_Type { get; set; }
      
        public string Menu_Description { get; set; }
       
        public string Menu_Price { get; set; }
    }
}
