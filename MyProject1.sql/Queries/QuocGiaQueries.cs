using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MyProject.sql.Queries
{
    public static class QuocGiaQueries
    {
        public static string AllQuocGia => "SELECT * FROM [QuocGia] (NOLOCK)";

        public static string QuocGiaById => "SELECT * FROM [QuocGia] (NOLOCK) WHERE [QuocGiaId] = @QuocGiaId";

        public static string AddQuocGia =>
        @"INSERT INTO [QuocGia] ( [TenQuocGia],[QuocGiaID],[Code],[Note]) 
          VALUES (@TenQuocGia,@QuocGiaID,@Code, @Note)";

        public static string UpdateQuocGia =>
            @"UPDATE [QuocGia] 
            SET [TenQuocGia] = @TenQuocGia, 
                [Note] = @Note,
                [QuocGiaID]=@QuocGiaID,
                [Code]= @Code
            WHERE [QuocGiaId] = @QuocGiaId";

        public static string DeleteQuocGia => "DELETE FROM [QuocGia] WHERE [QuocGiaId] = @QuocGiaId";
    }
}
