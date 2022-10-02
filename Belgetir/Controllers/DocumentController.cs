using Belgetir.BLL;
using Belgetir.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Belgetir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {

        DocumentLogic _documentLogic;

        public DocumentController()
        {
            _documentLogic = new DocumentLogic();
        }

        // GET: api/<DocumentController>
        /*[HttpGet]
        public IEnumerable<IDocument> Get()
        {
            var documents = _documentLogic.RetrieveDocumentList();
            return documents;
        }*/

        // GET api/<DocumentController>/5
        [HttpGet("{id}/{typeId}")]
        public IDocument Get(int id, int typeId)
        {            
            var document = _documentLogic.RetrieveDocument(id, typeId);
            return document;
        }

        // POST api/<DocumentController>
        [HttpPost]
        public void Post([FromBody] IDocument value)
        {

        }

        // PUT api/<DocumentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] IDocument value)
        {
        }

        // DELETE api/<DocumentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
