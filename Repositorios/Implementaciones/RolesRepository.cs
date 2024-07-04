using DevProjectLocal.Models;
using DevProjectLocal.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DevProjectLocal.Repositorios.Implementaciones
{
    public class RolesRepository : IGenericRepository<ad_roles>
    {
        private readonly string _connectionString;

        public RolesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<ad_roles>> Lista(string estatus)
        {
            List<ad_roles> _lista = new List<ad_roles>();

            using (var conexion = new SqlConnection(_connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ListarAdRoles", conexion);
                cmd.Parameters.AddWithValue("estatus", estatus);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        _lista.Add(new ad_roles
                        {
                            codigoRol = Convert.ToInt32(dr["codigoRol"]),
                            nombreRol = dr["nombreRol"].ToString(),
                            descripcionRol = dr["descripcionRol"].ToString(),
                            fechaCrea = Convert.ToDateTime(dr["fechaCrea"].ToString()),
                            estatus = dr["estatus"].ToString(),
                        });
                    }
                }
            }

            return _lista;
        }

        public async Task<bool> Guardar(ad_roles modelo)
        {
            try
            {
                using (var conexion = new SqlConnection(_connectionString))
                {
                    
                    SqlCommand cmd = new SqlCommand("InsertarAdRoles", conexion);
                    

                    cmd.Parameters.AddWithValue("@nombreRol", modelo.nombreRol);
                    cmd.Parameters.AddWithValue("@descripcionRol", modelo.descripcionRol);
                    cmd.Parameters.AddWithValue("@fechaCrea", Convert.ToDateTime(modelo.fechaCrea).ToString("dd-MM-yyyy"));
                    

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    int filasAfectadas = await cmd.ExecuteNonQueryAsync();

                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex) {
                return false;
            }


        }

        public async Task<bool> Editar(ad_roles modelo)
        {
            try
            {
                using (var conexion = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("EditarAdRoles", conexion);

                    
                    cmd.Parameters.AddWithValue("@codigoRol", Convert.ToInt32(modelo.codigoRol));
                    cmd.Parameters.AddWithValue("@nombreRol", modelo.nombreRol);
                    cmd.Parameters.AddWithValue("@descripcionRol", modelo.descripcionRol);
                    cmd.Parameters.AddWithValue("@fechaCrea", Convert.ToDateTime(modelo.fechaCrea).ToString("dd-MM-yyyy"));
                    

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    int filasAfectadas = await cmd.ExecuteNonQueryAsync();

                    return filasAfectadas > 0; 
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public async Task<bool> Eliminar(int codigo)
        {
            try
            {
                using (var conexion = new SqlConnection(_connectionString))
                {
                    
                    SqlCommand cmd = new SqlCommand("EliminarAdRoles", conexion);
                    cmd.Parameters.AddWithValue("codigoRol", codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    int filas_afectadas = await cmd.ExecuteNonQueryAsync();

                    return filas_afectadas > 0;

                }
            }
            catch (Exception ex)
            { 
                return false;
            }
        }
    }
}