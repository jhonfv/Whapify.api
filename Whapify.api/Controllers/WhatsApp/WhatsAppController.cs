using Microsoft.AspNetCore.Mvc;
using Whapify.api.Utilitarios.Herramientas;
using Whapify.api.Utilitarios.Modelos;

namespace Whapify.api.Controllers.WhatsApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhatsAppController : ControllerBase
    {
        readonly IValidadores validadores;

        public WhatsAppController(IValidadores validadores)
        {
            this.validadores = validadores;
        }

        [HttpGet("checkNumber")]
        public IActionResult checkNumber(string number)
        {
            
            if (validadores.IsNumeric(number))
            {
                var respuesta = new Respuesta<String>($"The number {number} have account").get();
                return Ok(respuesta);
            }
            else
            {
                var respuesta = new Respuesta<String>($"The number {number} is not valid format", 403, true).get();
                return Ok(respuesta);
            }
        }
    }
}
