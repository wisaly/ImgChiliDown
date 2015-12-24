using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace imgChiliDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            var albumurls = editAlbums.Text.Split(
                new string[]{Environment.NewLine},100, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (albumurls.Count == 100)
            {
                editLog.Text += "最大支持100个album" + Environment.NewLine;
            }

            WebClient client = new WebClient();

            if (editProxy.Text.Length > 0)
            {
                WebProxy proxy = new WebProxy(editProxy.Text);
                proxy.Credentials = CredentialCache.DefaultCredentials;
                client.Proxy = proxy;
            }

            int downcount = 0;
            foreach (string albumurl in albumurls)
            {
                string albumname = albumurl.Substring(albumurl.LastIndexOf('/') + 1);
                string localalbum = editLocal.Text + "\\" + albumname;
                try
                {
                    Directory.CreateDirectory(localalbum);
                }
                catch (Exception )
                {
                    editLog.Text += "无法创建本地文件夹:" + localalbum + Environment.NewLine;
                }

                string albumcontent = client.DownloadString(albumurl);

                Regex regalbum = new Regex(@"show\/.*?\.jpg");
                MatchCollection albumpics = regalbum.Matches(albumcontent);

                if (albumpics.Count == 0)
                {
                    editLog.Text += "无法解析相册中的图片:" + albumurl + Environment.NewLine;
                    continue;
                }

                // 去重
                HashSet<string> picurls = new HashSet<string>();
                foreach (var pic in albumpics)
                {
                    string s = "http://imgchili.net/" + pic.ToString();
                    if (picurls.Contains(s))
                    {
                        continue;
                    }

                    picurls.Add(s);
                }

                foreach (var picurl in picurls)
                {
                    string piccontent = client.DownloadString(picurl);

                    Application.DoEvents();

                    Regex regexpic = new Regex("show_image.*\n.*src=\"(.*?\\.jpg)\"", RegexOptions.Multiline);
                    var matches = regexpic.Matches(piccontent);
                    if (matches.Count == 0)
                    {
                        editLog.Text += "无法解析图片下载地址:" + picurl + Environment.NewLine;
                        continue;
                    }
                    if (matches.Count > 1)
                    {
                        editLog.Text += "匹配到多个图片下载地址，将仅下载第一个文件:" + picurl + Environment.NewLine;
                    }
                    string imageurl = matches[0].Groups[1].ToString();

                    labelCurrent.Text = "正在下载:" + imageurl;

                    Application.DoEvents();

                    string imagename = imageurl.Substring(imageurl.LastIndexOf('/') + 1);

                    string filename = localalbum + "\\" + imagename;
                    try
                    {
                        client.DownloadFile(imageurl, filename);
                    }
                    catch(Exception exp)
                    {
                        editLog.Text += "图片下载失败:" + exp.Message + ":" + imageurl + Environment.NewLine;
                    }

                    if (!File.Exists(filename))
                    {
                        editLog.Text += "图片下载失败:" + imageurl + Environment.NewLine;
                        continue;
                    }
                    downcount++;
                    Console.WriteLine(imageurl);
                }
            }
            labelCurrent.Text = "";
            MessageBox.Show(string.Format("下载完成{0}个文件",downcount));
            button1.Enabled = true;
        }
    }
}
