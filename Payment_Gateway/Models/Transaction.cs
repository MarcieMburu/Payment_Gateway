using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Payment_Gateway.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
        public int Amount { get; set; }
        public string? Reference { get; set; }

        
    }

}
