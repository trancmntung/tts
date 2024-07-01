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
    public class HoSoUngVienRepository : IHoSoUngVienRepository
    {
        #region ===[ Private Members ]=============================================================

        private readonly IConfiguration configuration;

        #endregion

        #region ===[ Constructor ]=================================================================

        public HoSoUngVienRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        #region ===[ IHoSoUngVienRepository Methods ]==================================================

        public async Task<IReadOnlyList<HoSoUngVien>> GetAllAsync()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<HoSoUngVien>(UngVienQueries.AllUngVien);
                return result.ToList();
            }
        }

        public async Task<HoSoUngVien> GetByIdAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<HoSoUngVien>(UngVienQueries.UngVienById, new { UngVienID = id });
                return result;
            }
        }

        public async Task<string> AddAsync(HoSoUngVien entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(UngVienQueries.AddUngVien, entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateAsync(HoSoUngVien entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(UngVienQueries.UpdateUngVien, entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteAsync(long id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(UngVienQueries.DeleteUngVien, new { HoSoUngVienId = id });
                return result.ToString();
            }
        }

        #endregion
    }
}
