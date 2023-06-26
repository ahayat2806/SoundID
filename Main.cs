using Spectrogram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SoundID
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Global parameters
        string file1path;
        string file2path;
        string output;
        string blank = "";
        string br = Environment.NewLine;
        int progress;
        int similarity;
        int yes = 1;
        int no = -1;
        string encoded1;
        string encoded2;

        public int similar(int difference)
        {
            similarity = difference + similarity;
            return difference;
        }

        public void progressUpdate()
        {
            progress++;
            progressBar.Value = progress;
        }

        public void exception(string code)
        {
            if(code == "nofile")
            {
                var popup = new Popup();
                string title = "SoundID - No file picked!";
                popup.Text = title;
                popup.title.Text = title;
                popup.message.Text = "You have not selected a file!";
                popup.button1.ButtonText = "Ok";
                popup.button1.Visible = true;
                popup.button2.Visible = false;
                popup.Show();
            }

            if(code == "keyReset")
            {
                var popup = new Popup();
                string title = "SoundID - Signed out";
                popup.Text = title;
                popup.title.Text = title;
                popup.message.Text = ("You have signed out." + br + "Click 'Ok' to restart SoundID");
                popup.button1.ButtonText = "Ok";
                popup.button1.Visible = true;
                popup.button2.Visible = false;
                popup.Show();
            }

            if(code == "encoded1")
            {
                var popup = new Popup();
                string title = "SoundID - File 1 Encoded Data";
                popup.Text = title;
                popup.title.Text = title;
                popup.message.Text = (encoded1);
                popup.button1.ButtonText = "Ok";
                popup.button1.Visible = true;
                popup.button2.Visible = false;
                popup.Show();
            }
        }

        // Analysis algorithm

        public void analyse()
        {

            // Clear output box

            outputBox.Text = "Generating analysis...";

            // Check hash to see if 100% same (repackaged)

            string file1Hash = GetChecksum(file1path);
            progressUpdate();
            string file2Hash = GetChecksum(file2path);
            progressUpdate();
            if (file1Hash == file2Hash)
            {
                // If file is 100% equal do

                string hashCheck = "File is 100% equal (Hash: " + file1Hash + " is the same for both files.";
                progressUpdate();
                similar(yes);
            }
            else
            {
                // If not do this

                string hashCheck = "File is not 100% equal (" + file1path + " hash (" + file1Hash + ") is not the same as " + file2path + " hash (" + file2Hash;
                progressUpdate();
                similar(no);
            }

            // Check file length

            int file1length = SoundInfo.GetSoundLength(file1path);
            progressUpdate();
            int file2length = SoundInfo.GetSoundLength(file2path);
            progressUpdate();

            if (file1length == file2length)
            {
                string soundLength = ("Sound length is equal (Sound Length: " + file1length);
                progressUpdate();
                similar(yes);
            }
            else
            {
                string soundLength = ("Sound length is not equal (File 1 Sound Length: " + file1length + ", File 2 Sound Length: " + file2length);
                progressUpdate();
                similar(no);
            }

            // Check encoded data



        }

        // File hashing method

        public static string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

            // Deletes saved key and restarts application

            private void button1_Click(object sender, EventArgs e)
            {
                SoundID.Properties.Settings.Default.Key = "";
                SoundID.Properties.Settings.Default.Save();
                exception("keyReset");
                Application.Restart();
                Environment.Exit(0);
            }

            // Select file 1

            public void file1_Click(object sender, EventArgs e)
            {
                openFileDialog1.ShowDialog();
                this.openFileDialog1.Multiselect = false;
                foreach (String file in openFileDialog1.FileNames)
                {
                    file1path = file;
                    string file1 = file;
                    file1name.Text = file;
                }
            }

            // Close application

            private void close_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            // Select file 2

            private void file2button_Click(object sender, EventArgs e)
            {
                openFileDialog1.ShowDialog();
                this.openFileDialog1.Multiselect = false;
                foreach (String file in openFileDialog1.FileNames)
                {
                    file2path = file;
                    string file2 = file;
                    file2name.Text = file;
                }
            }

            // Start analysis algorithm

            private void analyseButton_Click(object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty(file1path))
            {
                exception("nofile");
                return;
            }

            if (string.IsNullOrEmpty(file2path))
            {
                exception("nofile");
                return;
            }

            analyse();
        }

            private void Main_Load(object sender, EventArgs e)
            {
                
            }
        }
    }
