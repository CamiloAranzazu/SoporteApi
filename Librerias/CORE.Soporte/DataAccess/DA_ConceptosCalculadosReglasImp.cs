using CORE.Soporte.DTO;
using CORE.Soporte.Infraestructura;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Soporte.DataAccess
{
    public class DA_ConceptosCalculadosReglasImp
    {
        public List<DTOconceptosReglasImp> ObtenerConceptosCalculadosReglasImp(string NitBeneficiario, string NitCliente)
        {
            BaseDatos db = new BaseDatos();
            string variableCadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();

            DataSet ds = new DataSet();
            List<DTOconceptosReglasImp> ListaConceptos = new List<DTOconceptosReglasImp>();

            try
            {
                ds = BaseDatos.ExecuteSql(variableCadenaConexion,
                                          "[ADM].[CAP_conceptosCalculadosReglasImpuestos]",
                                           true,
                                           new SqlParameter[]{
                                           new SqlParameter("@TerceroBeneficiario", NitBeneficiario),
                                           new SqlParameter("@TerceroCliente",NitCliente)
                                           });

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            DTOconceptosReglasImp dto = new DTOconceptosReglasImp();
                            dto.tipoConceptoCalculado = dr["tipoConceptoCalculado"].ToString();
                            dto.descripcion = dr["descripcion"].ToString();
                            dto.tipoPersona = dr["tipoPersona"].ToString();
                            ListaConceptos.Add(dto);
                        }

                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            
            return ListaConceptos;
        }
    }
}
