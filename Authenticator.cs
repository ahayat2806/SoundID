using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Authenticator : Form
    {
        public Authenticator()
        {
            InitializeComponent();
        }

        // Global parameters
        string support = "support@strix.uk";

        string GetLine(string text, int lineNo)
        {
            string[] lines = text.Replace("\r", "").Split('\n');
            return lines.Length >= lineNo ? lines[lineNo - 1] : null;
        }

        public void exception(string code)
        {
            if(code == "authFailed")
            {
                var popup = new Popup();
                string title = "SoundID - Authentication failed!";
                popup.Text = title;
                popup.title.Text = title;
                popup.message.Text = "Authentication was not successful, please try again!";
                popup.button1.ButtonText = "Ok";
                popup.button2.ButtonText = "Exit";
                popup.button1.Visible = true;
                popup.button2.Visible = true;
                popup.Show();
                title1.Text = title;
                soundFail();
            }

            if(code == "blacklisted")
            {
                var popup = new Popup();
                string title = "SoundID - You are blacklisted!";
                popup.Text = title;
                popup.title.Text = title;
                popup.message.Text = ("The key being used was blacklisted for violating" + Environment.NewLine + "SoundID ToS!" + Environment.NewLine + "If you believe this was wrong, please contact" + Environment.NewLine + support);
                popup.button1.ButtonText = "Ok";
                popup.button2.ButtonText = "Exit";
                popup.button1.Visible = false;
                popup.button2.Visible = true;
                popup.signOut.Visible = true;
                popup.Show();
                title1.Text = title;
                soundFail();
            }

            if(code == "newUser")
            {
                var popup = new Popup();
                string title = "SoundID - No config found!";
                popup.title.Text = title;
                popup.Text = title;
                popup.message.Text = "SoundID could not detect a previous key" + Environment.NewLine + "you may have logged out or are a new user." + Environment.NewLine + "Please log in.";
                popup.button1.ButtonText = "Ok";
                popup.button1.Visible = true;
                popup.button2.Visible = false;
                popup.Show();
                string title2 = "SoundID - Enter key";
                this.Text = title2;
                title1.Text = title2;
                enterkeyLabel.Visible = true;
                keyInput.Visible = true;
                submitKey.Visible = true;
                soundFail();
            }

            if(code == "failedAuth")
            {
                var popup = new Popup();
                string title = "SoundID - Authentication failed!";
                popup.title.Text = title;
                popup.Text = title;
                popup.message.Text = "The key entered was invalid." + Environment.NewLine + "Please try again and make sure that" + Environment.NewLine + "there are no spelling errors.";
                popup.button1.ButtonText = "Ok";
                popup.button1.Visible = true;
                popup.button2.Visible = false;
                popup.Show();
                soundFail();
            }
        }

        private void authenticate()
        {
            var popup = new Popup();
            string title = "SoundID - Authentication Success!";
            popup.Text = title;
            popup.title.Text = title;
            popup.message.Text = "Authentication has succeeded! Do not close Authenticator!";
            popup.button1.ButtonText = "Ok";
            popup.button1.Visible = true;
            popup.button2.Visible = false;
            popup.Show();
            title1.Text = title;
            soundSuccess();
            this.WindowState = FormWindowState.Minimized;

            // Log authentication (for anti-piracy/security)
            using (DcWebHook dcWeb = new DcWebHook())
            {
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                dcWeb.UserName = (Environment.UserName);
                dcWeb.WebHook = "https://discord.com/api/webhooks/827729130254368798/mCqNhSH_v6zep_cufWEI2decR8APaIsbD-ykWT-lAGe-rbei-JabIex8kCNamhViS358";
                dcWeb.SendMessage("Username: " + Environment.UserName + Environment.NewLine + "OS: " + Environment.OSVersion + Environment.NewLine + "Key: " + SoundID.Properties.Settings.Default.Key + Environment.NewLine + "IP: " + externalip);
            }
            var myForm = new SoundID.Main();
            myForm.Show();
            Hide();
        }

        public void soundSuccess()
        {
            SoundPlayer soundSuccess = new SoundPlayer(SoundID.Properties.Resources.auth);
            soundSuccess.Play();
        }

        public void soundFail()
        {
            SoundPlayer soundSuccess = new SoundPlayer(SoundID.Properties.Resources.no);
            soundSuccess.Play();
        }

        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        private void Authenticator_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SoundID.Properties.Settings.Default.Key))
            {
                exception("newUser");
            }
            else
            {
                string key = SoundID.Properties.Settings.Default.Key;
                string hashedKey = sha256(key).ToString();
                string pageContent = null;
                // Hashed Key URL (SHA256)
                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://strix.uk/keys/sid_keys.txt");
                HttpWebResponse myres = (HttpWebResponse)myReq.GetResponse();

                using (StreamReader sr = new StreamReader(myres.GetResponseStream()))
                {
                    pageContent = sr.ReadToEnd();
                    string GetLine(string text, int lineNo)
                    {
                        string[] lines = text.Replace("\r", "").Split('\n');
                        return lines.Length >= lineNo ? lines[lineNo - 1] : null;
                    }
                }

                if (pageContent.Contains(hashedKey))
                {
                    if(pageContent.Contains("blacklist"))
                    {
                        exception("blacklisted");
                    }
                    else
                    {
                        authenticate();
                    }
                }
                else
                {
                    exception("failedAuth");
                }
            }
        }

        private void submitKey_Click(object sender, EventArgs e)
        {
            string keySubmit = keyInput.Text;
            string pageContent = null;

            // Hashed Key URL (SHA256)

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://strix.uk/keys/sid_keys.txt");
            HttpWebResponse myres = (HttpWebResponse)myReq.GetResponse();

            using (StreamReader sr = new StreamReader(myres.GetResponseStream()))
            {
                pageContent = sr.ReadToEnd();
            }

            string blacklisted = (sha256(keySubmit) + " blacklist");

            if (pageContent.Contains(blacklisted))
            {
                exception("blacklisted");
                return;
            }

            if(pageContent.Contains(sha256(keySubmit)))
            {
                SoundID.Properties.Settings.Default.Key = keySubmit;
                SoundID.Properties.Settings.Default.Save();
                authenticate();
            }
            else
            {
                exception("authFailed");
            }
        }
    }
}
