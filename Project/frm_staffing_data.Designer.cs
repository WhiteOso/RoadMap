namespace RoadMap
{
  partial class frm_staffing_data
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_projects = new System.Windows.Forms.TabPage();
            this.chk_product = new System.Windows.Forms.CheckedListBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.chk_dev = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_client = new System.Windows.Forms.CheckedListBox();
            this.txt_client = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_employees = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_team = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_employee = new System.Windows.Forms.TextBox();
            this.chk_teams = new System.Windows.Forms.CheckedListBox();
            this.chk_rols = new System.Windows.Forms.CheckedListBox();
            this.tab_others = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_projects.SuspendLayout();
            this.tab_employees.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 753);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 41);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 343);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 235);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.tabControl1);
            this.pnl_top.Controls.Add(this.panel4);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(946, 219);
            this.pnl_top.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_projects);
            this.tabControl1.Controls.Add(this.tab_employees);
            this.tabControl1.Controls.Add(this.tab_others);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 219);
            this.tabControl1.TabIndex = 14;
            // 
            // tab_projects
            // 
            this.tab_projects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.tab_projects.Controls.Add(this.chk_product);
            this.tab_projects.Controls.Add(this.txt_name);
            this.tab_projects.Controls.Add(this.chk_dev);
            this.tab_projects.Controls.Add(this.label4);
            this.tab_projects.Controls.Add(this.chk_client);
            this.tab_projects.Controls.Add(this.txt_client);
            this.tab_projects.Controls.Add(this.txt_product);
            this.tab_projects.Controls.Add(this.label3);
            this.tab_projects.Controls.Add(this.label1);
            this.tab_projects.Controls.Add(this.txt_dev);
            this.tab_projects.Controls.Add(this.label2);
            this.tab_projects.Location = new System.Drawing.Point(4, 22);
            this.tab_projects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_projects.Name = "tab_projects";
            this.tab_projects.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_projects.Size = new System.Drawing.Size(827, 193);
            this.tab_projects.TabIndex = 0;
            this.tab_projects.Text = "Projects";
            // 
            // chk_product
            // 
            this.chk_product.FormattingEnabled = true;
            this.chk_product.Location = new System.Drawing.Point(2, 5);
            this.chk_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_product.Name = "chk_product";
            this.chk_product.Size = new System.Drawing.Size(139, 184);
            this.chk_product.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(686, 107);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(219, 20);
            this.txt_name.TabIndex = 12;
            // 
            // chk_dev
            // 
            this.chk_dev.FormattingEnabled = true;
            this.chk_dev.Location = new System.Drawing.Point(145, 5);
            this.chk_dev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_dev.Name = "chk_dev";
            this.chk_dev.Size = new System.Drawing.Size(339, 184);
            this.chk_dev.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name";
            // 
            // chk_client
            // 
            this.chk_client.FormattingEnabled = true;
            this.chk_client.Location = new System.Drawing.Point(488, 5);
            this.chk_client.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_client.Name = "chk_client";
            this.chk_client.Size = new System.Drawing.Size(144, 184);
            this.chk_client.TabIndex = 3;
            // 
            // txt_client
            // 
            this.txt_client.Location = new System.Drawing.Point(686, 72);
            this.txt_client.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_client.Name = "txt_client";
            this.txt_client.Size = new System.Drawing.Size(219, 20);
            this.txt_client.TabIndex = 10;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(686, 8);
            this.txt_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(219, 20);
            this.txt_product.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product";
            // 
            // txt_dev
            // 
            this.txt_dev.Location = new System.Drawing.Point(686, 40);
            this.txt_dev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dev.Name = "txt_dev";
            this.txt_dev.Size = new System.Drawing.Size(219, 20);
            this.txt_dev.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dev.";
            // 
            // tab_employees
            // 
            this.tab_employees.Controls.Add(this.label5);
            this.tab_employees.Controls.Add(this.txt_team);
            this.tab_employees.Controls.Add(this.label6);
            this.tab_employees.Controls.Add(this.txt_employee);
            this.tab_employees.Controls.Add(this.chk_teams);
            this.tab_employees.Controls.Add(this.chk_rols);
            this.tab_employees.Location = new System.Drawing.Point(4, 22);
            this.tab_employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_employees.Name = "tab_employees";
            this.tab_employees.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_employees.Size = new System.Drawing.Size(827, 193);
            this.tab_employees.TabIndex = 1;
            this.tab_employees.Text = "Employees";
            this.tab_employees.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Team";
            // 
            // txt_team
            // 
            this.txt_team.Location = new System.Drawing.Point(553, 51);
            this.txt_team.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_team.Name = "txt_team";
            this.txt_team.Size = new System.Drawing.Size(219, 20);
            this.txt_team.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee";
            // 
            // txt_employee
            // 
            this.txt_employee.Location = new System.Drawing.Point(553, 20);
            this.txt_employee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_employee.Name = "txt_employee";
            this.txt_employee.Size = new System.Drawing.Size(219, 20);
            this.txt_employee.TabIndex = 10;
            // 
            // chk_teams
            // 
            this.chk_teams.FormattingEnabled = true;
            this.chk_teams.Location = new System.Drawing.Point(310, 3);
            this.chk_teams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_teams.Name = "chk_teams";
            this.chk_teams.Size = new System.Drawing.Size(162, 184);
            this.chk_teams.TabIndex = 9;
            // 
            // chk_rols
            // 
            this.chk_rols.FormattingEnabled = true;
            this.chk_rols.Location = new System.Drawing.Point(92, 3);
            this.chk_rols.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_rols.Name = "chk_rols";
            this.chk_rols.Size = new System.Drawing.Size(162, 184);
            this.chk_rols.TabIndex = 8;
            // 
            // tab_others
            // 
            this.tab_others.Location = new System.Drawing.Point(4, 22);
            this.tab_others.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_others.Name = "tab_others";
            this.tab_others.Size = new System.Drawing.Size(827, 193);
            this.tab_others.TabIndex = 2;
            this.tab_others.Text = "Others";
            this.tab_others.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.panel4.Controls.Add(this.btn_reset);
            this.panel4.Controls.Add(this.btn_load);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(835, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 219);
            this.panel4.TabIndex = 4;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(20, 132);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(82, 30);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Location = new System.Drawing.Point(20, 167);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(82, 30);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // frm_staffing_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(946, 794);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_staffing_data";
            this.Text = "frm_staffing_data";
            this.Load += new System.EventHandler(this.frm_staffing_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_projects.ResumeLayout(false);
            this.tab_projects.PerformLayout();
            this.tab_employees.ResumeLayout(false);
            this.tab_employees.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.TextBox txt_name;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txt_client;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_dev;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_product;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Button btn_reset;
    private System.Windows.Forms.Button btn_load;
    private System.Windows.Forms.CheckedListBox chk_client;
    private System.Windows.Forms.CheckedListBox chk_dev;
    private System.Windows.Forms.CheckedListBox chk_product;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tab_projects;
    private System.Windows.Forms.TabPage tab_employees;
    private System.Windows.Forms.TabPage tab_others;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txt_team;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txt_employee;
    private System.Windows.Forms.CheckedListBox chk_teams;
    private System.Windows.Forms.CheckedListBox chk_rols;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
  }
}