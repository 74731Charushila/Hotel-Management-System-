using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class Room
    {

        [Key]
        public int RoomId { get; set; }
      
        public string RoomName { get; set; }
       
        public string RoomType { get; set; }
        
        public string RoomDescription { get; set; }
        
        public string RoomPrice { get; set; }

    }
}
