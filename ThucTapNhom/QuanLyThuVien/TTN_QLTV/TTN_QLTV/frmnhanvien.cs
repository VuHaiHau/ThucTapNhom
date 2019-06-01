using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BAL;
using System.IO;


namespace TTN_QLTV
{
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        private int key = 0;
        private string filename;
        public static string filepath = "";
        private string filepaths;
        NhanVienBAL bal_nhanvien = new NhanVienBAL();
        private void ClearText()
        {
            txtMaNV.Clear();
            txtTen.Clear();
            txtDiachi.Clear();
            txtLuong.Clear();
            txtsdt.Clear();
            dtNgaySinh.Text = DateTime.Now.ToShortDateString();
            rbNam.Checked = false;
            rbNu.Checked = false;

        }
        private void Enabletbx()
        {
            txtTen.Enabled = true;
            txtMaNV.Enabled = true;
            txtDiachi.Enabled = true;
            txtLuong.Enabled = true;
            txtsdt.Enabled = true;
            dtNgaySinh.Enabled = true;
            gbGT.Enabled = true;
        }
        private void Disabletbx()
        {

            txtTen.Enabled = false;
            txtMaNV.Enabled = false;
            txtDiachi.Enabled = false;
            txtLuong.Enabled = false;
            txtsdt.Enabled = false;
            dtNgaySinh.Enabled = false;
            gbGT.Enabled = false;
        }
        private void Enablebtn()
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btnLuu.Enabled = false;
            btn_file.Enabled = false;
        }

        private void Disablebtn()
        {
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btnLuu.Enabled = true;
            btn_file.Enabled = true;

        }
        void ShowData()
        {
            dgvNhanVien.DataSource = bal_nhanvien.GetData();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            dgvNhanVien.DataSource = bal_nhanvien.GetData();
            dgvNhanVien.ClearSelection();
            dgvNhanVien.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["TENNV"].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dgvNhanVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["LUONG"].HeaderText = "Lương";
            dgvNhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns["HINHANH"].HeaderText = "Hình Ảnh";


            dgvNhanVien.Columns["MANV"].Width = 100;
            dgvNhanVien.Columns["TENNV"].Width = 160;
            dgvNhanVien.Columns["NGAYSINH"].Width = 100;
            dgvNhanVien.Columns["GIOITINH"].Width = 50;
            dgvNhanVien.Columns["DIACHI"].Width = 200;
            dgvNhanVien.Columns["LUONG"].Width = 120;
            dgvNhanVien.Columns["SDT"].Width = 120;
            dgvNhanVien.Columns["HINHANH"].Width = 120;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                btlammoi_Click(sender, e);
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            frmnhanvien_Load(sender, e);
            ClearText();
            key = 0;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            btnLuu.Enabled = true;
            key = 1;
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            Disablebtn();
            Enabletbx();
            btnLuu.Enabled = true;
            key = 2;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            btnLuu.Enabled = true;
            key = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (key == 1)
            {
                if (txtMaNV.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtLuong.Text != "")
                {
                    string gioitinh = "";
                    if (rbNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }

                    NhanVien nv = new NhanVien(txtMaNV.Text.ToString().Trim(), txtTen.Text.ToString().Trim(), DateTime.Parse(dtNgaySinh.Text.ToString()), gioitinh, int.Parse(txtLuong.Text.ToString()), txtDiachi.Text.ToString().Trim(), txtsdt.Text.ToString().Trim(), filename);
                    if (bal_nhanvien.Them(nv) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Thêm thành công");
                        frmnhanvien_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_nhanvien.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                    }

                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");
            }

            if (key == 2)
            {


                if (txtMaNV.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtLuong.Text != ""&&txtsdt.Text!="")
                {

                    string gioitinh = "";
                    if (rbNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }

                    NhanVien nv = new NhanVien(txtMaNV.Text.ToString().Trim(), txtTen.Text.ToString().Trim(), DateTime.Parse(dtNgaySinh.Text.ToString()), gioitinh, int.Parse(txtLuong.Text.ToString()), txtDiachi.Text.ToString().Trim(), txtsdt.Text.ToString().Trim(),filename);
                    if (bal_nhanvien.Sua(nv) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        frmnhanvien_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_nhanvien.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Chọn dòng bạn muốn sửa và hãy nhập đầy đủ thông tin");

            }
            if (key == 3)
            {
                if (txtMaNV.Text.Length != 0)
                {
                    string query = @"DELETE FROM SinhVien Where masv='" + txtMaNV.Text + "'";

                    if (bal_nhanvien.Xoa(txtMaNV.Text.Trim()))
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Xóa thành công");
                        frmnhanvien_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_nhanvien.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Không Thể Xóa Nhân Viên Này");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn");
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MANV"].Value);
            txtTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TENNV"].Value);
            txtDiachi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DIACHI"].Value);
            txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["LUONG"].Value);
            dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value);
            txtsdt.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
            filename = dgvNhanVien.CurrentRow.Cells["HINHANH"].Value.ToString().Trim();
            if (filename == "")
            {
                pc_nhanvien.Image = null;
            }
            else
            {
                filepath = Application.StartupPath + "\\Images\\" + filename;
                if (!File.Exists(filepath))
                {
                    pc_nhanvien.Image = null;
                }
                else
                {
                    pc_nhanvien.Image = Image.FromFile(filepath.ToString());
                    pc_nhanvien.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            if (dgvNhanVien.CurrentRow.Cells["GIOITINH"].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                ShowData();
                if (bal_nhanvien.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dgvNhanVien.DataSource = bal_nhanvien.GetDataTimKiem(txtTimKiem.Text.Trim());

                }
                else
                {
                    Exception ex = bal_nhanvien.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void frmnhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void btn_file_Click(object sender, EventArgs e)
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
                pc_nhanvien.Image = Image.FromFile(ofdImages.FileName);
                filename = Path.GetFileName(ofdImages.FileName);
                pc_nhanvien.SizeMode = PictureBoxSizeMode.StretchImage;
                filepath = Application.StartupPath + "\\Images\\" + filename;
                if (!File.Exists(filenameX)) return;

                if (File.Exists(filepath))
                {

                }
                else
                    try
                    {
                        File.Copy(filenameX, filepath);
                    }
                    catch
                    {
                        MessageBox.Show("Đã phát sinh lỗi trong việc chọn ảnh upload, vui lòng kiểm tra lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                filename = "";
                pc_nhanvien.Image = null;
            }
            //    OpenFileDialog ofdImages = new OpenFileDialog();
            //    PictureBox objpt = new PictureBox();
            //    ofdImages.Title = "Chọn File Ảnh!";
            //    ofdImages.InitialDirectory = @"Documents";//Thư mục mặc định khi mở
            //    ofdImages.Filter = "All files (*.*)|*.*";// Lọc ra những file cần hiển thị
            //    ofdImages.FilterIndex = 1;//chúng ta có All files là 1,jpg là 2

            //    if(ofdImages.ShowDialog()==DialogResult.OK)
            //    {
            //        string filenameX = ofdImages.FileName;
            //        pc_nhanvien.Image = new Bitmap(ofdImages.FileName);
            //        filename = Path.GetFileName(ofdImages.FileName);
            //        pc_nhanvien.SizeMode = PictureBoxSizeMode.StretchImage;
            //        filepath = Path.Combine(@"C:\Users\Duong\Downloads\TTN_QLTV\TTN_QLTV\Images\");
            //File.Copy(filenameX,filepath);
            //}
        }
        
    }
}
