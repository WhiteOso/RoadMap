using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadMap
{
  public partial class frm_employees : Form
  {
    SqlConnection con = new SqlConnection(Common.CONNECTION);
    SqlDataAdapter adapt;

    public frm_employees()
    {
      InitializeComponent();
    }

    private void frm_employees_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Maximized;
      DisplayCheckBoxes();
      this.AcceptButton = this.btn_load;
    }

    private void btn_load_Click(object sender, EventArgs e)
    {
      DisplayData(GetValuesFromList(this.chk_rols), GetValuesFromList(this.chk_teams));
    }

    private String GetValuesFromList(CheckedListBox CheckedListBox)
    {
      String _values;
      _values = String.Empty;
      try
      {
        if (CheckedListBox.CheckedItems.Count == CheckedListBox.Items.Count || CheckedListBox.CheckedItems.Count == 0)
        {
          return _values;
        }

        foreach (Object item in CheckedListBox.CheckedItems)
        {
          _values += "'" + item.ToString() + "',";
        }

        _values = _values.Substring(0, _values.Length - 1);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      return _values;
    }

    private void DisplayCheckBoxes()
    {
      try
      {
        String _query;
        String _field;

        _query = "SELECT DISTINCT EM_ROL FROM EMPLOYEES ORDER BY EM_ROL";
        _field = "em_rol";
        Common.GetChkListData(this.chk_rols, _query, _field);

        _query = "SELECT DISTINCT EM_TEAM FROM EMPLOYEES ORDER BY EM_TEAM";
        _field = "em_team";
        Common.GetChkListData(this.chk_teams, _query, _field);
        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    //Display Data in DataGridView  
    private void DisplayData(String Rol, String Teams)
    {
      StringBuilder _query;
      _query = new StringBuilder();

      _query.AppendLine("SELECT   *        ");
      _query.AppendLine("  FROM   EMPLOYEES");
      _query.AppendLine(" WHERE   1 = 1    ");

      if (!String.IsNullOrWhiteSpace(Rol))
      {
        _query.AppendLine("AND   EM_ROL IN (" + Rol + ")");
      }

      if (!String.IsNullOrWhiteSpace(Teams))
      {
        _query.AppendLine("AND   EM_TEAM IN (" + Teams + ")");
      }

      if (!String.IsNullOrWhiteSpace(this.txt_employee.Text))
      {
        _query.AppendLine("AND   EM_NAME LIKE '%" + this.txt_employee.Text + "%'");
      }

      if (!String.IsNullOrWhiteSpace(this.txt_team.Text))
      {
        _query.AppendLine("AND   EM_TEAM LIKE '%" + this.txt_team.Text + "%'");
      }

      try
      {
        con.Open();
        DataTable dt = new DataTable();
        adapt = new SqlDataAdapter(_query.ToString(), con);
        adapt.Fill(dt);
        dataGridView1.DataSource = dt;
        dataGridView1.Columns[0].HeaderText = "ID";
        dataGridView1.Columns[1].HeaderText = "Name";
        dataGridView1.Columns[2].HeaderText = "Rol";
        dataGridView1.Columns[3].HeaderText = "Team";

        dataGridView1.Columns[0].ReadOnly = true;
        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        dataGridView1.Columns[1].Width = 200;

        con.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        if (con.State == ConnectionState.Open)
        {
          con.Close();
        }
      }
    }

    private void btn_reset_Click(object sender, EventArgs e)
    {
      this.txt_employee.Text = "";
      this.txt_team.Text = "";
      for (int i = 0; i < this.chk_rols.Items.Count; i++)
      {
        chk_rols.SetItemChecked(i, true);
      }
      for (int i = 0; i < this.chk_teams.Items.Count; i++)
      {
        chk_teams.SetItemChecked(i, true);
      }
    }

  }
}
