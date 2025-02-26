using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SpellingJungle
{
	internal class Program
	{
		private const string TempSave = ".\\DOSWIN\\GAME\\MAGIC";

		private static readonly string appDataDir = Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"), "MAGIC-BST");

		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			//Now Create all of the directories
			foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
			{
				Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
			}

			//Copy all the files & Replaces any files with the same name
			foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
			{
				File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
			}
		}

		private static void Save()
		{
			CopyFilesRecursively(TempSave, appDataDir);
			Directory.Delete(TempSave, true);
		}

		private static void Main()
		{
			AppDomain.CurrentDomain.UnhandledException += (sender, e) => Save();
			AppDomain.CurrentDomain.ProcessExit += (sender, e) => Save();

			try
			{
				Directory.CreateDirectory(TempSave);
			}
			catch (UnauthorizedAccessException)
			{
				_ = MessageBox.Show("Make sure that Spelling Jungle is installed in admin-free location (admin locations include but not limited to Program Files, Program Files (x86), and Windows).", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Directory.Exists(appDataDir))
			{
				Directory.CreateDirectory(appDataDir);
			}
			else
			{
				CopyFilesRecursively(appDataDir, TempSave);
			}

			Process game = new Process
			{
				StartInfo = new ProcessStartInfo()
				{
					FileName = ".\\DOSBox.exe",
					Arguments = "-noconsole"
				}
			};

			game.Start();
			game.WaitForExit();

			Environment.Exit(0);
		}
	}
}
