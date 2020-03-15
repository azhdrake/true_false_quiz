namespace Quiz
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
      this.lblQuestion = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.rdoTrue = new System.Windows.Forms.RadioButton();
      this.rdoFalse = new System.Windows.Forms.RadioButton();
      this.lblScore = new System.Windows.Forms.Label();
      this.btnSubmit = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblQuestion
      // 
      this.lblQuestion.Location = new System.Drawing.Point(32, 24);
      this.lblQuestion.Name = "lblQuestion";
      this.lblQuestion.Size = new System.Drawing.Size(350, 48);
      this.lblQuestion.TabIndex = 0;
      this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.rdoFalse);
      this.panel1.Controls.Add(this.rdoTrue);
      this.panel1.Location = new System.Drawing.Point(37, 94);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(345, 150);
      this.panel1.TabIndex = 1;
      // 
      // rdoTrue
      // 
      this.rdoTrue.AutoSize = true;
      this.rdoTrue.Location = new System.Drawing.Point(22, 33);
      this.rdoTrue.Name = "rdoTrue";
      this.rdoTrue.Size = new System.Drawing.Size(87, 29);
      this.rdoTrue.TabIndex = 0;
      this.rdoTrue.TabStop = true;
      this.rdoTrue.Text = "True";
      this.rdoTrue.UseVisualStyleBackColor = true;
      // 
      // rdoFalse
      // 
      this.rdoFalse.AutoSize = true;
      this.rdoFalse.Location = new System.Drawing.Point(22, 89);
      this.rdoFalse.Name = "rdoFalse";
      this.rdoFalse.Size = new System.Drawing.Size(96, 29);
      this.rdoFalse.TabIndex = 1;
      this.rdoFalse.TabStop = true;
      this.rdoFalse.Text = "False";
      this.rdoFalse.UseVisualStyleBackColor = true;
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Location = new System.Drawing.Point(170, 327);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(92, 25);
      this.lblScore.TabIndex = 2;
      this.lblScore.Text = "Score: 0";
      // 
      // btnSubmit
      // 
      this.btnSubmit.Location = new System.Drawing.Point(141, 264);
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(148, 41);
      this.btnSubmit.TabIndex = 3;
      this.btnSubmit.Text = "Submit";
      this.btnSubmit.UseVisualStyleBackColor = true;
      this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(427, 373);
      this.Controls.Add(this.btnSubmit);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblQuestion);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblQuestion;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton rdoFalse;
    private System.Windows.Forms.RadioButton rdoTrue;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Button btnSubmit;
  }
}

