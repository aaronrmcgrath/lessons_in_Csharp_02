namespace TestForm
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
			this.displayBox = new System.Windows.Forms.TextBox();
			this.txtBox = new System.Windows.Forms.TextBox();
			this.bntA = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// displayBox
			// 
			this.displayBox.Enabled = false;
			this.displayBox.Location = new System.Drawing.Point(62, 39);
			this.displayBox.Multiline = true;
			this.displayBox.Name = "displayBox";
			this.displayBox.Size = new System.Drawing.Size(480, 140);
			this.displayBox.TabIndex = 0;
			// 
			// txtBox
			// 
			this.txtBox.Location = new System.Drawing.Point(62, 350);
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(480, 22);
			this.txtBox.TabIndex = 1;
			// 
			// bntA
			// 
			this.bntA.Location = new System.Drawing.Point(62, 231);
			this.bntA.Name = "bntA";
			this.bntA.Size = new System.Drawing.Size(142, 52);
			this.bntA.TabIndex = 2;
			this.bntA.Text = "A";
			this.bntA.UseVisualStyleBackColor = true;
			// 
			// btnB
			// 
			this.btnB.Location = new System.Drawing.Point(232, 231);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(142, 52);
			this.btnB.TabIndex = 3;
			this.btnB.Text = "B";
			this.btnB.UseVisualStyleBackColor = true;
			// 
			// btnC
			// 
			this.btnC.Location = new System.Drawing.Point(400, 231);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(142, 52);
			this.btnC.TabIndex = 4;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(462, 393);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(80, 32);
			this.btnSubmit.TabIndex = 5;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.PlayGame);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 437);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.bntA);
			this.Controls.Add(this.txtBox);
			this.Controls.Add(this.displayBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.StartGame);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox displayBox;
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.Button bntA;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnSubmit;
	}
}

