using System.ComponentModel.DataAnnotations;

namespace Payment_Gateway.Models
{
    public class Receiver
    {
        public int Id { get; set; }
        public string? Rec_Name { get; set; }
        public int Rec_ID_NO { get; set; }
        public int Rec_Phone { get; set; }
        public string? Rec_Dst_Acc { get; set; }



    }
}
