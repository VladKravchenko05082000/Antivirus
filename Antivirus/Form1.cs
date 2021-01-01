using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace Antivirus
{

    public partial class Form1 : Form
    {
        int virus;
        
        public Form1()
        {
            
            InitializeComponent();
            panel_scan_btn.Visible = true;
            panel_folder_scan.Visible = false;
            panel_password_btn.Visible = false;
            panel_delete_btn.Visible = false;
            panel_scan_log_btn.Visible = false;

            panel_scan_btn.Height = 445;
            panel_scan_btn.Width = 644;

            panel_folder_scan.Height = 445;
            panel_folder_scan.Width = 644;

            panel_password_btn.Height = 445;
            panel_password_btn.Width = 644;

            panel_delete_btn.Height = 445;
            panel_delete_btn.Width = 644;

            panel_scan_log_btn.Height = 445;
            panel_scan_log_btn.Width = 644;

        }

        public string GetMD5FromFile(string filenPath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }
        private void folder_scan_btn_Click(object sender, EventArgs e)
        {
            movesliderpanel(folder_scan_btn);
            panel_scan_btn.Visible = false;
            panel_password_btn.Visible = false;
            panel_delete_btn.Visible = false;
            panel_scan_log_btn.Visible = false;
            panel_folder_scan.Visible = true;
            panel_folder_scan.Location = new Point(161, 118);
        }
        private void movesliderpanel(Control btn)
        {
            sliderpanel.Top = btn.Top;
            sliderpanel.Height = btn.Height;
        }

        private void scan_btn_Click(object sender, EventArgs e)
        {
            movesliderpanel(scan_btn);
            panel_folder_scan.Visible = false;
            panel_password_btn.Visible = false;
            panel_delete_btn.Visible = false;
            panel_scan_log_btn.Visible = false;
            panel_scan_btn.Visible = true;

        }

        private void password_folder_btn_Click(object sender, EventArgs e)
        {
            movesliderpanel(password_folder_btn);
            panel_scan_btn.Visible = false;
            panel_folder_scan.Visible = false;
            panel_delete_btn.Visible = false;
            panel_scan_log_btn.Visible = false;
            panel_password_btn.Visible = true;
            panel_password_btn.Location = new Point(161, 118);
        }

        private void delet_btn_Click(object sender, EventArgs e)
        {
            movesliderpanel(delet_btn);
            panel_scan_btn.Visible = false;
            panel_folder_scan.Visible = false;
            panel_password_btn.Visible = false;
            panel_scan_log_btn.Visible = false;
            panel_delete_btn.Visible = true;
            panel_delete_btn.Location = new Point(161, 118);
        }

        private void scan_log_btn_Click(object sender, EventArgs e)
        {
            movesliderpanel(scan_log_btn);
            panel_scan_btn.Visible = false;
            panel_folder_scan.Visible = false;
            panel_password_btn.Visible = false;
            panel_delete_btn.Visible = false;
            panel_scan_log_btn.Visible = true;
            panel_scan_log_btn.Location = new Point(161, 118);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_scan_btn.Location = new Point(161, 118);

        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            var md5signature = File.ReadAllLines("MD5Base.txt");
            var coincidences = File.ReadAllLines("coincidences.txt");
            string line = "Хеш файлу: " + Environment.NewLine+tbmd5.Text ;
            System.IO.File.WriteAllText("coincidences.txt", line);
            if (coincidences.Contains(tbmd5.Text))
            {
                MessageBox.Show("Знайдений схожий за своєю структурою файл.Советуем видалити його для оптимізації місця.");
                
            }




            if (md5signature.Contains(tbmd5.Text))
            {
                lb_status.Text = "Файл інфікований ";
                lb_status.ForeColor = Color.Red;
                tb_scanlog.Text += " " + lb_status.Text + "Дата та час: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine;

            }
            else
            {
                lb_status.Text = "Файл чист ";
                lb_status.ForeColor = Color.LimeGreen;
                tb_scanlog.Text += " " + lb_status.Text + "Дата та час: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine;
            }
        }

        private void btn_choose_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbfilepath.Text = ofd.FileName;
                tbmd5.Text = GetMD5FromFile(ofd.FileName);
                tb_scanlog.Text += "||Режим сканування файлу: Файл: \n" + tbfilepath.Text + " Хеш файлу:  " + tbmd5.Text;
            }
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            tb_folder.Text = folderBrowserDialog.SelectedPath;
            virus = 0;
            lb_count.Text += virus.ToString();
            tb_scanlog.Text += "\n ||Режим сканування папки: Папка: " + tb_folder.Text;
            listBox.Items.Clear();
        }

        private void btn_scan_folder_Click(object sender, EventArgs e)
        {
            List<string> search = Directory.GetFiles(@folderBrowserDialog.SelectedPath, "*.*").ToList();
            var md5signature1 = File.ReadAllLines("MD5Base.txt");
            foreach (string item in search)
            {
                var s = GetMD5FromFile(item);
                if (md5signature1.Contains(s))
                {
                    lb_count.Text = null;
                    virus += 1;
                    lb_count.Text = virus.ToString();
                    listBox.Items.Add(item);
                    tb_scanlog.Text += "\n Кількість вірусів: " + lb_count.Text + "Вірусні файли: " + item + "Дата та час: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine;

                }

            }
        }

        private void choose_todelete_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();

            if (path.ShowDialog() == DialogResult.OK)
            {
                tb_delete.Text = path.FileName;
                delete_timer.Start();
                tb_scanlog.Text += "|| Режим видалення файлу: " + "Було видалено файл- " + path.FileName + "Дата та час: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine;
                File.Delete(path.FileName);



            }
        }

        private void delete_timer_Tick(object sender, EventArgs e)
        {
            delete_timer.Interval = 10;
            if (deleteprogres.Value >= deleteprogres.Maximum)
            {
                deleteLbl.Text = "Успішно видалено";
                deleteLbl.ForeColor = Color.Green;
                delete_timer.Stop();
            }
            else
            {
                deleteprogres.Value += 10;
            }
        }

        private void btn_choose_fold_to_pass_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_pass.ShowDialog() == DialogResult.OK)
            {
                tb_folder_sear.Text = folderBrowserDialog_pass.SelectedPath;
                tb_scanlog.Text += "\n ||Режим захисту папки: Папка: " + tb_folder_sear.Text + Environment.NewLine;
            }
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            var pass1 = File.ReadAllLines("pass.txt");
            if (pass1.Contains(tb_pass.Text))
            {
                try
                {

                    string folderPath = tb_folder_sear.Text;
                    string adminUserName = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("Locked");
                    tb_scanlog.Text += "\n ||Режим доступу: " + folderBrowserDialog_pass.SelectedPath + "Закрито " + "Дата та час: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine;
                    pb_pass.Image = Properties.Resources.unlock_fold1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Не вірний пароль");
            }
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            var pass2 = File.ReadAllLines("pass.txt");
            if (pass2.Contains(tb_pass.Text))
            {
                try
                {

                    string folderPath = tb_folder_sear.Text;
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("UnLocked");
                    tb_scanlog.Text += "\n ||Режим доступу: " + folderBrowserDialog_pass.SelectedPath + "Відкрито " + "Дата та час: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine;
                    pb_pass.Image = Properties.Resources.lock_fold1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Не вірний пароль");
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            string lines = "Дата та час сессій: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + Environment.NewLine + tb_scanlog.Text;
            System.IO.File.AppendAllText("scan_log.txt", lines);


        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string fpath = "scan_log";
            Process proc = Process.Start("notepad.exe", fpath);
            proc.WaitForExit();
            proc.Close();
        }


    }
}
