using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadMap
{
  public partial class frm_menu : Form
  {
    frm_employees FrmEmployees;
    frm_projects FrmProjects;
    frm_staffing_data FrmStaffing;

    public frm_menu()
    {
      InitializeComponent();
    }

    private void frm_menu_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Maximized;
      this.Text += " " + Assembly.GetEntryAssembly().GetName().Version.ToString();
      //this.IsMdiContainer = true;
    }

    private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (FrmEmployees == null || !Common.CheckForDuplicate(this, FrmEmployees))
      {
        FrmEmployees = new frm_employees();
        FrmEmployees.MdiParent = this;
        FrmEmployees.Show();
      }


    }

    private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (FrmProjects == null || !Common.CheckForDuplicate(this, FrmProjects))
      {
        FrmProjects = new frm_projects();
        FrmProjects.MdiParent = this;
        FrmProjects.Show();
      }
    }

    private void staffinToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (FrmStaffing == null || !Common.CheckForDuplicate(this, FrmStaffing))
      {
        FrmStaffing = new frm_staffing_data();
        FrmStaffing.MdiParent = this;
        FrmStaffing.Show();
      }
    }

  }
}
