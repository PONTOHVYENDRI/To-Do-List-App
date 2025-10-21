using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Tutup AboutForm (MainForm akan muncul kembali karena event diatur di MainForm)
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            // Hapus baris berikut karena menyebabkan form AboutForm terbuka berulang
            // AboutForm aboutForm = new AboutForm();
            // aboutForm.Show();

            // Tambahkan informasi tentang aplikasi (opsional)
            lblAboutInfo.Text = "Aplikasi To-Do List mengelola tugas";
        }

        private void lblAboutInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
