namespace RoadMap
{
  partial class frm_menu
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.staffinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Verdana", 13.8F);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.staffinToolStripMenuItem,
            this.windowToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1262, 37);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // employeesToolStripMenuItem
      // 
      this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
      this.employeesToolStripMenuItem.Size = new System.Drawing.Size(154, 33);
      this.employeesToolStripMenuItem.Text = "Employees";
      this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
      // 
      // projectsToolStripMenuItem
      // 
      this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
      this.projectsToolStripMenuItem.Size = new System.Drawing.Size(121, 33);
      this.projectsToolStripMenuItem.Text = "Projects";
      this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
      // 
      // staffinToolStripMenuItem
      // 
      this.staffinToolStripMenuItem.Name = "staffinToolStripMenuItem";
      this.staffinToolStripMenuItem.Size = new System.Drawing.Size(116, 33);
      this.staffinToolStripMenuItem.Text = "Staffing";
      this.staffinToolStripMenuItem.Click += new System.EventHandler(this.staffinToolStripMenuItem_Click);
      // 
      // windowToolStripMenuItem
      // 
      this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
      this.windowToolStripMenuItem.Size = new System.Drawing.Size(120, 33);
      this.windowToolStripMenuItem.Text = "&Window";
      // 
      // frm_menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1262, 977);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "frm_menu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menu";
      this.Load += new System.EventHandler(this.frm_menu_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem staffinToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
  }
}