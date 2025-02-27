using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpellingJungle
{
	public partial class ConfigForm : Form
	{
		private const string ConfigFile = ".\\dosbox.conf";
		private string conffile;
		private readonly bool oFullscreen;
		private readonly bool oFulldouble;
		private readonly bool oLowerRes;
		private bool saved;

		public ConfigForm()
		{
			InitializeComponent();

			conffile = File.ReadAllText(ConfigFile);
			string[] linesconffile = File.ReadAllLines(ConfigFile);
			WindowChk.Checked = !(FullScrnChk.Checked = oFullscreen = bool.Parse(linesconffile.First(s => s.StartsWith("fullscreen=")).Replace("fullscreen=", "")));
			DblBufChk.Checked = oFulldouble = bool.Parse(linesconffile.First(s => s.StartsWith("fulldouble=")).Replace("fulldouble=", ""));
			HigherRdo.Checked = !(LowerRdo.Checked = oLowerRes = linesconffile.First(s => s.StartsWith("windowresolution=")).Replace("windowresolution=", "") == "1024x768");
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			// line 7, index 6

			conffile.IndexOf("output=" + (oFullscreen ? "surface" : "opengl"));
			conffile = conffile.Replace("fullscreen=" + oFullscreen.ToString().ToLower(),"fullscreen=" + FullScrnChk.Checked.ToString().ToLower())
										 .Replace("fulldouble=" + oFulldouble.ToString().ToLower(), "fulldouble=" + DblBufChk.Checked.ToString().ToLower())
										 .Replace("output=" + (oFullscreen ? "surface" : "opengl"), "output=" + (FullScrnChk.Checked ? "surface" : "opengl"))
										 .Replace("windowresolution=" + (oLowerRes ? "1024x768" : "2048x1536"), "windowresolution=" + (LowerRdo.Checked ? "1024x768" : "2048x1536"));
			File.WriteAllText(ConfigFile, conffile);
			saved = true;
			Application.Exit();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void FullScrnChk_CheckedChanged(object sender, EventArgs e)
		{
			MouseLbl.Visible = panel1.Enabled = !(DblBufChk.Enabled = FullScrnChk.Checked);
		}

		private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!saved)
			{
				Environment.Exit(0);
			}
		}
	}
}
