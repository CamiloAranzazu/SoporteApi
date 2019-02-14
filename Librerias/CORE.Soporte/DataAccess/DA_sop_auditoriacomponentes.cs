using CORE.Soporte.DTO;
using CORE.Soporte.Infraestructura;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Soporte.DataAccess
{
    public class DA_sop_auditoriacomponentes
    {
        public List<DTOsop_auditoriacomponentes> ObtenerAuditoriaComponentes()
        {
            BaseDatos db = new BaseDatos();
            string variableCadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();

            DataSet ds = new DataSet();
            List<DTOsop_auditoriacomponentes> ListaAuditoriaComponentes = new List<DTOsop_auditoriacomponentes>();

            try
            {
                ds = BaseDatos.ExecuteSql(variableCadenaConexion , "[SOPORTE].[CAP_AuditoriaComponentes]", true);

                if(ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            DTOsop_auditoriacomponentes dto = new DTOsop_auditoriacomponentes();
                            dto.id = Int32.Parse(dr["id"].ToString());
                            dto.Opcion = dr["Opcion"].ToString();
                            dto.Proyecto = dr["Proyecto"].ToString();
                            dto.Ruta = dr["Ruta"].ToString();
                            dto.EsquemaComponente = dr["EsquemaComponente"].ToString();
                            dto.NombreComponente = dr["NombreComponente"].ToString();
                            dto.TipoComponente = dr["TipoComponente"].ToString();
                            dto.Observacion = dr["Observacion"].ToString();
                            ListaAuditoriaComponentes.Add(dto);
                        }
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return ListaAuditoriaComponentes;

        }
    }
}
