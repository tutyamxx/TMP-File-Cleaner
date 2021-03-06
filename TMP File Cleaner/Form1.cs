﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TMP_File_Cleaner
{
    public partial class Form1 : Form
    {
        long TempFilesSize = 0;

        public Form1()
        {
            InitializeComponent();
        }

        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            // Enumerate all the files
            long totalSize = dInfo.EnumerateFiles().Sum(file => file.Length);

            // If Subdirectories are to be included
            if (includeSubDir)
            {
                // Enumerate all sub-directories
                totalSize += dInfo.EnumerateDirectories().Sum(dir => DirectorySize(dir, true));
            }
            return totalSize;
        }

        static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };

            if (byteCount == 0)
            {
                return "0 " + suf[0];
            }

            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));

            double num = Math.Round(bytes / Math.Pow(1024, place), 1);

            return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
        }

        private void btn_CleanTmp_Click(object sender, EventArgs e)
        {
            TempFilesSize = 0;

            DialogResult dialogResult = MessageBox.Show("Clean all temporary files?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // --| This is basic "Temp" folder in every Windows Operating System!
                // --| Many users do not know that it contains temporary files that are stored in this folder in time, and can really fill your HDD space!
                // --| This folder can be accessed by typing "%temp%" or "%appdata%" into the search bar. Because is so tricky many users don't know about it!
                string szTemporaryFilesPath = Path.GetTempPath();

                var Dir = new DirectoryInfo(szTemporaryFilesPath);

                if (!Dir.Exists)
                {
                    MessageBox.Show("Welp... 'Temp' folder is missing somehow!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                foreach (DirectoryInfo dir in Dir.GetDirectories())
                {
                    try
                    {
                        TempFilesSize += DirectorySize(dir, true);
                        dir.Delete(true);
                    }
                    
                    catch (Exception)
                    {
                        // Ignore folders that are locked or being used.
                    }
                }

                foreach (FileInfo szFile in Dir.GetFiles())
                {
                    try
                    {
                        TempFilesSize += szFile.Length;
                        szFile.Delete();
                    }

                    catch (Exception)
                    {
                        // Ignore files that are locked or being used.
                    }
                       
                }

                MessageBox.Show("Temporary files have been deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TempFilesSize = 0;
                lbl_JunkSize.Text = "Temporary Junk: " + TempFilesSize + " KB";

            }

            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TempFilesSize = 0;

            btn_CleanTmp.TabStop = false;
            btn_CleanTmp.FlatStyle = FlatStyle.Flat;
            btn_CleanTmp.FlatAppearance.BorderSize = 0;
            btn_CleanTmp.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_CleanTmp.BackColor = Color.Fuchsia;

            string szTemporaryFilesPath = Path.GetTempPath();

            var Dir = new DirectoryInfo(szTemporaryFilesPath);

            if (!Dir.Exists)
            {
                MessageBox.Show("Welp... 'Temp' folder is missing somehow!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            foreach (DirectoryInfo dir in Dir.GetDirectories())
            {
                try
                {
                    TempFilesSize += DirectorySize(dir, true);
                }

                catch (Exception)
                {
                    // Ignore folders that are locked or being used.
                }
            }

            foreach (FileInfo szFile in Dir.GetFiles())
            {
                try
                {
                    TempFilesSize += szFile.Length;
                }

                catch (Exception)
                {
                    // Ignore files that are locked or being used.
                }
            }

            lbl_JunkSize.Text = "Temporary Junk: " + BytesToString(TempFilesSize);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_CleanTmp_MouseHover(object sender, EventArgs e)
        {
            btn_CleanTmp.BackColor = Color.Fuchsia;
        }

        private void btn_GoTo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tutyamxx/TMP-File-Cleaner");
        }
    }
}
