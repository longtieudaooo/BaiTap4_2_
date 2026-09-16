namespace BaiTap4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var khoaHoc = new[]
            {
        new { Ma = "C01", Ten = "Lập trình C#" },
        new { Ma = "J01", Ten = "Lập trình Java" },
        new { Ma = "W01", Ten = "Lập trình Web" }
    };

            cboCourse.DataSource = khoaHoc;
            cboCourse.DisplayMember = "Ten";
            cboCourse.ValueMember = "Ma";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string hoTen = txtFullName.Text;
            string soDienThoai = mtxtPhone.Text;
            string ngaySinh = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string khoaHoc = cboCourse.Text;

            string gioiTinh = "";

            if (rdoMale.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoFemale.Checked)
            {
                gioiTinh = "Nữ";
            }

            string soThich = "";

            if (chkReading.Checked)
            {
                soThich += "Đọc sách, ";
            }

            if (chkFootball.Checked)
            {
                soThich += "Đá bóng, ";
            }

            if (chkGame.Checked)
            {
                soThich += "Chơi game, ";
            }

            if (soThich == "")
            {
                soThich = "Không có";
            }

            MessageBox.Show(
                "THÔNG TIN ĐĂNG KÝ\n\n" +
                "Họ tên: " + hoTen + "\n" +
                "Số điện thoại: " + soDienThoai + "\n" +
                "Ngày sinh: " + ngaySinh + "\n" +
                "Khóa học: " + khoaHoc + "\n" +
                "Giới tính: " + gioiTinh + "\n" +
                "Sở thích: " + soThich,
                "Thông tin đăng ký"
            );
        }
    }
}
