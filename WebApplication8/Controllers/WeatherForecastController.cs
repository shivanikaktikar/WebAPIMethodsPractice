using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPIPracticeImplementation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public static List<string> data = new List<string>()
        {
            "C#", "C++", "MVC", "ASP.NET", "JAVA" };


        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return data.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return data[id];
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            data.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            data[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            data.RemoveAt(id);
        }



      /*  public List<Book> books = new List<Book>()
         {
             new Book{Id = 1, Title ="ABC"},
             new Book{Id = 2, Title ="XYZ"},
             new Book{Id = 3, Title ="PQR"}
         };

         [HttpGet]
         public ActionResult<IEnumerable<Book>> GetBooks()
         {
             return books.ToList();
         }

         [HttpGet("{id}")]
         public IEnumerable<Book> GetBook(int id)
         {
            return books.FirstOrDefault(x => x.Id == id);
            return books[id];
         }

       [HttpPost]
         public void Post([FromBody] Book book)
         {
            books.Add(book);

         }
     }*/

 /*    public class Book
     {
         public int Id { get; set; }
         public string Title { get; set; }


     }*/
   }
}
