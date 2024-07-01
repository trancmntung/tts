using System;
using System.Collections.Generic;
using System.Data;
using MyProject.infrastructure;
using MyProject.Core.Entities;
using MyProject.Application.Interfaces;
using System.Data.SqlClient;
using MyProject.sql.Queries;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;


namespace MyProject.infrastructure.Repository
{
    public class QuocGiaRepository : IQuocGiaRepository
    {

        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public QuocGiaRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region ===[ IQuocGiaRepository Methods ]==================================================
        public async Task<IReadOnlyList<QuocGia>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<QuocGia>(QuocGiaQueries.AllQuocGia);
                return result.ToList();
            }
        }

        public async Task<QuocGia> GetByIdAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<QuocGia>(QuocGiaQueries.QuocGiaById, new { QuocGiaId = id });
                return result;
            }
        }

        public async Task<string> AddAsync(QuocGia entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(QuocGiaQueries.AddQuocGia, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(QuocGia entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(QuocGiaQueries.UpdateQuocGia, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(QuocGiaQueries.DeleteQuocGia, new { QuocGiaId = id });
                return result.ToString();
            }
        }

    }
    #endregion

}

