using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyKhoHang.CT
{
    public partial class Frm_SanPhamDaXong : UserControl
    {
        public Frm_SanPhamDaXong()
        {
            InitializeComponent();
        }
        private string[] DS_PhanLoai = new string[] { "Hàng Mới Quốc Tế", "Hàng Cũ Quốc Tế", "Hàng Xách Tay", "Hàng Xách Tay Cũ" };
        DataAccess acc = new DataAccess();
        private int key = 0;
        public static string filepart = "";
        private string filename;
        private string MANCC;
        private string MADM;
        public void ConverttoString(DateTime dt)
        {

        }
        public void Disable()
        {
            tbx_tensp.Enabled = false; txb_madm.Enabled = false; txb_ncc.Enabled = false; txb_phanloai.Enabled = false; txb_serial.Enabled = false;
            txb_soluong.Enabled = false; txb_giasp.Enabled = false; button8.Enabled = false; txb_ghichu.Enabled = false;
            dtpicker_nsx.Enabled = false; dtpicker_hsd.Enabled = false;
        }
        public void Enable()
        {
            tbx_tensp.Enabled = true; txb_madm.Enabled = true; txb_ncc.Enabled = true; txb_phanloai.Enabled = true; txb_serial.Enabled = true;
            txb_soluong.Enabled = true; txb_giasp.Enabled = true; button8.Enabled = true; txb_ghichu.Enabled = true;
            dtpicker_nsx.Enabled = true; dtpicker_hsd.Enabled = true;
        }
        public void cleartext()
        {
            txb_giasp.Clear(); txb_madm.ResetText();
            txb_ghichu.Clear(); txb_ncc.ResetText(); txb_phanloai.Clear(); tbx_masp.Clear();
            tbx_tensp.Clear(); txb_serial.Clear(); txb_soluong.Value = 0; pictureBox_sanpham.Image = null; filepart = "";
        }
        public DataTable ThongTinNCC(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANCC FROM NHACUNGCAP WHERE TENNHACC LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MANCC = a["MANCC"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinDM(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MADANHMUC FROM DANHMUC WHERE TENDANHMUC LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MADM = a["MADANHMUC"].ToString().Trim();
            }
            return null;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            key = 1;
            tbx_masp.Enabled = true;
            Enable();
            tbx_tensp.Focus();
            btn_themmoi.Enabled = false ;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
           
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Enable();
            tbx_masp.Enabled = false;
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
           // btn_themmoi.Enabled = true;
            key = 2;
            dtpicker_nsx.Text = DateTime.Now.ToShortDateString();
            dtpicker_hsd.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            tbx_masp.Enabled = true;
            btn_themmoi.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            btn_themmoi.Enabled = true;
            // key = 3;
            if (dgv_SANPHAM.SelectedRows == null || tbx_masp.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm để xóa!", "Thông Báo");

            }
            //else
            //{
            //    DataTable dtctpn = new DataTable();
            //    dtctpn = acc.CheckSql("select * from CHITIETPHIEUNHAP where MASP ='" + tbx_masp.Text + "'");
            //    DataTable dtctpx = new DataTable();
            //    dtctpx = acc.CheckSql("select * from CHITIETPHIEUXUAT where MASP ='" + tbx_masp.Text + "'");
            //    if (dtctpn.Rows.Count > 0 || dtctpx.Rows.Count > 0)
            //    {
            //        if (MessageBox.Show("Sản phẩm này đang tồn tại ở bảng Chi Tiết Phiếu Nhập Xuất! Bạn chắc chắn muốn xóa!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            acc.CheckSql("DELETE CHITIETPHIEUNHAP WHERE MASP = '" + tbx_masp.Text + "'");
            //            acc.CheckSql("DELETE CHITIETPHIEUXUAT WHERE MASP = '" + tbx_masp.Text + "'");
            //            acc.XOA_SANPHAM(tbx_masp.Text);
            //            MessageBox.Show("Xóa thành công!", "Thông Báo!");

            //            SANPHAM_Load(sender, e);
            //            key = 0;
            //        }
            //    }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acc.XOA_SANPHAM(tbx_masp.Text);
                   Frm_SanPham_Load(sender, e);
                    dgv_SANPHAM.ClearSelection();
                    cleartext();
                    // label_thongbaoSP.Text = "Đã xóa thành công";
                    MessageBox.Show("Xóa thành công!", "Thông Báo");
                }
            }
            // }
        }

      

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "")
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm!", "thông Báo");
                txb_timkiem.Focus();
            }
            else
            {
                dgv_SANPHAM.DataSource = acc.Select_Data("SELECT Row_number() over(order by MASP) STT,* from SanPham1 WHERE (MASP like N'%" + txb_timkiem.Text + "%' OR TENSP like N'%" + txb_timkiem.Text + "%' OR TENNHACC like N'%" + txb_timkiem.Text + "%' OR  GIA like N'%" + txb_timkiem.Text + "%' OR TENDANHMUC like N'%" + txb_timkiem.Text + "%' OR SERIAL like N'%" + txb_timkiem.Text + "%' OR  PHANLOAI like N'%" + txb_timkiem.Text + "%' OR GHICHU like N'%" + txb_timkiem.Text + "%')");
                txb_timkiem.Clear();
                dgv_SANPHAM.ClearSelection();
                //groupBox_DSSP.Text = "Kết Quả Tìm Kiếm";

            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            PictureBox objpt = new PictureBox();
            ofdImages.Title = "Chọn File Ảnh!";
            ofdImages.InitialDirectory = @"Documents";//Thư mục mặc định khi mở
            ofdImages.Filter = "All files (*.*)|*.*";// Lọc ra những file cần hiển thị
            ofdImages.FilterIndex = 1;//chúng ta có All files là 1,jpg là 2
            ofdImages.RestoreDirectory = true;
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                string filenameX = ofdImages.FileName;
                pictureBox_sanpham.Image = Image.FromFile(ofdImages.FileName);
                filename = Path.GetFileName(ofdImages.FileName);
                pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
                filepart = Application.StartupPath + "\\Images\\" + filename;
                if (!File.Exists(filenameX)) return;

                if (File.Exists(filepart))
                {

                }

                else
                    try
                    {
                        File.Copy(filenameX, filepart);
                    }
                    catch
                    {
                        MessageBox.Show("Đã phát sinh lỗi trong việc chọn ảnh upload, vui lòng kiểm tra lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                filename = "";
                pictureBox_sanpham.Image = null;
            }
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            acc.AutoCompletecbx(txb_madm, "SELECT TENDANHMUC FROM DANHMUC", "TENDANHMUC");
            acc.AutoCompletecbx(txb_ncc, "SELECT TENNHACC FROM NHACUNGCAP", "TENNHACC");
            acc.AutoCompleteByArray(txb_phanloai, DS_PhanLoai);
            Disable();
            tbx_masp.Enabled = false; tbx_tensp.Focus();
            tbx_masp.Text = " ";
            //label_thongbaoSP.Text = "";
            txb_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            dgv_SANPHAM.DataSource = acc.Select_Data("Select Row_number() over(order by MASP) STT,* from SanPham1");
            dgv_SANPHAM.ClearSelection();
            //groupBox_DSSP.Text = "Danh Sách Sản Phẩm";

            // CUSTOM SIZE COLUMN:
            dgv_SANPHAM.Columns[0].Width = 50;
            dgv_SANPHAM.Columns[1].Width = 130;
            dgv_SANPHAM.Columns[2].Width = 200;
            dgv_SANPHAM.Columns[3].Width = 130;
            dgv_SANPHAM.Columns[4].Width = 130;
            dgv_SANPHAM.Columns[5].Width = 200;
            dgv_SANPHAM.Columns[6].Width = 130;
            dgv_SANPHAM.Columns[7].Width = 130;
            dgv_SANPHAM.Columns[8].Width = 150;
            dgv_SANPHAM.Columns[9].Width = 120;
            dgv_SANPHAM.Columns[10].Width = 150;
            dgv_SANPHAM.Columns[11].Width = 150;
            dgv_SANPHAM.Columns[12].Width = 150;

            // hiển thị tiêu đề của các cột:
            dgv_SANPHAM.Columns[1].HeaderText = "Mã sản phẩm";
            dgv_SANPHAM.Columns[2].HeaderText = "Tên sản phẩm";
            dgv_SANPHAM.Columns[3].HeaderText = "Giá bán";
            dgv_SANPHAM.Columns[4].HeaderText = "Serial";
            dgv_SANPHAM.Columns[5].HeaderText = "Tên nhà cung cấp";
            dgv_SANPHAM.Columns[6].HeaderText = "Tên danh mục";
            dgv_SANPHAM.Columns[7].HeaderText = "Ngày sản xuất";
            dgv_SANPHAM.Columns[8].HeaderText = "Hạn sử dụng";
            dgv_SANPHAM.Columns[9].HeaderText = "Số lượng";
            dgv_SANPHAM.Columns[10].HeaderText = "Phân loại";
            dgv_SANPHAM.Columns[11].HeaderText = "Hình ảnh ";
            dgv_SANPHAM.Columns[12].HeaderText = "Ghi chú";
            //

            //textBox_showpart.Enabled = false;

            btn_themmoi.Enabled = true;
            btn_xoa.Enabled = true;
            btn_chophepsua.Enabled = true;
           
        }

        private void dgv_sp(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_masp.Text = dgv_SANPHAM.CurrentRow.Cells["MASP"].Value.ToString().Trim();
                tbx_tensp.Text = dgv_SANPHAM.CurrentRow.Cells["TENSP"].Value.ToString().Trim();
                txb_madm.Text = dgv_SANPHAM.CurrentRow.Cells["TENDANHMUC"].Value.ToString().Trim();
                txb_ncc.Text = dgv_SANPHAM.CurrentRow.Cells["TENNHACC"].Value.ToString().Trim();
                txb_serial.Text = dgv_SANPHAM.CurrentRow.Cells["SERIAL"].Value.ToString().Trim();
                txb_soluong.Text = dgv_SANPHAM.CurrentRow.Cells["SOLUONG"].Value.ToString().Trim();
                txb_giasp.Text = dgv_SANPHAM.CurrentRow.Cells["GIA"].Value.ToString().Trim();
                txb_phanloai.Text = dgv_SANPHAM.CurrentRow.Cells["PHANLOAI"].Value.ToString().Trim();
                dtpicker_nsx.Text = dgv_SANPHAM.CurrentRow.Cells["NGAYSANXUAT"].Value.ToString();
                dtpicker_hsd.Text = dgv_SANPHAM.CurrentRow.Cells["HANSUDUNG"].Value.ToString().Trim();
                txb_ghichu.Text = dgv_SANPHAM.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();
                filename = dgv_SANPHAM.CurrentRow.Cells["HINHANH"].Value.ToString().Trim();
                if (filename == "")
                {
                    pictureBox_sanpham.Image = null;
                }
                else
                {
                    filepart = Application.StartupPath + "\\Images\\" + filename;
                    if (!File.Exists(filepart))
                    {
                        pictureBox_sanpham.Image = null;
                        //MessageBox.Show("Đường dẫn ảnh không đúng", "Lỗi");
                    }
                    else
                    {
                        pictureBox_sanpham.Image = Image.FromFile(filepart.ToString());
                        pictureBox_sanpham.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            cleartext();
            Frm_SanPham_Load(sender, e);
        }

        private void txt_timkiem_leave(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "")
            {
                txb_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_tk_enter(object sender, EventArgs e)
        {
            if (txb_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txb_timkiem.Text = "";
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_tensp.Text == "" || txb_madm.Text == "" || txb_ncc.Text == "" || txb_phanloai.Text == "" || txb_serial.Text == "" || txb_soluong.Value == 0)
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các mục!", "Thông Báo");
                    tbx_masp.Focus();
                }
                else if (filepart == "")
                {
                    MessageBox.Show("Hãy chọn ảnh sản phẩm", "Thông Báo");
                    button8.Focus();
                }
                else
                {
                    DataTable dtncc = new DataTable();
                    DataTable dtdm = new DataTable();
                    DataTable dtmsp = new DataTable();
                    DataTable dttsp = new DataTable();
                    dtmsp = acc.CheckSql("select *from SANPHAM where MASP='" + tbx_masp.Text + "'");
                    dtncc = acc.CheckSql("Select *from NHACUNGCAP WHERE MANCC='" + txb_ncc.Text + "'");
                    dtdm = acc.CheckSql("SELECT *FROM DANHMUC WHERE MADANHMUC='" + txb_madm.Text + "'");
                    dttsp = acc.CheckSql("SELECT *FROM SANPHAM WHERE TENSP='" + tbx_tensp.Text + "'");
                    if (dtncc.Rows.Count < 0)
                    {
                        MessageBox.Show("Nhà cung cấp chưa tồn tại", "Thông Báo");
                        tbx_masp.Clear();
                        txb_madm.ResetText();
                        txb_madm.Focus();
                    }
                    else if (dtdm.Rows.Count < 0)
                    {
                        MessageBox.Show("Danh mục chưa tồn tại", "Thông Báo");
                        txb_madm.ResetText();
                        txb_madm.Focus();
                    }
                    else if (dtmsp.Rows.Count > 0 || dttsp.Rows.Count > 0)
                    {
                        MessageBox.Show("Sản phẩm này đã tồn tại!", "Thông Báo");
                        tbx_masp.Clear();
                        tbx_masp.Focus();
                        tbx_tensp.Clear();
                        tbx_tensp.Focus();
                    }

                    else
                    {
                        var itemNCC = txb_ncc.GetItemText(txb_ncc.SelectedItem);
                        ThongTinNCC(itemNCC);
                        var itemDM = txb_madm.GetItemText(txb_madm.SelectedItem);
                        ThongTinDM(itemDM);
                        //filepart = openFile_PictureSP.FileName;
                        if (MessageBox.Show("Bạn chắc chắn muốn thêm sản phẩm này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.THEM_SANPHAM(tbx_masp.Text, tbx_tensp.Text, MANCC, float.Parse(txb_giasp.Text), MADM, txb_serial.Text, filename, dtpicker_nsx.Value, dtpicker_hsd.Value, txb_ghichu.Text, Convert.ToInt32(txb_soluong.Value), txb_phanloai.Text);
                            Frm_SanPham_Load(sender, e);
                            cleartext();
                            dgv_SANPHAM.ClearSelection();
                            //label_thongbaoSP.Text = "Thêm THành Công Sản Phẩm mới";
                            MessageBox.Show("Thêm thành công!", "Thông Báo");
                            tbx_tensp.Focus();
                        }
                        //acc.THEM_SANPHAM(tbx_masp.Text, tbx_tensp.Text, MANCC, float.Parse(txb_giasp.Text), MADM, txb_serial.Text, filename, dtpicker_nsx.Value, dtpicker_hsd.Value, txb_ghichu.Text, Convert.ToInt32(txb_soluong.Value), txb_phanloai.Text);
                        //SANPHAM_Load(sender, e);
                        //cleartext();
                        //dgv_SANPHAM.ClearSelection();
                        ////label_thongbaoSP.Text = "Thêm THành Công Sản Phẩm mới";
                        //MessageBox.Show("Thêm thành công!","Thông Báo");
                        //tbx_tensp.Focus();

                    }


                }
            }
            if (key == 2)
            {
                DataTable dtdm = acc.CheckSql("SELECT *From DANHMUC where MADANHMUC='" + txb_madm.Text + "'");
                DataTable dtncc = acc.CheckSql("SELECT *From NHACUNGCAP where MANCC='" + txb_ncc.Text + "'");
                if (dtdm.Rows.Count < 0)
                {
                    MessageBox.Show("Mã danh mục không tồn tại", "THông báo");
                    txb_madm.ResetText();
                    txb_madm.Focus();
                }
                else if (dtncc.Rows.Count < 0)
                {
                    MessageBox.Show("Mã nhà cung cấp không tồn tại", "Thông Báo");
                    txb_ncc.ResetText();
                    txb_ncc.Focus();
                }
                else
                {
                    var itemNCC = txb_ncc.GetItemText(txb_ncc.SelectedItem);
                    ThongTinNCC(itemNCC);
                    var itemDM = txb_madm.GetItemText(txb_madm.SelectedItem);
                    ThongTinDM(itemDM);
                    if (MessageBox.Show("Bạn chắc chắn muốn sửa sản phẩm này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.SUA_SANPHAM(tbx_masp.Text, tbx_tensp.Text, MANCC, float.Parse(txb_giasp.Text), MADM, txb_serial.Text, filename, dtpicker_nsx.Value, dtpicker_hsd.Value, txb_ghichu.Text, Convert.ToInt32(txb_soluong.Value), txb_phanloai.Text);
                        Frm_SanPham_Load(sender, e);
                        dgv_SANPHAM.ClearSelection();
                        cleartext();
                        //label_thongbaoSP.Text = "Sửa Thông Tin thành công";
                        MessageBox.Show("Sửa thông tin thành công!", "Thông Báo");
                    }
                    //filepart = openFile_PictureSP.FileName;
                    //acc.SUA_SANPHAM(tbx_masp.Text, tbx_tensp.Text, MANCC, float.Parse(txb_giasp.Text), MADM, txb_serial.Text, filename, dtpicker_nsx.Value, dtpicker_hsd.Value, txb_ghichu.Text, Convert.ToInt32(txb_soluong.Value), txb_phanloai.Text);
                    //SANPHAM_Load(sender, e);
                    //dgv_SANPHAM.ClearSelection();
                    //cleartext();
                    ////label_thongbaoSP.Text = "Sửa Thông Tin thành công";
                    //MessageBox.Show("Sửa thông tin thành công!", "Thông Báo");
                }
            }

        }
    }
}
