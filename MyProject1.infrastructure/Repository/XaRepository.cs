using System;
using System.Collections.Generic;
using System.Data;
using MyProject.infrastructure;
using MyProject.Core.Entities;
using MyProject.Application.Interfaces;
using System.Data.SqlClient;
using MyProject.sql.Queries;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.infrastructure.Repository
{
    public class XaRepository : IXaRepository
    {
        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public XaRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region ===[ IXaRepository Methods ]==================================================

        public async Task<IReadOnlyList<Xa>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Xa>(XaQueries.AllXa);
                return result.ToList();
            }
        }

        public async Task<Xa> GetByIdAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Xa>(XaQueries.XaById, new { XaId = id });
                return result;
            }
        }

        public async Task<string> AddAsync(Xa entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(XaQueries.AddXa, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(Xa entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(XaQueries.UpdateXa, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(XaQueries.DeleteXa, new { XaId = id });
                return result.ToString();
            }
        }

        #endregion
    }
}
