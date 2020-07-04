using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using Microsoft.Reporting.WinForms;

namespace WFA_GiaoDien_QuanLyQuanCaPhe
{
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            BAL_NUOC nuoc = new BAL_NUOC();
            ReportDataSource rds = new ReportDataSource("Dataser1", nuoc.lay_nuoc(2));
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            
        }
    }
}
