using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadMap
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      DialogResult result;
      var loginForm = new frm_login();
      result = loginForm.ShowDialog();
      if (result == DialogResult.OK)
      {
        //loginForm.Close();
        Application.Run(new frm_menu());
      }
    }
  }
}
