using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MyProject.sql.Queries
{
    public static class TinhQueries
    {
        public static string AllTinh => "SELECT * FROM [Tinh] (NOLOCK)";

        public static string TinhById => "SELECT * FROM [Tinh] (NOLOCK) WHERE [TinhId] = @TinhId";

        public static string AddTinh =>
        @"INSERT INTO [Tinh] ([TenTinh], [QuocGiaId], [Note]) 
          VALUES (@TenTinh, @QuocGiaId, @Note)";

        public static string UpdateTinh =>
            @"UPDATE [Tinh] 
            SET [TenTinh] = @TenTinh, 
                [QuocGiaId] = @QuocGiaId, 
                [Note] = @Note
            WHERE [TinhId] = @TinhId";

        public static string DeleteTinh => "DELETE FROM [Tinh] WHERE [TinhId] = @TinhId";
    }
}
