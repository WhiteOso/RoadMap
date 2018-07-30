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
  public partial class frm_projects : Form
  {
    SqlConnection con = new SqlConnection(Common.CONNECTION);
    SqlDataAdapter adapt;

    public frm_projects()
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
      DisplayData(GetValuesFromList(this.chk_product),GetValuesFromList(this.chk_dev),GetValuesFromList(this.chk_client)); 
    }

    private String GetValuesFromList(CheckedListBox CheckedListBox)
    {
      String _values;
      _values = String.Empty;
      try
      {
        if(CheckedListBox.CheckedItems.Count == CheckedListBox.Items.Count || CheckedListBox.CheckedItems.Count == 0)
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

        _query = "SELECT DISTINCT PJ_PRODUCT_CODE FROM PROJECTS ORDER BY PJ_PRODUCT_CODE";
        _field = "PJ_PRODUCT_CODE";
        Common.GetChkListData(this.chk_product, _query, _field);

        _query = "SELECT DISTINCT PJ_NAME AS PJ_DEV_CODE FROM PROJECTS";
        _field = "PJ_DEV_CODE";
        Common.GetChkListData(this.chk_dev, _query, _field);

        _query = "SELECT DISTINCT PJ_CLIENT FROM PROJECTS ORDER BY PJ_CLIENT";
        _field = "PJ_CLIENT";
        Common.GetChkListData(this.chk_client, _query, _field);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    //Display Data in DataGridView  
    private void DisplayData(String ProductCode, String DevCode, String Client)
    {
      StringBuilder _query;
      _query = new StringBuilder();

      _query.AppendLine("SELECT   *        ");
      _query.AppendLine("  FROM   PROJECTS");
      _query.AppendLine(" WHERE   1 = 1    ");

      if (!String.IsNullOrWhiteSpace(ProductCode))
      {
        _query.AppendLine("AND   PJ_PRODUCT_CODE IN (" + ProductCode + ")");
      }

      if (!String.IsNullOrWhiteSpace(DevCode)) 
      {
        _query.AppendLine("AND   PJ_NAME IN (" + DevCode + ")");
      }

      if (!String.IsNullOrWhiteSpace(Client))
      {
        _query.AppendLine("AND   PJ_CLIENT IN (" + Client + ")");
      }

      if (!String.IsNullOrWhiteSpace(this.txt_client.Text))
      {
        _query.AppendLine("AND   PJ_CLIENT like '%" + this.txt_client.Text + "%'");
      }

      if (!String.IsNullOrWhiteSpace(this.txt_dev.Text))
      {
        _query.AppendLine("AND   PJ_DEV_CODE like '%" + this.txt_dev.Text + "%'");
      }

      if (!String.IsNullOrWhiteSpace(this.txt_product.Text))
      {
        _query.AppendLine("AND   PJ_PRODUCT_CODE like '%" + this.txt_product.Text + "%'");
      }

      if (!String.IsNullOrWhiteSpace(this.txt_name.Text))
      {
        _query.AppendLine("AND   PJ_NAME like '%" + this.txt_name.Text + "%'");
      }

      try
      {
        con.Open();
        DataTable dt = new DataTable();
        adapt = new SqlDataAdapter(_query.ToString(), con);
        adapt.Fill(dt);
        dataGridView1.DataSource = dt;
        dataGridView1.Columns[0].HeaderText = "ID";
        dataGridView1.Columns[1].HeaderText = "Product Name";
        dataGridView1.Columns[2].HeaderText = "Development Code";
        dataGridView1.Columns[3].HeaderText = "Client";
        dataGridView1.Columns[4].HeaderText = "Project Name";
        dataGridView1.Columns[5].HeaderText = "Notes";

        dataGridView1.Columns[0].ReadOnly = true;
        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        dataGridView1.Columns[1].Width = 200;
        dataGridView1.Columns[2].Width = 200;
        dataGridView1.Columns[3].Width = 200;
        dataGridView1.Columns[4].Width = 200;
        dataGridView1.Columns[5].Width = 400;


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
      for (int i = 0; i < this.chk_client.Items.Count; i++)
      {
        chk_client.SetItemChecked(i, true);
      }
      for (int i = 0; i < this.chk_dev.Items.Count; i++)
      {
        chk_dev.SetItemChecked(i, true);
      }
      for (int i = 0; i < this.chk_product.Items.Count; i++)
      {
        chk_product.SetItemChecked(i, true);
      }

      foreach (Control item in this.pnl_top.Controls)
      {
        if (item is TextBox)
        {
          item.Text = "";
        }
      }

    }

  }
}
