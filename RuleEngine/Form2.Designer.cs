namespace RuleEngine
{
  partial class Form2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      this.rbNumeric = new System.Windows.Forms.RadioButton();
      this.rbTextual = new System.Windows.Forms.RadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.numMax = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.numMin = new System.Windows.Forms.NumericUpDown();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.numMaxdLength = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.tbCode = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxdLength)).BeginInit();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // rbNumeric
      // 
      this.rbNumeric.AutoSize = true;
      this.rbNumeric.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.rbNumeric.Location = new System.Drawing.Point(6, 38);
      this.rbNumeric.Name = "rbNumeric";
      this.rbNumeric.Size = new System.Drawing.Size(127, 36);
      this.rbNumeric.TabIndex = 0;
      this.rbNumeric.TabStop = true;
      this.rbNumeric.Text = "Numeric";
      this.rbNumeric.UseVisualStyleBackColor = true;
      // 
      // rbTextual
      // 
      this.rbTextual.AutoSize = true;
      this.rbTextual.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.rbTextual.Location = new System.Drawing.Point(6, 80);
      this.rbTextual.Name = "rbTextual";
      this.rbTextual.Size = new System.Drawing.Size(113, 36);
      this.rbTextual.TabIndex = 1;
      this.rbTextual.TabStop = true;
      this.rbTextual.Text = "Textual";
      this.rbTextual.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbTextual);
      this.groupBox1.Controls.Add(this.rbNumeric);
      this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(196, 131);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Input Type";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.numMax);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.numMin);
      this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.groupBox2.Location = new System.Drawing.Point(214, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(219, 131);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Number Rules";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.label2.Location = new System.Drawing.Point(6, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 32);
      this.label2.TabIndex = 3;
      this.label2.Text = "Max:";
      // 
      // numMax
      // 
      this.numMax.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.numMax.Location = new System.Drawing.Point(74, 77);
      this.numMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
      this.numMax.Name = "numMax";
      this.numMax.Size = new System.Drawing.Size(120, 39);
      this.numMax.TabIndex = 2;
      this.numMax.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.label1.Location = new System.Drawing.Point(6, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 32);
      this.label1.TabIndex = 1;
      this.label1.Text = "Min:";
      // 
      // numMin
      // 
      this.numMin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.numMin.Location = new System.Drawing.Point(74, 33);
      this.numMin.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
      this.numMin.Name = "numMin";
      this.numMin.Size = new System.Drawing.Size(120, 39);
      this.numMin.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.numMaxdLength);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.groupBox3.Location = new System.Drawing.Point(12, 149);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(421, 94);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Text Rules";
      // 
      // numMaxdLength
      // 
      this.numMaxdLength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.numMaxdLength.Location = new System.Drawing.Point(153, 35);
      this.numMaxdLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.numMaxdLength.Name = "numMaxdLength";
      this.numMaxdLength.Size = new System.Drawing.Size(120, 39);
      this.numMaxdLength.TabIndex = 1;
      this.numMaxdLength.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.numMaxdLength.ValueChanged += new System.EventHandler(this.numMaxdLength_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.label3.Location = new System.Drawing.Point(6, 35);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(141, 32);
      this.label3.TabIndex = 0;
      this.label3.Text = "Max length:";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.button1.Location = new System.Drawing.Point(351, 523);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(93, 40);
      this.button1.TabIndex = 5;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.tbCode);
      this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.groupBox4.Location = new System.Drawing.Point(13, 250);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(420, 267);
      this.groupBox4.TabIndex = 6;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Custom Rules";
      // 
      // tbCode
      // 
      this.tbCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.tbCode.Location = new System.Drawing.Point(11, 38);
      this.tbCode.Multiline = true;
      this.tbCode.Name = "tbCode";
      this.tbCode.Size = new System.Drawing.Size(403, 223);
      this.tbCode.TabIndex = 0;
      this.tbCode.Text = "# Constant Value contains the input\r\nreturn true";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(456, 575);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Rule Editor";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxdLength)).EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RadioButton rbNumeric;
    private System.Windows.Forms.RadioButton rbTextual;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numMax;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numMin;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.NumericUpDown numMaxdLength;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox tbCode;
  }
}