using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuleEngine
{
  public partial class Form2 : Form
  {    
    public bool IsNumeric
    {
      get { return rbNumeric.Checked; }
    }

    public Range NumericRange
    {
      get { return new Range(numMin.Value, numMax.Value); }
    }

    public int TextMaxLength
    {
      get { return (int)numMaxdLength.Value; }
    }

    public string CustomRuleCode
    {
      get { return tbCode.Text; }
    }

    public bool CustomRuleVisible
    {
      get; set;
    }

    public Form2()
    {
      InitializeComponent();
    }

    private void numMaxdLength_ValueChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      groupBox4.Visible = CustomRuleVisible;
    }
  }
}
