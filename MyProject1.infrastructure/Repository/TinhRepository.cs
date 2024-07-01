using Microsoft.Extensions.Configuration;
using MyProject.Core.Entities;
using MyProject.sql.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace MyProject.infrastructure.Repository
{
    internal class TinhRepository
    {


        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public TinhRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region ===[ ITinhRepository Methods ]==================================================
        public async Task<IReadOnlyList<Tinh>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Tinh>(TinhQueries.AllTinh);
                return result.ToList();
            }
        }

        public async Task<Tinh> GetByIdAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Tinh>(TinhQueries.TinhById, new { TinhId = id });
                return result;
            }
        }

        public async Task<string> AddAsync(Tinh entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(TinhQueries.AddTinh, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(Tinh entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(TinhQueries.UpdateTinh, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(TinhQueries.DeleteTinh, new { TinhId = id });
                return result.ToString();
            }
        }
    }
    #endregion
}
