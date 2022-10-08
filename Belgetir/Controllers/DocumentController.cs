using AutoMapper;
using Belgetir.BLL;
using Belgetir.Model;
using Belgetir.Models.Requests;
using Belgetir.Models.Responses;
using Microsoft.AspNetCore.Mvc;

// CREATE, STORE, RETRIEVE
namespace Belgetir.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {

        DocumentLogic _documentLogic;

        public DocumentController(IMapper mapper)
        {
            _documentLogic = new DocumentLogic(mapper);
        }

        // GET: api/<DocumentController>
        /*[HttpGet]
        public IEnumerable<IDocument> Get()
        {
            var documents = _documentLogic.RetrieveDocumentList();
            return documents;
        }*/

        /*
        // GET api/<DocumentController>/Get/id-typeId
        [HttpGet("Get")]
        public IDocument Get([FromQuery] int id, [FromQuery] int typeId)
        {            
            var document = _documentLogic.RetrieveDocument(id, typeId);
            return document;
        } */

        // POST api/<DocumentController>/Store/
        [HttpPost]
        public StoreResponse Store([FromBody] StoreRequest request)
        {
            StoreResponse response = _documentLogic.StoreDocument(request);
            return response;
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
