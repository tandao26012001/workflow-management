using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlCongViec
{
    class CNhanVien
    {
        CDatabase db;
        public CNhanVien()
        {
            db = new CDatabase();
        }
        public DataTable selectNV()
        {
            string sql = "EXEC NV";
            return db.Execute(sql);
        }
        public void UdateNV(string manv, string tennv, string mapb, string chucvu, string diachi, string dienthoai,string luongcb)
        {
            string sql = string.Format("update NHANVIEN" +
                "set MANV='{0}',TENNV=N'{1},MAPB='{2}',CHUCVU=N'{3},DIACHI=N'{4},DIENTHOAI='{5},LUONGCB='{6}",manv,tennv,mapb,chucvu,diachi,dienthoai,luongcb);
            db.ExecuteNonQuery(sql);
        }
        public void InsertNV(string manv,string tennv, string mapb, string chucvu, string diachi, string dienthoai, string luongcb)
        {
            string sql = string.Format("insert into NHANVIEN values('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}')", manv, tennv, mapb, chucvu, diachi, dienthoai, luongcb);
            db.ExecuteNonQuery(sql);
        }
        public void DeleteNV(string ID)
        {
            string sql = ("exec xoa_manv "+ID);
            db.ExecuteNonQuery(sql);
        }
    }
}
