namespace SigmaDelta
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BtnStart = new System.Windows.Forms.Button();
			this.TxtVin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnStop = new System.Windows.Forms.Button();
			this.TxtVout = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.BtnCatch = new System.Windows.Forms.Button();
			this.BtnSet = new System.Windows.Forms.Button();
			this.TxtVoutRaw = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtPLimit = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtNLimit = new System.Windows.Forms.TextBox();
			this.BtnSetParam = new System.Windows.Forms.Button();
			this.CbxRatio = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// BtnStart
			// 
			this.BtnStart.Location = new System.Drawing.Point(225, 93);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(146, 29);
			this.BtnStart.TabIndex = 0;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// TxtVin
			// 
			this.TxtVin.Location = new System.Drawing.Point(93, 59);
			this.TxtVin.Name = "TxtVin";
			this.TxtVin.Size = new System.Drawing.Size(120, 21);
			this.TxtVin.TabIndex = 1;
			this.TxtVin.Text = "1.2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input:";
			// 
			// BtnStop
			// 
			this.BtnStop.Location = new System.Drawing.Point(225, 130);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(146, 29);
			this.BtnStop.TabIndex = 3;
			this.BtnStop.Text = "Stop";
			this.BtnStop.UseVisualStyleBackColor = true;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// TxtVout
			// 
			this.TxtVout.Location = new System.Drawing.Point(93, 96);
			this.TxtVout.Name = "TxtVout";
			this.TxtVout.Size = new System.Drawing.Size(120, 21);
			this.TxtVout.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Output:";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// BtnCatch
			// 
			this.BtnCatch.Location = new System.Drawing.Point(225, 178);
			this.BtnCatch.Name = "BtnCatch";
			this.BtnCatch.Size = new System.Drawing.Size(146, 29);
			this.BtnCatch.TabIndex = 6;
			this.BtnCatch.Text = "Catch";
			this.BtnCatch.UseVisualStyleBackColor = true;
			this.BtnCatch.Visible = false;
			this.BtnCatch.Click += new System.EventHandler(this.BtnCatch_Click);
			// 
			// BtnSet
			// 
			this.BtnSet.Location = new System.Drawing.Point(226, 55);
			this.BtnSet.Name = "BtnSet";
			this.BtnSet.Size = new System.Drawing.Size(146, 29);
			this.BtnSet.TabIndex = 7;
			this.BtnSet.Text = "Set";
			this.BtnSet.UseVisualStyleBackColor = true;
			this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
			// 
			// TxtVoutRaw
			// 
			this.TxtVoutRaw.Location = new System.Drawing.Point(93, 133);
			this.TxtVoutRaw.Name = "TxtVoutRaw";
			this.TxtVoutRaw.Size = new System.Drawing.Size(120, 21);
			this.TxtVoutRaw.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "Raw Value:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 12);
			this.label4.TabIndex = 10;
			this.label4.Text = "P:";
			// 
			// TxtPLimit
			// 
			this.TxtPLimit.Location = new System.Drawing.Point(44, 26);
			this.TxtPLimit.Name = "TxtPLimit";
			this.TxtPLimit.Size = new System.Drawing.Size(35, 21);
			this.TxtPLimit.TabIndex = 11;
			this.TxtPLimit.Text = "2.5";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(89, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 12);
			this.label5.TabIndex = 12;
			this.label5.Text = "N:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(152, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 12);
			this.label6.TabIndex = 13;
			this.label6.Text = "M:";
			// 
			// TxtNLimit
			// 
			this.TxtNLimit.Location = new System.Drawing.Point(111, 27);
			this.TxtNLimit.Name = "TxtNLimit";
			this.TxtNLimit.Size = new System.Drawing.Size(35, 21);
			this.TxtNLimit.TabIndex = 14;
			this.TxtNLimit.Text = "-2.5";
			// 
			// BtnSetParam
			// 
			this.BtnSetParam.Location = new System.Drawing.Point(226, 18);
			this.BtnSetParam.Name = "BtnSetParam";
			this.BtnSetParam.Size = new System.Drawing.Size(146, 29);
			this.BtnSetParam.TabIndex = 16;
			this.BtnSetParam.Text = "SetParam";
			this.BtnSetParam.UseVisualStyleBackColor = true;
			this.BtnSetParam.Click += new System.EventHandler(this.BtnSetParam_Click);
			// 
			// CbxRatio
			// 
			this.CbxRatio.FormattingEnabled = true;
			this.CbxRatio.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
			this.CbxRatio.Location = new System.Drawing.Point(171, 26);
			this.CbxRatio.Name = "CbxRatio";
			this.CbxRatio.Size = new System.Drawing.Size(42, 20);
			this.CbxRatio.TabIndex = 17;
			this.CbxRatio.Text = "256";
			// 
			// Form1
			// 
			this.AcceptButton = this.BtnSet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 174);
			this.Controls.Add(this.CbxRatio);
			this.Controls.Add(this.BtnSetParam);
			this.Controls.Add(this.TxtNLimit);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TxtPLimit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtVoutRaw);
			this.Controls.Add(this.BtnSet);
			this.Controls.Add(this.BtnCatch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtVout);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtVin);
			this.Controls.Add(this.BtnStart);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.TextBox TxtVin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.TextBox TxtVout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button BtnCatch;
		private System.Windows.Forms.Button BtnSet;
		private System.Windows.Forms.TextBox TxtVoutRaw;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtPLimit;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtNLimit;
		private System.Windows.Forms.Button BtnSetParam;
		private System.Windows.Forms.ComboBox CbxRatio;
	}
}

