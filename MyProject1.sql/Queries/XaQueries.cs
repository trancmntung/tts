using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MyProject.sql.Queries
{
    public static class XaQueries
    {
        public static string AllXa => "SELECT * FROM [Xa] (NOLOCK)";

        public static string XaById => "SELECT * FROM [Xa] (NOLOCK) WHERE [XaId] = @XaId";

        public static string AddXa =>
        @"INSERT INTO [Xa] ([TenXa], [HuyenId], [Note]) 
          VALUES (@TenXa, @HuyenId, @Note)";

        public static string UpdateXa =>
            @"UPDATE [Xa] 
            SET [TenXa] = @TenXa, 
                [HuyenId] = @HuyenId, 
                [Note] = @Note
            WHERE [XaId] = @XaId";

        public static string DeleteXa => "DELETE FROM [Xa] WHERE [XaId] = @XaId";
    }
}
