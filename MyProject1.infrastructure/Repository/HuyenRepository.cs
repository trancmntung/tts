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
    public class HuyenRepository : IHuyenRepository
    {
        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public HuyenRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region ===[ IHuyenRepository Methods ]==================================================

        public async Task<IReadOnlyList<Huyen>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Huyen>(HuyenQueries.AllHuyen);
                return result.ToList();
            }
        }

        public async Task<Huyen> GetByIdAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Huyen>(HuyenQueries.HuyenById, new { HuyenId = id });
                return result;
            }
        }

        public async Task<string> AddAsync(Huyen entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(HuyenQueries.AddHuyen, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(Huyen entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(HuyenQueries.UpdateHuyen, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(HuyenQueries.DeleteHuyen, new { HuyenId = id });
                return result.ToString();
            }
        }

        #endregion
    }
}
