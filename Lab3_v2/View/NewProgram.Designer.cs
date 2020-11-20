namespace Lab3_v2
{
    partial class NewProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_OC = new System.Windows.Forms.ComboBox();
            this.tb_producer = new System.Windows.Forms.TextBox();
            this.cb_version = new System.Windows.Forms.ComboBox();
            this.rb_512 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_8 = new System.Windows.Forms.RadioButton();
            this.rb_16 = new System.Windows.Forms.RadioButton();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.spin_cpu = new System.Windows.Forms.NumericUpDown();
            this.spin_hdd = new System.Windows.Forms.NumericUpDown();
            this.b_save = new System.Windows.Forms.Button();
            this.gb_ram = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spin_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_hdd)).BeginInit();
            this.gb_ram.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type OC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Install date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "HDD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "GHz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gb";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(102, 16);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(157, 20);
            this.tb_name.TabIndex = 1;
            // 
            // cb_OC
            // 
            this.cb_OC.FormattingEnabled = true;
            this.cb_OC.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "MacOC"});
            this.cb_OC.Location = new System.Drawing.Point(102, 41);
            this.cb_OC.Name = "cb_OC";
            this.cb_OC.Size = new System.Drawing.Size(157, 21);
            this.cb_OC.TabIndex = 2;
            // 
            // tb_producer
            // 
            this.tb_producer.Location = new System.Drawing.Point(102, 68);
            this.tb_producer.Name = "tb_producer";
            this.tb_producer.Size = new System.Drawing.Size(157, 20);
            this.tb_producer.TabIndex = 3;
            // 
            // cb_version
            // 
            this.cb_version.FormattingEnabled = true;
            this.cb_version.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_version.Location = new System.Drawing.Point(102, 123);
            this.cb_version.Name = "cb_version";
            this.cb_version.Size = new System.Drawing.Size(156, 21);
            this.cb_version.TabIndex = 5;
            // 
            // rb_512
            // 
            this.rb_512.AutoSize = true;
            this.rb_512.Checked = true;
            this.rb_512.Location = new System.Drawing.Point(42, 19);
            this.rb_512.Name = "rb_512";
            this.rb_512.Size = new System.Drawing.Size(61, 17);
            this.rb_512.TabIndex = 6;
            this.rb_512.TabStop = true;
            this.rb_512.Text = "512 Mb";
            this.rb_512.UseVisualStyleBackColor = true;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(109, 19);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(48, 17);
            this.rb_1.TabIndex = 7;
            this.rb_1.Text = "1 Gb";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(163, 19);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(48, 17);
            this.rb_2.TabIndex = 8;
            this.rb_2.Text = "2 Gb";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(42, 42);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(48, 17);
            this.rb_4.TabIndex = 9;
            this.rb_4.Text = "4 Gb";
            this.rb_4.UseVisualStyleBackColor = true;
            // 
            // rb_8
            // 
            this.rb_8.AutoSize = true;
            this.rb_8.Location = new System.Drawing.Point(96, 42);
            this.rb_8.Name = "rb_8";
            this.rb_8.Size = new System.Drawing.Size(48, 17);
            this.rb_8.TabIndex = 10;
            this.rb_8.Text = "8 Gb";
            this.rb_8.UseVisualStyleBackColor = true;
            // 
            // rb_16
            // 
            this.rb_16.AutoSize = true;
            this.rb_16.Location = new System.Drawing.Point(157, 42);
            this.rb_16.Name = "rb_16";
            this.rb_16.Size = new System.Drawing.Size(54, 17);
            this.rb_16.TabIndex = 11;
            this.rb_16.Text = "16 Gb";
            this.rb_16.UseVisualStyleBackColor = true;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(102, 94);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(156, 20);
            this.dt.TabIndex = 4;
            // 
            // spin_cpu
            // 
            this.spin_cpu.DecimalPlaces = 2;
            this.spin_cpu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spin_cpu.Location = new System.Drawing.Point(102, 270);
            this.spin_cpu.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            65536});
            this.spin_cpu.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.spin_cpu.Name = "spin_cpu";
            this.spin_cpu.Size = new System.Drawing.Size(48, 20);
            this.spin_cpu.TabIndex = 12;
            this.spin_cpu.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // spin_hdd
            // 
            this.spin_hdd.Location = new System.Drawing.Point(102, 303);
            this.spin_hdd.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.spin_hdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_hdd.Name = "spin_hdd";
            this.spin_hdd.Size = new System.Drawing.Size(48, 20);
            this.spin_hdd.TabIndex = 13;
            this.spin_hdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(190, 280);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(69, 30);
            this.b_save.TabIndex = 14;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.save_program);
            // 
            // gb_ram
            // 
            this.gb_ram.Controls.Add(this.rb_16);
            this.gb_ram.Controls.Add(this.rb_8);
            this.gb_ram.Controls.Add(this.rb_4);
            this.gb_ram.Controls.Add(this.rb_2);
            this.gb_ram.Controls.Add(this.rb_1);
            this.gb_ram.Controls.Add(this.rb_512);
            this.gb_ram.Location = new System.Drawing.Point(25, 172);
            this.gb_ram.Name = "gb_ram";
            this.gb_ram.Size = new System.Drawing.Size(233, 77);
            this.gb_ram.TabIndex = 15;
            this.gb_ram.TabStop = false;
            this.gb_ram.Text = "RAM";
            // 
            // NewProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.gb_ram);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.spin_hdd);
            this.Controls.Add(this.spin_cpu);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.cb_version);
            this.Controls.Add(this.tb_producer);
            this.Controls.Add(this.cb_OC);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProgram";
            this.Text = "New Program";
            ((System.ComponentModel.ISupportInitialize)(this.spin_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_hdd)).EndInit();
            this.gb_ram.ResumeLayout(false);
            this.gb_ram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.ComboBox cb_OC;
        public System.Windows.Forms.TextBox tb_producer;
        public System.Windows.Forms.ComboBox cb_version;
        public System.Windows.Forms.RadioButton rb_512;
        public System.Windows.Forms.RadioButton rb_1;
        public System.Windows.Forms.RadioButton rb_2;
        public System.Windows.Forms.RadioButton rb_4;
        public System.Windows.Forms.RadioButton rb_8;
        public System.Windows.Forms.RadioButton rb_16;
        public System.Windows.Forms.DateTimePicker dt;
        public System.Windows.Forms.NumericUpDown spin_cpu;
        public System.Windows.Forms.NumericUpDown spin_hdd;
        public System.Windows.Forms.GroupBox gb_ram;
        public System.Windows.Forms.Button b_save;
    }
}