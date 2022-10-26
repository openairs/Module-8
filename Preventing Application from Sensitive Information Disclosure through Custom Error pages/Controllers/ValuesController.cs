using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandlingApp.Controllers
{
    public class ValuesController : Controller
    {
        // GET: api/values
        public IEnumerable<string> Get()
        {
            throw new Exception("Parameter value cannot be null");
            return new string[] {"value1", "value2"};
        }

        // GET: ValuesController/Details/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: ValuesController/Create
        
        public void Post([FromBody]string value)
        {
            
        }

        // POST: ValuesController/Edit/5
        
        public void Put(int id, [FromBody]string value)
        {
           
        }

        // DELETE: ValuesController/Delete/5
        public void Delete(int id)
        {
            
        }

        // POST: ValuesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
