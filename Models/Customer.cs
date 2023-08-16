using System.Security.Principal;
using WebApi.Data;

namespace WebApi.Models
{
    public class Customer
    {
        
        //nesne oluşturuldu. Parametreleri veridk. kullanılacak tabloya göre
        public string CustomerID { get; set; } 
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
