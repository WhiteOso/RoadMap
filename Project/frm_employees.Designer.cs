namespace RoadMap
{
  partial class frm_employees
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.chk_teams = new System.Windows.Forms.CheckedListBox();
      this.chk_rols = new System.Windows.Forms.CheckedListBox();
      this.btn_load = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.txt_employee = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_reset = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_team = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(1262, 670);
      this.dataGridView1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 926);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1262, 51);
      this.panel1.TabIndex = 1;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.txt_team);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.txt_employee);
      this.panel2.Controls.Add(this.panel4);
      this.panel2.Controls.Add(this.chk_teams);
      this.panel2.Controls.Add(this.chk_rols);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1262, 256);
      this.panel2.TabIndex = 2;
      // 
      // chk_teams
      // 
      this.chk_teams.FormattingEnabled = true;
      this.chk_teams.Location = new System.Drawing.Point(534, 0);
      this.chk_teams.Name = "chk_teams";
      this.chk_teams.Size = new System.Drawing.Size(190, 242);
      this.chk_teams.TabIndex = 2;
      // 
      // chk_rols
      // 
      this.chk_rols.FormattingEnabled = true;
      this.chk_rols.Location = new System.Drawing.Point(240, 0);
      this.chk_rols.Name = "chk_rols";
      this.chk_rols.Size = new System.Drawing.Size(190, 242);
      this.chk_rols.TabIndex = 1;
      // 
      // btn_load
      // 
      this.btn_load.Location = new System.Drawing.Point(27, 205);
      this.btn_load.Name = "btn_load";
      this.btn_load.Size = new System.Drawing.Size(109, 37);
      this.btn_load.TabIndex = 0;
      this.btn_load.Text = "Load";
      this.btn_load.UseVisualStyleBackColor = true;
      this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.dataGridView1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 256);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1262, 670);
      this.panel3.TabIndex = 3;
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.panel4.Controls.Add(this.btn_reset);
      this.panel4.Controls.Add(this.btn_load);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel4.Location = new System.Drawing.Point(1114, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(148, 256);
      this.panel4.TabIndex = 3;
      // 
      // txt_employee
      // 
      this.txt_employee.Location = new System.Drawing.Point(817, 32);
      this.txt_employee.Name = "txt_employee";
      this.txt_employee.Size = new System.Drawing.Size(291, 22);
      this.txt_employee.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(741, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 17);
      this.label1.TabIndex = 5;
      this.label1.Text = "Employee";
      // 
      // btn_reset
      // 
      this.btn_reset.Location = new System.Drawing.Point(27, 162);
      this.btn_reset.Name = "btn_reset";
      this.btn_reset.Size = new System.Drawing.Size(109, 37);
      this.btn_reset.TabIndex = 1;
      this.btn_reset.Text = "Reset";
      this.btn_reset.UseVisualStyleBackColor = true;
      this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(741, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Team";
      // 
      // txt_team
      // 
      this.txt_team.Location = new System.Drawing.Point(817, 71);
      this.txt_team.Name = "txt_team";
      this.txt_team.Size = new System.Drawing.Size(291, 22);
      this.txt_team.TabIndex = 6;
      // 
      // frm_employees
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1262, 977);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "frm_employees";
      this.Text = "Employees";
      this.Load += new System.EventHandler(this.frm_employees_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btn_load;
    private System.Windows.Forms.CheckedListBox chk_teams;
    private System.Windows.Forms.CheckedListBox chk_rols;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_employee;
    private System.Windows.Forms.Button btn_reset;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_team;
  }
}