using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class CustomersController : ControllerBase
    {
        NorthwindDbContext _context;
        public CustomersController(NorthwindDbContext context) // constructor yapısı kullanıldı
        {
                _context=context; //ihtiyaç duyulan paramtreleri aldık
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() //alıp ekrana basıyor
        { //IactionResult bir interface'dir.
            return Ok(_context.Customers.ToList()); // tablodaki verileri listeledi
        }
        [HttpPost("Add")]
        public IActionResult Add(Customer customer) //ekleme işlemini yapıyor
        {
            _context.Add(customer);
            _context.SaveChanges();
            return Ok("success");
        }
        [HttpPost("Delete")]
        public IActionResult Delete(string customerId) //silme işlemini yapar
        {
            var customer= _context.Customers.FirstOrDefault(p=>p.CustomerID==customerId);// p değikeni olan ID customer nesnesinin ıd ile eşleşirse
            if (customer!=null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return Ok("success"); 
            }

            return Ok("Bu id ile customer bulunamadı");
        }
        [HttpPost("Update")]
        public IActionResult Update(Customer customer) //PARAMETRELERİN OLDUĞU BİR YAPI YOLLUYOR
        {


            
            if (customer != null)
            {

                _context.Update(customer);
                _context.SaveChanges();
                return Ok("success");
            }

            return Ok("Bu id ile customer bulunamadı");

        }
    }
   
}
