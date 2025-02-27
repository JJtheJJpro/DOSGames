namespace SpellingJungle
{
	partial class ConfigForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
			this.TitleLbl = new System.Windows.Forms.Label();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.DblBufChk = new System.Windows.Forms.CheckBox();
			this.MouseLbl = new System.Windows.Forms.Label();
			this.FullScrnChk = new System.Windows.Forms.RadioButton();
			this.WindowChk = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.HigherRdo = new System.Windows.Forms.RadioButton();
			this.LowerRdo = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLbl.Location = new System.Drawing.Point(12, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(417, 32);
			this.TitleLbl.TabIndex = 0;
			this.TitleLbl.Text = "Spelling Jungle Configuration";
			// 
			// SaveBtn
			// 
			this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveBtn.Location = new System.Drawing.Point(224, 403);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(205, 53);
			this.SaveBtn.TabIndex = 2;
			this.SaveBtn.Text = "Play";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelBtn.Location = new System.Drawing.Point(12, 403);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(205, 53);
			this.CancelBtn.TabIndex = 3;
			this.CancelBtn.Text = "Exit";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// DblBufChk
			// 
			this.DblBufChk.AutoSize = true;
			this.DblBufChk.Enabled = false;
			this.DblBufChk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DblBufChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DblBufChk.Location = new System.Drawing.Point(44, 118);
			this.DblBufChk.Name = "DblBufChk";
			this.DblBufChk.Size = new System.Drawing.Size(198, 34);
			this.DblBufChk.TabIndex = 4;
			this.DblBufChk.Text = "Double Buffer";
			this.DblBufChk.UseVisualStyleBackColor = true;
			// 
			// MouseLbl
			// 
			this.MouseLbl.AutoSize = true;
			this.MouseLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.MouseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MouseLbl.Location = new System.Drawing.Point(13, 299);
			this.MouseLbl.Name = "MouseLbl";
			this.MouseLbl.Size = new System.Drawing.Size(432, 78);
			this.MouseLbl.TabIndex = 5;
			this.MouseLbl.Text = "NOTE: This game will capture the mouse,\r\nmeaning you can\'t move the mouse outside" +
    "\r\nof the window.  Press Ctrl+F10 to escape.";
			// 
			// FullScrnChk
			// 
			this.FullScrnChk.AutoSize = true;
			this.FullScrnChk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.FullScrnChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FullScrnChk.Location = new System.Drawing.Point(12, 79);
			this.FullScrnChk.Name = "FullScrnChk";
			this.FullScrnChk.Size = new System.Drawing.Size(166, 34);
			this.FullScrnChk.TabIndex = 6;
			this.FullScrnChk.TabStop = true;
			this.FullScrnChk.Text = "FullScreen";
			this.FullScrnChk.UseVisualStyleBackColor = true;
			// 
			// WindowChk
			// 
			this.WindowChk.AutoSize = true;
			this.WindowChk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.WindowChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WindowChk.Location = new System.Drawing.Point(12, 158);
			this.WindowChk.Name = "WindowChk";
			this.WindowChk.Size = new System.Drawing.Size(164, 34);
			this.WindowChk.TabIndex = 7;
			this.WindowChk.TabStop = true;
			this.WindowChk.Text = "Windowed";
			this.WindowChk.UseVisualStyleBackColor = true;
			this.WindowChk.CheckedChanged += new System.EventHandler(this.FullScrnChk_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.HigherRdo);
			this.panel1.Controls.Add(this.LowerRdo);
			this.panel1.Location = new System.Drawing.Point(44, 198);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(173, 86);
			this.panel1.TabIndex = 8;
			// 
			// HigherRdo
			// 
			this.HigherRdo.AutoSize = true;
			this.HigherRdo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.HigherRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HigherRdo.Location = new System.Drawing.Point(0, 43);
			this.HigherRdo.Name = "HigherRdo";
			this.HigherRdo.Size = new System.Drawing.Size(164, 34);
			this.HigherRdo.TabIndex = 10;
			this.HigherRdo.TabStop = true;
			this.HigherRdo.Text = "2048x1536";
			this.HigherRdo.UseVisualStyleBackColor = true;
			// 
			// LowerRdo
			// 
			this.LowerRdo.AutoSize = true;
			this.LowerRdo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.LowerRdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LowerRdo.Location = new System.Drawing.Point(0, 3);
			this.LowerRdo.Name = "LowerRdo";
			this.LowerRdo.Size = new System.Drawing.Size(151, 34);
			this.LowerRdo.TabIndex = 9;
			this.LowerRdo.TabStop = true;
			this.LowerRdo.Text = "1024x768";
			this.LowerRdo.UseVisualStyleBackColor = true;
			// 
			// ConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 468);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.WindowChk);
			this.Controls.Add(this.FullScrnChk);
			this.Controls.Add(this.MouseLbl);
			this.Controls.Add(this.DblBufChk);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.TitleLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ConfigForm";
			this.Text = "Spelling Jungle Configuration";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.CheckBox DblBufChk;
		private System.Windows.Forms.Label MouseLbl;
		private System.Windows.Forms.RadioButton FullScrnChk;
		private System.Windows.Forms.RadioButton WindowChk;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton HigherRdo;
		private System.Windows.Forms.RadioButton LowerRdo;
	}
}