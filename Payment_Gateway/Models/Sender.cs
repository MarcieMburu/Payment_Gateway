using System.ComponentModel.DataAnnotations;

namespace Payment_Gateway.Models
{
    public class Sender
    {
        public int Id { get; set; }
        public string? Sen_Name { get; set; }
        public int Sen_ID_NO { get; set; }
        public int Sen_Phone { get; set; }
        public string? Sen_Src_Acc { get; set; }
    }
}
