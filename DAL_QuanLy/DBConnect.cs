using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=OBITOROSSANDER;Initial Catalog=Quan_Ly_Ban_Hang;Persist Security Info=True;User ID=sa;Password=123456789");
    }
}