using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MyProject.sql.Queries
{
    public static class HuyenQueries
    {
        public static string AllHuyen => "SELECT * FROM [Huyen] (NOLOCK)";

        public static string HuyenById => "SELECT * FROM [Huyen] (NOLOCK) WHERE [HuyenId] = @HuyenId";

        public static string AddHuyen =>
        @"INSERT INTO [Huyen] ([TenHuyen], [TinhId], [Note]) 
          VALUES (@TenHuyen, @TinhId, @Note)";

        public static string UpdateHuyen =>
            @"UPDATE [Huyen] 
            SET [TenHuyen] = @TenHuyen, 
                [TinhId] = @TinhId, 
                [Note] = @Note
            WHERE [HuyenId] = @HuyenId";

        public static string DeleteHuyen => "DELETE FROM [Huyen] WHERE [HuyenId] = @HuyenId";
    }
}
