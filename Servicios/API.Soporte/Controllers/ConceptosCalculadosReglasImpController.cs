using CORE.Soporte.DataAccess;
using CORE.Soporte.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Soporte.Controllers
{
    public class ConceptosCalculadosReglasImpController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string NitBeneficiario, string NitCliente)
        {
            try
            {
                //Instancia de las clases 
                List<DTOconceptosReglasImp> ListaConceptosReglasImp = new List<DTOconceptosReglasImp>();
                DA_ConceptosCalculadosReglasImp DA_ConceptosCalculadosReglasImp = new DA_ConceptosCalculadosReglasImp();

                ListaConceptosReglasImp = DA_ConceptosCalculadosReglasImp.ObtenerConceptosCalculadosReglasImp(NitBeneficiario, NitCliente);
                return Ok(ListaConceptosReglasImp);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
