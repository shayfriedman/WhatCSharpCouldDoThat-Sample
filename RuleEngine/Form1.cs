/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System.Windows.Forms;
using System;
using RuleEngine.Properties;

namespace RuleEngine
{
  public partial class Form1 : Form
  {
    private readonly Form2 _ruleEditor;

    public Form1()
    {
      InitializeComponent();

      _ruleEditor = new Form2();
      _ruleEditor.CustomRuleVisible = true;   
    }

    private void button1_Click(object sender, EventArgs e)
    {
      bool valid;
      if (_ruleEditor.IsNumeric)
      {
        int temp;
        valid = Int32.TryParse(tbValue.Text, out temp);

        if (valid)
        {
          valid = _ruleEditor.NumericRange.IsInRange(temp);
        }
      }
      else
      {
        valid = tbValue.Text.Length <= _ruleEditor.TextMaxLength;
      }

      if (valid && _ruleEditor.CustomRuleVisible)
      {
        try
        {
          var engine = IronRuby.Ruby.CreateEngine();
          
			
          // Expose the value to the custom code
          engine.Runtime.Globals.SetVariable("Value", tbValue.Text);
          
          // Execute the custom code
          valid = engine.Execute<bool>(_ruleEditor.CustomRuleCode);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }

      SetResultImage(valid);
    }

    private void SetResultImage(bool success)
    {       
      resultPicture.Image = success ? Resources.smiley : Resources.sad;      
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      _ruleEditor.ShowDialog();
    }
  }
}
