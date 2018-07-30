namespace RoadMap
{
  partial class frm_projects
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
      this.pnl_top = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.btn_reset = new System.Windows.Forms.Button();
      this.btn_load = new System.Windows.Forms.Button();
      this.chk_client = new System.Windows.Forms.CheckedListBox();
      this.chk_dev = new System.Windows.Forms.CheckedListBox();
      this.chk_product = new System.Windows.Forms.CheckedListBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.txt_product = new System.Windows.Forms.TextBox();
      this.txt_dev = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txt_client = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_name = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.pnl_top.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
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
      // pnl_top
      // 
      this.pnl_top.Controls.Add(this.txt_name);
      this.pnl_top.Controls.Add(this.label4);
      this.pnl_top.Controls.Add(this.txt_client);
      this.pnl_top.Controls.Add(this.label3);
      this.pnl_top.Controls.Add(this.txt_dev);
      this.pnl_top.Controls.Add(this.label2);
      this.pnl_top.Controls.Add(this.txt_product);
      this.pnl_top.Controls.Add(this.label1);
      this.pnl_top.Controls.Add(this.panel4);
      this.pnl_top.Controls.Add(this.chk_client);
      this.pnl_top.Controls.Add(this.chk_dev);
      this.pnl_top.Controls.Add(this.chk_product);
      this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_top.Location = new System.Drawing.Point(0, 0);
      this.pnl_top.Name = "pnl_top";
      this.pnl_top.Size = new System.Drawing.Size(1262, 256);
      this.pnl_top.TabIndex = 2;
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
      this.panel4.TabIndex = 4;
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
      // chk_client
      // 
      this.chk_client.FormattingEnabled = true;
      this.chk_client.Location = new System.Drawing.Point(665, 0);
      this.chk_client.Name = "chk_client";
      this.chk_client.Size = new System.Drawing.Size(190, 242);
      this.chk_client.TabIndex = 3;
      // 
      // chk_dev
      // 
      this.chk_dev.FormattingEnabled = true;
      this.chk_dev.Location = new System.Drawing.Point(208, 0);
      this.chk_dev.Name = "chk_dev";
      this.chk_dev.Size = new System.Drawing.Size(451, 242);
      this.chk_dev.TabIndex = 2;
      // 
      // chk_product
      // 
      this.chk_product.FormattingEnabled = true;
      this.chk_product.Location = new System.Drawing.Point(12, 0);
      this.chk_product.Name = "chk_product";
      this.chk_product.Size = new System.Drawing.Size(190, 242);
      this.chk_product.TabIndex = 1;
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(862, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 17);
      this.label1.TabIndex = 7;
      this.label1.Text = "Product";
      // 
      // txt_product
      // 
      this.txt_product.Location = new System.Drawing.Point(938, 12);
      this.txt_product.Name = "txt_product";
      this.txt_product.Size = new System.Drawing.Size(291, 22);
      this.txt_product.TabIndex = 6;
      // 
      // txt_dev
      // 
      this.txt_dev.Location = new System.Drawing.Point(938, 51);
      this.txt_dev.Name = "txt_dev";
      this.txt_dev.Size = new System.Drawing.Size(291, 22);
      this.txt_dev.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(862, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 17);
      this.label2.TabIndex = 9;
      this.label2.Text = "Dev.";
      // 
      // txt_client
      // 
      this.txt_client.Location = new System.Drawing.Point(938, 91);
      this.txt_client.Name = "txt_client";
      this.txt_client.Size = new System.Drawing.Size(291, 22);
      this.txt_client.TabIndex = 10;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(862, 94);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 17);
      this.label3.TabIndex = 11;
      this.label3.Text = "Client";
      // 
      // txt_name
      // 
      this.txt_name.Location = new System.Drawing.Point(938, 134);
      this.txt_name.Name = "txt_name";
      this.txt_name.Size = new System.Drawing.Size(291, 22);
      this.txt_name.TabIndex = 12;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(862, 137);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 17);
      this.label4.TabIndex = 13;
      this.label4.Text = "Name";
      // 
      // frm_projects
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1262, 977);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.pnl_top);
      this.Controls.Add(this.panel1);
      this.Name = "frm_projects";
      this.Text = "Projects";
      this.Load += new System.EventHandler(this.frm_employees_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.pnl_top.ResumeLayout(false);
      this.pnl_top.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.CheckedListBox chk_dev;
    private System.Windows.Forms.CheckedListBox chk_product;
    private System.Windows.Forms.CheckedListBox chk_client;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Button btn_reset;
    private System.Windows.Forms.Button btn_load;
    private System.Windows.Forms.TextBox txt_client;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_dev;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_product;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_name;
    private System.Windows.Forms.Label label4;
  }
}