using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestWithAspNET.Business;
using RestWithAspNET.Data.VO;
using RestWithAspNET.Model;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace RestWithAspNET.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class FileController : Controller
    {
        //Declaração do serviço usado
        private IFileBusiness _fileBusiness;

        /* Injeção de uma instancia de IBookBusiness ao criar
        uma instancia de BookController */
        public FileController(IFileBusiness fileBusiness)
        {
            _fileBusiness = fileBusiness;
        }        

        //Mapeia as requisições POST para http://localhost:{porta}/api/books/v1/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        [HttpGet]
        [SwaggerResponse((200), Type = typeof(byte[]))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        public IActionResult GetPDFFile()
        {
            byte[] buffer = _fileBusiness.GetPDFFile();
            if (buffer != null)
            {
                HttpContext.Response.ContentType = "application/pdf";
                HttpContext.Response.Headers.Add("content-length", buffer.Length.ToString());
                HttpContext.Response.Body.Write(buffer,0,buffer.Length);
            }
            return new ContentResult();
        }       
    }
}
