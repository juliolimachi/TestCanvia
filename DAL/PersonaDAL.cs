using ET;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class PersonaDAL
    {

        private readonly string CS = ConfigurationManager.ConnectionStrings["TestCanviaContext"].ConnectionString;


        public List<Persona> Listar()
        {
            var personas = new List<Persona>();

            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("GetPersonas", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Persona
                            var persona = new Persona
                            {
                                IdPersona = Convert.ToInt32(dr["IdPersona"]),
                                NroDocumento = dr["NroDocumento"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Domicilio = dr["Domicilio"].ToString(),
                            };

                            // Agregamos la persona a la lista genreica
                            personas.Add(persona);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return personas;
        }


        public bool Registrar(Persona persona)
        {
            bool respuesta = false;

            try
            {
                using (var con = new SqlConnection(CS))
                {
                    con.Open();

                    var cmd = new SqlCommand("MasterInsertPersona", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NroDocumento", persona.NroDocumento);
                    cmd.Parameters.AddWithValue("@Nombres", persona.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
                    cmd.Parameters.AddWithValue("@Domicilio", persona.Domicilio);
                    cmd.Parameters.AddWithValue("@StatementType", "Insert");

                    cmd.ExecuteNonQuery();

                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return respuesta;
        }




    }
}
