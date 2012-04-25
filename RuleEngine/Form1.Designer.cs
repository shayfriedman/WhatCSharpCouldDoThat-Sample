namespace RuleEngine
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.tbValue = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.resultPicture = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.label1.Location = new System.Drawing.Point(178, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 32);
      this.label1.TabIndex = 1;
      this.label1.Text = "Value:";
      // 
      // tbValue
      // 
      this.tbValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.tbValue.Location = new System.Drawing.Point(264, 12);
      this.tbValue.Name = "tbValue";
      this.tbValue.Size = new System.Drawing.Size(223, 34);
      this.tbValue.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.button1.Location = new System.Drawing.Point(274, 72);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(128, 43);
      this.button1.TabIndex = 3;
      this.button1.Text = "Validate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.linkLabel1.Location = new System.Drawing.Point(249, 118);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(186, 23);
      this.linkLabel1.TabIndex = 4;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Setup validation rules...";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // resultPicture
      // 
      this.resultPicture.Location = new System.Drawing.Point(201, 144);
      this.resultPicture.Name = "resultPicture";
      this.resultPicture.Size = new System.Drawing.Size(286, 214);
      this.resultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.resultPicture.TabIndex = 5;
      this.resultPicture.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::RuleEngine.Properties.Resources.magician_icon;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(160, 176);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(499, 370);
      this.Controls.Add(this.resultPicture);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tbValue);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Rule Engine";
      ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbValue;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.PictureBox resultPicture;
  }
}

