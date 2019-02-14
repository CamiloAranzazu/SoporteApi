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
    public class AuditoriaComponentesController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                List<DTOsop_auditoriacomponentes> ListaAuditoriaComponentes = new List<DTOsop_auditoriacomponentes>();
                DA_sop_auditoriacomponentes da = new DA_sop_auditoriacomponentes();

                ListaAuditoriaComponentes = da.ObtenerAuditoriaComponentes();

                return Ok(ListaAuditoriaComponentes);
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
           

        }
    }
}
