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
    public class LoginController : Controller
    {
        //Declaração do serviço usado
        private ILoginBusiness _loginBusiness;

        /* Injeção de uma instancia de IBookBusiness ao criar
        uma instancia de BookController */
        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }        

        //Mapeia as requisições POST para http://localhost:{porta}/api/books/v1/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody]User user)
        {
            if (user == null)
                return BadRequest();

            return _loginBusiness.FindByIdLogin(user);
        }       
    }
}
