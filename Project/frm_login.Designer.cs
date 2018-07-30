namespace RoadMap
{
  partial class frm_login
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
      this.btn_login = new System.Windows.Forms.Button();
      this.txt_user = new System.Windows.Forms.TextBox();
      this.txt_pass = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btn_login
      // 
      this.btn_login.Location = new System.Drawing.Point(123, 181);
      this.btn_login.Name = "btn_login";
      this.btn_login.Size = new System.Drawing.Size(177, 39);
      this.btn_login.TabIndex = 0;
      this.btn_login.Text = "Login";
      this.btn_login.UseVisualStyleBackColor = true;
      this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
      // 
      // txt_user
      // 
      this.txt_user.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_user.Location = new System.Drawing.Point(52, 53);
      this.txt_user.Name = "txt_user";
      this.txt_user.Size = new System.Drawing.Size(310, 32);
      this.txt_user.TabIndex = 1;
      // 
      // txt_pass
      // 
      this.txt_pass.Font = new System.Drawing.Font("Verdana", 12F);
      this.txt_pass.Location = new System.Drawing.Point(52, 115);
      this.txt_pass.Name = "txt_pass";
      this.txt_pass.PasswordChar = '*';
      this.txt_pass.Size = new System.Drawing.Size(310, 32);
      this.txt_pass.TabIndex = 2;
      // 
      // frm_login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 253);
      this.Controls.Add(this.txt_pass);
      this.Controls.Add(this.txt_user);
      this.Controls.Add(this.btn_login);
      this.Name = "frm_login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Load += new System.EventHandler(this.frm_login_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_login;
    private System.Windows.Forms.TextBox txt_user;
    private System.Windows.Forms.TextBox txt_pass;
  }
}

