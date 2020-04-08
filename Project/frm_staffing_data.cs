using Controls;
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
  public partial class frm_staffing_data : Form
  {
    SqlConnection Con = new SqlConnection(Common.CONNECTION);
    //SqlDataAdapter adapt;
    String _cellValue = String.Empty;
    MasterControl MasterDetail;
    int WeekNumber;

    public frm_staffing_data()
    {
      InitializeComponent();
    }

    private void frm_staffing_data_Load(object sender, EventArgs e)
    {
      try
      {
        StringBuilder _query;
        DataSet _ds;

        _ds = new DataSet();
        _query = new StringBuilder();

        this.WindowState = FormWindowState.Maximized;
        this.AcceptButton = this.btn_load;

        WeekNumber = Common.GetIso8601WeekOfYear(DateTime.Now);
        //dataGridView1.EnableHeadersVisualStyles = false;

        //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
        //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
        //dataGridView1.ColumnHeadersHeight = 30;


        DisplayCheckBoxes();

        _query.AppendLine("SELECT   dbo.GetMonthByWeekNumber(cast(sd_year_start as char(4)),sd_week_start) AS Month, * ");
        _query.AppendLine("  FROM   STAFFING_DATA                                                                      ");
        _query.AppendLine("  INNER JOIN EMPLOYEES ON EM_ID = SD_EM_ID                                                  ");
        _query.AppendLine("  INNER JOIN PROJECTS  ON PJ_ID = SD_PJ_ID                                                  ");
        _query.AppendLine(" WHERE   1 = 1                                                                              ");
        //_query.AppendLine("   AND   sd_week_start = " + WeekNumber);
        _query.AppendLine(" ORDER BY SD_WEEK_START ASC, SD_PJ_ID ASC, EM_NAME ASC                                      ");

        _query.AppendLine("select * from employees");
        Con.Open();

        //SqlDataAdapter da = new SqlDataAdapter("testSP",conn);
        //da.SelectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter da = new SqlDataAdapter(_query.ToString(), Con))
        {
          da.Fill(_ds);

        }
        _ds.Tables[0].TableName = "STAFFING_DATA";
        _ds.Tables[1].TableName = "EMPLOYEES";

        MasterDetail = new MasterControl(ref _ds, false);
        MasterDetail.CellFormatting += _masterDetail_CellFormatting;
        MasterDetail.setParentSource("STAFFING_DATA", "EM_ID");
        //_masterDetail.childView.Add("EMPLOYEES", "employees");
        //  masterDetail.childView.Add(NwindDataSet.Invoices.TableName, "Invoices")


        this.Controls.Add(MasterDetail);
        MasterDetail.Dock = DockStyle.Fill;
        MasterDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        String[] _show_columns = { "sd_year_start", "sd_week_start", "Month", "em_name", "em_team", "pj_product_code", "pj_dev_code", "pj_name", "pj_client" };
        String[] _name_columns = { "Year", "Week", "Month", "Emp. Name", "Team", "Product Code", "Dev. Code", "Name", "Client" };

        foreach (DataGridViewColumn _col in MasterDetail.Columns)
        {
          if (!_show_columns.Contains(_col.Name))
          {
            _col.Visible = false;
          }
          else
          {
            int _index = Array.IndexOf(_show_columns, _col.Name);
            _col.HeaderText = _name_columns[_index];
          }
        }
        //_masterDetail.Columns[0].HeaderText = "Month";
        //_masterDetail.Columns["sd_week_start"].DisplayIndex = 1;
        //_masterDetail.Columns["sd_year_start"].DisplayIndex = 2;
        //_masterDetail.Columns[""].DisplayIndex = 1;



        this.Controls.Remove(dataGridView1);
        MasterDetail.BringToFront();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }


    }

    void _masterDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      try
      {
        if (e.ColumnIndex == MasterDetail.Columns["sd_week_start"].Index)
        {
          int? _grid_month = (int)e.Value;

          if (_grid_month != null)
          {
            if (_grid_month == WeekNumber)
            {
              MasterDetail.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
              MasterDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            //else
            //{
            //  MasterDetail.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            //}
          }
        }
      }
      catch
      {
        ;
      }
    }


    private void DisplayCheckBoxes()
    {
      try
      {
        String _query;
        String _field;

        _query = "SELECT DISTINCT EM_ROL FROM EMPLOYEES ORDER BY EM_ROL";
        _field = "EM_ROL";
        Common.GetChkListData(this.chk_rols, _query, _field);

        _query = "SELECT DISTINCT EM_TEAM FROM EMPLOYEES ORDER BY EM_TEAM";
        _field = "EM_TEAM";
        Common.GetChkListData(this.chk_teams, _query, _field);

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

    private void btn_reset_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (Control control in this.tabControl1.Controls)
        {
          if (!(control is TabPage) || control != this.tabControl1.SelectedTab)
          {
            continue;
          }
          foreach (Control item in control.Controls)
          {
            if (item is TextBox)
            {
              item.Text = "";
            }
            else if (item is CheckedListBox)
            {

              for (int i = 0; i < ((CheckedListBox)item).Items.Count; i++)
              {
                ((CheckedListBox)item).SetItemChecked(i, true);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btn_load_Click(object sender, EventArgs e)
    {
      DisplayData();
    }

    private void DisplayData()
    {
      StringBuilder _query;

      _query = new StringBuilder();

      _query.AppendLine("SELECT   dbo.GetMonthByWeekNumber(cast(sd_year_start as char(4)),sd_week_start) AS Month, * ");
      _query.AppendLine("  FROM   STAFFING_DATA                                                                      ");
      _query.AppendLine("  INNER JOIN EMPLOYEES ON EM_ID = SD_EM_ID                                                  ");
      _query.AppendLine("  INNER JOIN PROJECTS  ON PJ_ID = SD_PJ_ID                                                  ");
      _query.AppendLine(" WHERE   1 = 1                                                                              ");
      _query.AppendLine(" ORDER BY SD_WEEK_START ASC, SD_PJ_ID ASC, EM_NAME ASC                                      ");

      try
      {
        //con.Open();
        //DataTable dt = new DataTable();
        //adapt = new SqlDataAdapter(_query.ToString(), con);
        //adapt.Fill(dt);
        //dataGridView1.DataSource = dt;
        //dataGridView1.Columns[0].HeaderText = "ID";
        //dataGridView1.Columns[1].HeaderText = "Name";
        //dataGridView1.Columns[2].HeaderText = "Rol";
        //dataGridView1.Columns[3].HeaderText = "Team";

        //dataGridView1.Columns[0].ReadOnly = true;
        //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        //dataGridView1.Columns[1].Width = 200;

        //con.Close();

        dataGridView1.Rows.Clear();
        using (SqlCommand _cmd = new SqlCommand())
        {
          _cmd.CommandText = _query.ToString();// 
          _cmd.Connection = Con;
        if (Con.State != ConnectionState.Open)
        {
            Con.Open();
        }
          //a la variable DataReader asignamos  el la variable de tipo SqlCommand
          using (SqlDataReader _dr = _cmd.ExecuteReader())
          {

            //el ciclo while se ejecutará mientras lea registros en la tabla
            while (_dr.Read())
            {
              //variable de tipo entero para ir enumerando los la filas del datagridview
              int renglon = dataGridView1.Rows.Add();
              // especificamos en que fila se mostrará cada registro
              // nombredeldatagrid.filas[numerodefila].celdas[nombredelacelda].valor=
              // dr.tipodedatosalmacenado(dr.getordinal(nombredelcampo_en_la_base_de_datos)conviertelo_a_string_sino_es_del_tipo_string);
              dataGridView1.Rows[renglon].Cells[0].Value = _dr.GetString(_dr.GetOrdinal("EM_NAME"));//_dr.GetInt32(_dr.GetOrdinal("Month")).ToString();
              dataGridView1.Rows[renglon].Cells[1].Value = _dr.GetString(_dr.GetOrdinal("Month"));
              dataGridView1.Rows[renglon].Cells[2].Value = _dr.GetInt32(_dr.GetOrdinal("SD_WEEK_START"));
            }
          }
          Con.Close();
        }
        //cierra la conexión

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        if (Con.State == ConnectionState.Open)
        {
          Con.Close();
        }
      }
    }

    private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      //Preguntamos si el boton pulsado del Mouse es el Derecho
      //si no lo es no salimos sin hacer nada mas
      if (e.Button != MouseButtons.Right) return;

      if (e.ColumnIndex < 0 || e.RowIndex < 0 || dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
        return;

      //enviamos el valor de la celda a la variable _cellValue
      _cellValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();

      //Definimos el lugar donde aparecera el scontextMenuStrip
      contextMenuStrip1.Show(MousePosition);
    }
  }
}
