using System.ComponentModel.DataAnnotations;

namespace Payment_Gateway.Models
{
    public class Transaction
    {
        public int Id { get; set; }
       
        public int Amount { get; set; }
       
        public string? Reference { get; set; }
    }
}
