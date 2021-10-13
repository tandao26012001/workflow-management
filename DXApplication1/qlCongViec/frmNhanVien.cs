using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace qlCongViec
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        CNhanVien nv = new CNhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
            gcNV.DataSource = nv.selectNV();
        }
        void xoadl()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtMaPB.Text = "";
            txtChucVu.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtLuongCB.Text = "";
        }
        private void sbtThem_Click(object sender, EventArgs e)
        {
            nv.InsertNV(txtMaNV.Text, txtTenNV.Text, txtMaPB.Text, txtChucVu.Text, txtDiaChi.Text, txtDienThoai.Text, txtLuongCB.Text);
            MessageBox.Show(" Đã Thêm ", "Thông Báo");
            xoadl();
            gcNV.DataSource= nv.selectNV();
        }

        private void gvNV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaNV.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "MANV").ToString();
            txtTenNV.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "TENNV").ToString();
            txtMaPB.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "MAPB").ToString();
            txtChucVu.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "CHUCVU").ToString();
            txtDiaChi.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "DIACHI").ToString();
            txtDienThoai.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "DIENTHOAI").ToString();
            txtLuongCB.Text = gvNV.GetRowCellValue(e.FocusedRowHandle, "LUONGCB").ToString();
        }

        private void sbtXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                nv.DeleteNV(gvNV.GetRowCellValue(gvNV.FocusedRowHandle,"MANV").ToString());
                MessageBox.Show("Xoá Thành Công", "Thông Báo");
                gcNV.DataSource = nv.selectNV();
            }
        }
    }
}