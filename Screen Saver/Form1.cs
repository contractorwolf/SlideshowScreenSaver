using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Threading;


namespace Screen_Saver
{
    public partial class Form1 : Form
    {
        private string[] imageFiles = new string[0];
        private int _current = 0;

        private string[] adFiles = new string[0];
        private int _currentAd = 0;


        private RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private string location_name = "gc";
        private int adsPer = 10;
        private int imageCount = 0;




        public Form1()
        {
            InitializeComponent();

        }

        //***************Image Flip Process*****************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpdatingImage();
            LoadImages();

            StartTimers();
            HideInterface();
            incrementImages();

        }
        private void timerImageFlip_Tick(object sender, EventArgs e)
        {


incrementImages();


        }

        //increments image counter for imageFiles array
        private void incrementImages()
        {
            if (imageCount % adsPer == 0)
            {
                displayAd();
            }
            else
            {
                displayImage();
            }

            imageCount++;

        }

        //displays current image from imageFiles array
        private void displayImage()
        {

                if (_current < imageFiles.Length)
                {
                    try
                    {
                        //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Displayed Image: " + imageFiles[_current]);
                        pictureBox1.ImageLocation = imageFiles[_current];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured:" + ex.Message);
                    }
                }
                else
                {
                    _current = 0;

                    pictureBox1.ImageLocation = imageFiles[_current];
                }
                _current++;


        }

        //displays current image from imageFiles array
        private void displayAd()
        {

                if (_currentAd < adFiles.Length)
                {
                    try
                    {
                        pictureBox1.ImageLocation = adFiles[_currentAd];
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error Occured:" + ex.Message);
                    }
                }
                else
                {
                    _currentAd = 0;

                }
                _currentAd++;     

       
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            ShowInterface();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Closed");
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            HideInterface();
        }

        private void ShowInterface()
        {
            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Show Interface Called");
            exitButton.Visible = true;
            continueButton.Visible = true;
            addRegButton.Visible = true;
            removeRegButton.Visible = true;
            version.Visible = true;

      
            Cursor.Show();
        }

        private void HideInterface()
        {
            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Hide Interface Called");
            exitButton.Visible = false;
            continueButton.Visible = false;
            addRegButton.Visible = false;
            removeRegButton.Visible = false;
            version.Visible = false;

            StartTimers();            
            Cursor.Hide();
        }

        private void addRegButton_Click(object sender, EventArgs e)
        {
            rkApp.SetValue("Wolf Auto Screen", Application.ExecutablePath.ToString());
            MessageBox.Show("Registry edits ADDED");
        }

        private void removeRegButton_Click(object sender, EventArgs e)
        {
            rkApp.DeleteValue("Wolf Auto Screen", false);
            MessageBox.Show("Registry edits REMOVED");
        }

        private void SetUpdatingImage()
        {
            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "SetUpdatingImage Called");
            pictureBox1.ImageLocation = @"C:\images\" + location_name + @"\system\updating.jpg";
        }

        private void LoadImagesArrayFromFoldername(string foldername)
        {
            imageFiles = Directory.GetFiles(foldername, "*.jpg");
            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Load Images Called, total: " + imageFiles.Length);
        }
        private void LoadAdsArrayFromFoldername(string foldername)
        {
            adFiles = Directory.GetFiles(foldername, "*.jpg");
            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Load Ads Called, total: " + adFiles.Length);
        }

        private void LoadImages()
        {
            LoadImagesArrayFromFoldername(@"C:\images\" + location_name + @"\images");
            LoadAdsArrayFromFoldername(@"C:\images\" + location_name + @"\ads");
            imageCount = 0;
        }

        private void StartTimers()
        {
            timerImageFlip.Enabled = true;

            //ProcessDebug.PrintLine(ProcessDebug.DebugType.File, debugFile1, "Start Timers");

        }





        //******************Download Image Process*********************************
       
    }
}