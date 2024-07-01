using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MyProject.sql.Queries
{
    public static class UngVienQueries
    {
        public static string AllUngVien => "SELECT * FROM [UngVien] (NOLOCK)";

        public static string UngVienById => "SELECT * FROM [UngVien] (NOLOCK) WHERE [UngVienId] = @UngVienId";

        public static string AddUngVien =>
        @"INSERT INTO [UngVien] ([Ten], [NamSinh]) 
          VALUES (@Ten, @NamSinh)";

        public static string UpdateUngVien =>
            @"UPDATE [UngVien] 
            SET [Ten] = @Ten, 
                [NamSinh] = @NamSinh
            WHERE [UngVienId] = @UngVienId";

        public static string DeleteUngVien => "DELETE FROM [UngVien] WHERE [UngVienId] = @UngVienId";
    }
}
