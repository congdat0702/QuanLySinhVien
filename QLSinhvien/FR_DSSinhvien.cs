using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhvien
{
    public partial class FR_DSSinhvien : Form
    {
        public FR_DSSinhvien()
        {
            InitializeComponent();
        }

        private void FR_DSSinhvien_Load(object sender, EventArgs e)
        {

            this.qlsvRv.RefreshReport();
        }
    }
}
