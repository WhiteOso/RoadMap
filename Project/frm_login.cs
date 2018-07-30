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
  public partial class frm_login : Form
  {
    public frm_login()
    {
      InitializeComponent();
    }

    private void frm_login_Load(object sender, EventArgs e)
    {
      this.Text += " " + Assembly.GetEntryAssembly().GetName().Version.ToString();
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      //frm_menu frm_menu;
      //frm_menu = new frm_menu();
      //frm_menu.Show();
    }
  }
}
