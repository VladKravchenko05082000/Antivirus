namespace Antivirus
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_password_btn = new System.Windows.Forms.Panel();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.btn_lock = new System.Windows.Forms.Button();
            this.pb_pass = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_choose_fold_to_pass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_folder_sear = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sliderpanel = new System.Windows.Forms.Panel();
            this.panel_delete_btn = new System.Windows.Forms.Panel();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.deleteprogres = new System.Windows.Forms.ProgressBar();
            this.choose_todelete_btn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_delete = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel_scan_log_btn = new System.Windows.Forms.Panel();
            this.btn_show = new System.Windows.Forms.Button();
            this.tb_scanlog = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_write = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.panel_folder_scan = new System.Windows.Forms.Panel();
            this.btn_scan_folder = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lb_count = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_choose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_folder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scan_log_btn = new System.Windows.Forms.Button();
            this.scan_btn = new System.Windows.Forms.Button();
            this.delet_btn = new System.Windows.Forms.Button();
            this.password_folder_btn = new System.Windows.Forms.Button();
            this.folder_scan_btn = new System.Windows.Forms.Button();
            this.panel_scan_btn = new System.Windows.Forms.Panel();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_choose_file = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tbfilepath = new System.Windows.Forms.TextBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmd5 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.delete_timer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog_pass = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_password_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_delete_btn.SuspendLayout();
            this.panel_scan_log_btn.SuspendLayout();
            this.panel_folder_scan.SuspendLayout();
            this.panel_scan_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Scan);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 118);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(634, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Protect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete";
            // 
            // Scan
            // 
            this.Scan.AutoSize = true;
            this.Scan.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Scan.Location = new System.Drawing.Point(20, 9);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(117, 29);
            this.Scan.TabIndex = 3;
            this.Scan.Text = "Scan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(282, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel_password_btn
            // 
            this.panel_password_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_password_btn.Controls.Add(this.btn_unlock);
            this.panel_password_btn.Controls.Add(this.btn_lock);
            this.panel_password_btn.Controls.Add(this.pb_pass);
            this.panel_password_btn.Controls.Add(this.label18);
            this.panel_password_btn.Controls.Add(this.tb_pass);
            this.panel_password_btn.Controls.Add(this.label16);
            this.panel_password_btn.Controls.Add(this.btn_choose_fold_to_pass);
            this.panel_password_btn.Controls.Add(this.label4);
            this.panel_password_btn.Controls.Add(this.tb_folder_sear);
            this.panel_password_btn.Location = new System.Drawing.Point(197, 274);
            this.panel_password_btn.Name = "panel_password_btn";
            this.panel_password_btn.Size = new System.Drawing.Size(30, 23);
            this.panel_password_btn.TabIndex = 2;
            // 
            // btn_unlock
            // 
            this.btn_unlock.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_unlock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_unlock.FlatAppearance.BorderSize = 3;
            this.btn_unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unlock.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unlock.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_unlock.Location = new System.Drawing.Point(435, 263);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(128, 37);
            this.btn_unlock.TabIndex = 11;
            this.btn_unlock.Text = "Відкрити";
            this.btn_unlock.UseVisualStyleBackColor = false;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // btn_lock
            // 
            this.btn_lock.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_lock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_lock.FlatAppearance.BorderSize = 3;
            this.btn_lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lock.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lock.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_lock.Location = new System.Drawing.Point(152, 263);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(128, 37);
            this.btn_lock.TabIndex = 10;
            this.btn_lock.Text = "Закрити";
            this.btn_lock.UseVisualStyleBackColor = false;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // pb_pass
            // 
            this.pb_pass.Image = ((System.Drawing.Image)(resources.GetObject("pb_pass.Image")));
            this.pb_pass.Location = new System.Drawing.Point(295, 300);
            this.pb_pass.Name = "pb_pass";
            this.pb_pass.Size = new System.Drawing.Size(128, 128);
            this.pb_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_pass.TabIndex = 9;
            this.pb_pass.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(23, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(221, 22);
            this.label18.TabIndex = 8;
            this.label18.Text = "Пароль(максимум 12 знаків):";
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.Location = new System.Drawing.Point(242, 235);
            this.tb_pass.MaxLength = 12;
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(265, 20);
            this.tb_pass.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(127, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(408, 34);
            this.label16.TabIndex = 0;
            this.label16.Text = "Поставити пароль на папку";
            // 
            // btn_choose_fold_to_pass
            // 
            this.btn_choose_fold_to_pass.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_choose_fold_to_pass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_choose_fold_to_pass.FlatAppearance.BorderSize = 3;
            this.btn_choose_fold_to_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose_fold_to_pass.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose_fold_to_pass.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_choose_fold_to_pass.Location = new System.Drawing.Point(281, 163);
            this.btn_choose_fold_to_pass.Name = "btn_choose_fold_to_pass";
            this.btn_choose_fold_to_pass.Size = new System.Drawing.Size(148, 37);
            this.btn_choose_fold_to_pass.TabIndex = 6;
            this.btn_choose_fold_to_pass.Text = "Обрати папку";
            this.btn_choose_fold_to_pass.UseVisualStyleBackColor = false;
            this.btn_choose_fold_to_pass.Click += new System.EventHandler(this.btn_choose_fold_to_pass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(142, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Папка:";
            // 
            // tb_folder_sear
            // 
            this.tb_folder_sear.Location = new System.Drawing.Point(194, 129);
            this.tb_folder_sear.Name = "tb_folder_sear";
            this.tb_folder_sear.ReadOnly = true;
            this.tb_folder_sear.Size = new System.Drawing.Size(313, 20);
            this.tb_folder_sear.TabIndex = 0;
            this.tb_folder_sear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sliderpanel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.scan_log_btn);
            this.panel2.Controls.Add(this.scan_btn);
            this.panel2.Controls.Add(this.delet_btn);
            this.panel2.Controls.Add(this.password_folder_btn);
            this.panel2.Controls.Add(this.folder_scan_btn);
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 445);
            this.panel2.TabIndex = 1;
            // 
            // sliderpanel
            // 
            this.sliderpanel.Location = new System.Drawing.Point(-1, 2);
            this.sliderpanel.Name = "sliderpanel";
            this.sliderpanel.Size = new System.Drawing.Size(6, 64);
            this.sliderpanel.TabIndex = 2;
            // 
            // panel_delete_btn
            // 
            this.panel_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_delete_btn.Controls.Add(this.deleteLbl);
            this.panel_delete_btn.Controls.Add(this.label6);
            this.panel_delete_btn.Controls.Add(this.label21);
            this.panel_delete_btn.Controls.Add(this.deleteprogres);
            this.panel_delete_btn.Controls.Add(this.choose_todelete_btn);
            this.panel_delete_btn.Controls.Add(this.label19);
            this.panel_delete_btn.Controls.Add(this.tb_delete);
            this.panel_delete_btn.Controls.Add(this.label20);
            this.panel_delete_btn.Location = new System.Drawing.Point(187, 332);
            this.panel_delete_btn.Name = "panel_delete_btn";
            this.panel_delete_btn.Size = new System.Drawing.Size(30, 26);
            this.panel_delete_btn.TabIndex = 2;
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLbl.Location = new System.Drawing.Point(393, 320);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(53, 22);
            this.deleteLbl.TabIndex = 19;
            this.deleteLbl.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Статус видалення:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(25, 288);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 22);
            this.label21.TabIndex = 16;
            this.label21.Text = "Прогрес  видалення:";
            // 
            // deleteprogres
            // 
            this.deleteprogres.ForeColor = System.Drawing.Color.Lime;
            this.deleteprogres.Location = new System.Drawing.Point(184, 290);
            this.deleteprogres.Name = "deleteprogres";
            this.deleteprogres.Size = new System.Drawing.Size(313, 20);
            this.deleteprogres.TabIndex = 15;
            // 
            // choose_todelete_btn
            // 
            this.choose_todelete_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.choose_todelete_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.choose_todelete_btn.FlatAppearance.BorderSize = 3;
            this.choose_todelete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_todelete_btn.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_todelete_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.choose_todelete_btn.Location = new System.Drawing.Point(218, 199);
            this.choose_todelete_btn.Name = "choose_todelete_btn";
            this.choose_todelete_btn.Size = new System.Drawing.Size(244, 72);
            this.choose_todelete_btn.TabIndex = 14;
            this.choose_todelete_btn.Text = "Обрати файл на видалення";
            this.choose_todelete_btn.UseVisualStyleBackColor = false;
            this.choose_todelete_btn.Click += new System.EventHandler(this.choose_todelete_btn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(129, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 22);
            this.label19.TabIndex = 13;
            this.label19.Text = "Файл:";
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(184, 163);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.ReadOnly = true;
            this.tb_delete.Size = new System.Drawing.Size(313, 20);
            this.tb_delete.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(235, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(238, 34);
            this.label20.TabIndex = 11;
            this.label20.Text = "Видалити файл";
            // 
            // panel_scan_log_btn
            // 
            this.panel_scan_log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_scan_log_btn.Controls.Add(this.btn_show);
            this.panel_scan_log_btn.Controls.Add(this.tb_scanlog);
            this.panel_scan_log_btn.Controls.Add(this.label10);
            this.panel_scan_log_btn.Controls.Add(this.label7);
            this.panel_scan_log_btn.Controls.Add(this.btn_write);
            this.panel_scan_log_btn.Controls.Add(this.label22);
            this.panel_scan_log_btn.Location = new System.Drawing.Point(181, 400);
            this.panel_scan_log_btn.Name = "panel_scan_log_btn";
            this.panel_scan_log_btn.Size = new System.Drawing.Size(17, 20);
            this.panel_scan_log_btn.TabIndex = 2;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_show.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_show.FlatAppearance.BorderSize = 3;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_show.Location = new System.Drawing.Point(423, 369);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(148, 37);
            this.btn_show.TabIndex = 19;
            this.btn_show.Text = "Продивитись";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // tb_scanlog
            // 
            this.tb_scanlog.Location = new System.Drawing.Point(7, 170);
            this.tb_scanlog.Name = "tb_scanlog";
            this.tb_scanlog.ReadOnly = true;
            this.tb_scanlog.Size = new System.Drawing.Size(626, 153);
            this.tb_scanlog.TabIndex = 18;
            this.tb_scanlog.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(167, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Історія сканування за весь час";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Історія сканування за цю сессію";
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_write.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_write.FlatAppearance.BorderSize = 3;
            this.btn_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_write.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_write.Location = new System.Drawing.Point(91, 371);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(148, 37);
            this.btn_write.TabIndex = 15;
            this.btn_write.Text = "Записати";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(202, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(287, 34);
            this.label22.TabIndex = 13;
            this.label22.Text = "Історія сканування";
            // 
            // panel_folder_scan
            // 
            this.panel_folder_scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_folder_scan.Controls.Add(this.btn_scan_folder);
            this.panel_folder_scan.Controls.Add(this.listBox);
            this.panel_folder_scan.Controls.Add(this.lb_count);
            this.panel_folder_scan.Controls.Add(this.label12);
            this.panel_folder_scan.Controls.Add(this.btn_choose);
            this.panel_folder_scan.Controls.Add(this.label11);
            this.panel_folder_scan.Controls.Add(this.tb_folder);
            this.panel_folder_scan.Controls.Add(this.label9);
            this.panel_folder_scan.Location = new System.Drawing.Point(197, 204);
            this.panel_folder_scan.Name = "panel_folder_scan";
            this.panel_folder_scan.Size = new System.Drawing.Size(20, 20);
            this.panel_folder_scan.TabIndex = 2;
            // 
            // btn_scan_folder
            // 
            this.btn_scan_folder.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_scan_folder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_scan_folder.FlatAppearance.BorderSize = 3;
            this.btn_scan_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan_folder.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan_folder.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_scan_folder.Location = new System.Drawing.Point(172, 178);
            this.btn_scan_folder.Name = "btn_scan_folder";
            this.btn_scan_folder.Size = new System.Drawing.Size(137, 45);
            this.btn_scan_folder.TabIndex = 14;
            this.btn_scan_folder.Text = "Відсканувати";
            this.btn_scan_folder.UseVisualStyleBackColor = false;
            this.btn_scan_folder.Click += new System.EventHandler(this.btn_scan_folder_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(315, 85);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(319, 290);
            this.listBox.TabIndex = 13;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.Location = new System.Drawing.Point(121, 127);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(0, 22);
            this.lb_count.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Кол-во файлів:";
            // 
            // btn_choose
            // 
            this.btn_choose.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_choose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_choose.FlatAppearance.BorderSize = 3;
            this.btn_choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_choose.Location = new System.Drawing.Point(172, 116);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(137, 45);
            this.btn_choose.TabIndex = 8;
            this.btn_choose.Text = "Обрати папку";
            this.btn_choose.UseVisualStyleBackColor = false;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(3, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Папка:";
            // 
            // tb_folder
            // 
            this.tb_folder.Location = new System.Drawing.Point(54, 87);
            this.tb_folder.Name = "tb_folder";
            this.tb_folder.ReadOnly = true;
            this.tb_folder.Size = new System.Drawing.Size(255, 20);
            this.tb_folder.TabIndex = 3;
            this.tb_folder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(390, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Режим Сканування Папки";
            // 
            // scan_log_btn
            // 
            this.scan_log_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.scan_log_btn.FlatAppearance.BorderSize = 0;
            this.scan_log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scan_log_btn.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_log_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.scan_log_btn.Image = ((System.Drawing.Image)(resources.GetObject("scan_log_btn.Image")));
            this.scan_log_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scan_log_btn.Location = new System.Drawing.Point(-1, 255);
            this.scan_log_btn.Name = "scan_log_btn";
            this.scan_log_btn.Size = new System.Drawing.Size(161, 64);
            this.scan_log_btn.TabIndex = 6;
            this.scan_log_btn.Text = "Історія \r\nсканування";
            this.scan_log_btn.UseVisualStyleBackColor = false;
            this.scan_log_btn.Click += new System.EventHandler(this.scan_log_btn_Click);
            // 
            // scan_btn
            // 
            this.scan_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.scan_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scan_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scan_btn.FlatAppearance.BorderSize = 0;
            this.scan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scan_btn.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.scan_btn.Image = ((System.Drawing.Image)(resources.GetObject("scan_btn.Image")));
            this.scan_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scan_btn.Location = new System.Drawing.Point(0, -1);
            this.scan_btn.Name = "scan_btn";
            this.scan_btn.Size = new System.Drawing.Size(161, 64);
            this.scan_btn.TabIndex = 2;
            this.scan_btn.Text = "Сканування";
            this.scan_btn.UseVisualStyleBackColor = false;
            this.scan_btn.Click += new System.EventHandler(this.scan_btn_Click);
            // 
            // delet_btn
            // 
            this.delet_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.delet_btn.FlatAppearance.BorderSize = 0;
            this.delet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delet_btn.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delet_btn.Image = ((System.Drawing.Image)(resources.GetObject("delet_btn.Image")));
            this.delet_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delet_btn.Location = new System.Drawing.Point(0, 191);
            this.delet_btn.Name = "delet_btn";
            this.delet_btn.Size = new System.Drawing.Size(160, 64);
            this.delet_btn.TabIndex = 5;
            this.delet_btn.Text = "Видалити \r\nвірус";
            this.delet_btn.UseVisualStyleBackColor = false;
            this.delet_btn.Click += new System.EventHandler(this.delet_btn_Click);
            // 
            // password_folder_btn
            // 
            this.password_folder_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.password_folder_btn.FlatAppearance.BorderSize = 0;
            this.password_folder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_folder_btn.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_folder_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.password_folder_btn.Image = ((System.Drawing.Image)(resources.GetObject("password_folder_btn.Image")));
            this.password_folder_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.password_folder_btn.Location = new System.Drawing.Point(0, 127);
            this.password_folder_btn.Name = "password_folder_btn";
            this.password_folder_btn.Size = new System.Drawing.Size(161, 64);
            this.password_folder_btn.TabIndex = 4;
            this.password_folder_btn.Text = "Пароль на \r\nпапку";
            this.password_folder_btn.UseVisualStyleBackColor = false;
            this.password_folder_btn.Click += new System.EventHandler(this.password_folder_btn_Click);
            // 
            // folder_scan_btn
            // 
            this.folder_scan_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.folder_scan_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.folder_scan_btn.FlatAppearance.BorderSize = 0;
            this.folder_scan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folder_scan_btn.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder_scan_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.folder_scan_btn.Image = ((System.Drawing.Image)(resources.GetObject("folder_scan_btn.Image")));
            this.folder_scan_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.folder_scan_btn.Location = new System.Drawing.Point(0, 63);
            this.folder_scan_btn.Name = "folder_scan_btn";
            this.folder_scan_btn.Size = new System.Drawing.Size(161, 64);
            this.folder_scan_btn.TabIndex = 3;
            this.folder_scan_btn.Text = "Сканування \r\nпапки";
            this.folder_scan_btn.UseVisualStyleBackColor = false;
            this.folder_scan_btn.Click += new System.EventHandler(this.folder_scan_btn_Click);
            // 
            // panel_scan_btn
            // 
            this.panel_scan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_scan_btn.Controls.Add(this.lb_status);
            this.panel_scan_btn.Controls.Add(this.btn_choose_file);
            this.panel_scan_btn.Controls.Add(this.label17);
            this.panel_scan_btn.Controls.Add(this.tbfilepath);
            this.panel_scan_btn.Controls.Add(this.btn_scan);
            this.panel_scan_btn.Controls.Add(this.label8);
            this.panel_scan_btn.Controls.Add(this.label);
            this.panel_scan_btn.Controls.Add(this.label5);
            this.panel_scan_btn.Controls.Add(this.tbmd5);
            this.panel_scan_btn.Location = new System.Drawing.Point(168, 142);
            this.panel_scan_btn.Name = "panel_scan_btn";
            this.panel_scan_btn.Size = new System.Drawing.Size(30, 25);
            this.panel_scan_btn.TabIndex = 2;
            this.panel_scan_btn.Visible = false;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_status.Location = new System.Drawing.Point(274, 275);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(55, 22);
            this.lb_status.TabIndex = 12;
            this.lb_status.Text = "N/A ";
            // 
            // btn_choose_file
            // 
            this.btn_choose_file.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_choose_file.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_choose_file.FlatAppearance.BorderSize = 2;
            this.btn_choose_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose_file.Font = new System.Drawing.Font("High Tower Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose_file.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_choose_file.Location = new System.Drawing.Point(516, 148);
            this.btn_choose_file.Name = "btn_choose_file";
            this.btn_choose_file.Size = new System.Drawing.Size(109, 25);
            this.btn_choose_file.TabIndex = 11;
            this.btn_choose_file.Text = "Обрати файл";
            this.btn_choose_file.UseVisualStyleBackColor = false;
            this.btn_choose_file.Click += new System.EventHandler(this.btn_choose_file_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(146, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 22);
            this.label17.TabIndex = 10;
            this.label17.Text = "Файл:";
            // 
            // tbfilepath
            // 
            this.tbfilepath.Location = new System.Drawing.Point(201, 151);
            this.tbfilepath.Name = "tbfilepath";
            this.tbfilepath.ReadOnly = true;
            this.tbfilepath.Size = new System.Drawing.Size(313, 20);
            this.tbfilepath.TabIndex = 9;
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_scan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_scan.FlatAppearance.BorderSize = 3;
            this.btn_scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_scan.Location = new System.Drawing.Point(438, 258);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(130, 46);
            this.btn_scan.TabIndex = 8;
            this.btn_scan.Text = "Сканувати";
            this.btn_scan.UseVisualStyleBackColor = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "Режим Сканування";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(163, 275);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 22);
            this.label.TabIndex = 4;
            this.label.Text = "Статус файлу : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(106, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Хеш файлу:";
            // 
            // tbmd5
            // 
            this.tbmd5.Location = new System.Drawing.Point(201, 204);
            this.tbmd5.Name = "tbmd5";
            this.tbmd5.ReadOnly = true;
            this.tbmd5.Size = new System.Drawing.Size(313, 20);
            this.tbmd5.TabIndex = 1;
            // 
            // delete_timer
            // 
            this.delete_timer.Tick += new System.EventHandler(this.delete_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.panel_scan_btn);
            this.Controls.Add(this.panel_scan_log_btn);
            this.Controls.Add(this.panel_delete_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_password_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_folder_scan);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_password_btn.ResumeLayout(false);
            this.panel_password_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_delete_btn.ResumeLayout(false);
            this.panel_delete_btn.PerformLayout();
            this.panel_scan_log_btn.ResumeLayout(false);
            this.panel_scan_log_btn.PerformLayout();
            this.panel_folder_scan.ResumeLayout(false);
            this.panel_folder_scan.PerformLayout();
            this.panel_scan_btn.ResumeLayout(false);
            this.panel_scan_btn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button scan_btn;
        private System.Windows.Forms.Button scan_log_btn;
        private System.Windows.Forms.Button delet_btn;
        private System.Windows.Forms.Button password_folder_btn;
        private System.Windows.Forms.Button folder_scan_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel sliderpanel;
        private System.Windows.Forms.Label Scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmd5;
        private System.Windows.Forms.TextBox tb_folder_sear;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel_scan_btn;
        private System.Windows.Forms.Panel panel_folder_scan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.Panel panel_password_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbfilepath;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.PictureBox pb_pass;
        private System.Windows.Forms.Button btn_lock;
        private System.Windows.Forms.Panel panel_delete_btn;
        private System.Windows.Forms.Button choose_todelete_btn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_delete;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar deleteprogres;
        private System.Windows.Forms.Panel panel_scan_log_btn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_choose_file;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_scan_folder;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Timer delete_timer;
        private System.Windows.Forms.Label deleteLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_pass;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.Button btn_choose_fold_to_pass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.RichTextBox tb_scanlog;
        private System.Windows.Forms.Button btn_show;
    }
}

