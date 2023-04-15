namespace MK_K
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mKBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mK_BDDataSet = new MK_K.MK_BDDataSet();
            this.databaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AppointmentDate1 = new System.Windows.Forms.TextBox();
            this.Medical_history1 = new System.Windows.Forms.TextBox();
            this.The_reason_for_appointment1 = new System.Windows.Forms.TextBox();
            this.Doctor_who_needs_appointment1 = new System.Windows.Forms.TextBox();
            this.Date_birth1 = new System.Windows.Forms.TextBox();
            this.Surname1 = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.AppointmentDate = new System.Windows.Forms.TextBox();
            this.Medical_history = new System.Windows.Forms.TextBox();
            this.The_reason_for_appointment = new System.Windows.Forms.TextBox();
            this.Doctor_who_needs_appointment = new System.Windows.Forms.TextBox();
            this.Date_birth = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.data_baseTableAdapter = new MK_K.MK_BDDataSetTableAdapters.Data_baseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mK_BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataGridView1.DataSource = this.databaseBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1149, 161);
            this.dataGridView1.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_Patient";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_Patient";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn11.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Date_birth";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date_birth";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Appointment_date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Appointment_date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Doctor_who_needs_appointment";
            this.dataGridViewTextBoxColumn14.HeaderText = "Doctor_who_needs_appointment";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 200;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "The_reason_for_appointment";
            this.dataGridViewTextBoxColumn15.HeaderText = "The_reason_for_appointment";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Medical_history";
            this.dataGridViewTextBoxColumn16.HeaderText = "Medical_history";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // databaseBindingSource2
            // 
            this.databaseBindingSource2.DataMember = "Data_base";
            this.databaseBindingSource2.DataSource = this.mKBDDataSetBindingSource;
            // 
            // mKBDDataSetBindingSource
            // 
            this.mKBDDataSetBindingSource.DataSource = this.mK_BDDataSet;
            this.mKBDDataSetBindingSource.Position = 0;
            // 
            // mK_BDDataSet
            // 
            this.mK_BDDataSet.DataSetName = "MK_BDDataSet";
            this.mK_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseBindingSource1
            // 
            this.databaseBindingSource1.DataMember = "Data_base";
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataMember = "Data_base";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabControl1.Location = new System.Drawing.Point(12, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 251);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.AppointmentDate1);
            this.tabPage1.Controls.Add(this.Medical_history1);
            this.tabPage1.Controls.Add(this.The_reason_for_appointment1);
            this.tabPage1.Controls.Add(this.Doctor_who_needs_appointment1);
            this.tabPage1.Controls.Add(this.Date_birth1);
            this.tabPage1.Controls.Add(this.Surname1);
            this.tabPage1.Controls.Add(this.Name1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Додати дані про паціента";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(835, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Історія хвороби";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Причина призначення прийому до лікаря";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Дата запису на прийом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Дата народження ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Лікар якому потрібно потрапити на прийом.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ім\'я";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(997, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Додати хворого в базу";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1016, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add a patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentDate1
            // 
            this.AppointmentDate1.Location = new System.Drawing.Point(136, 154);
            this.AppointmentDate1.Name = "AppointmentDate1";
            this.AppointmentDate1.Size = new System.Drawing.Size(100, 20);
            this.AppointmentDate1.TabIndex = 7;
            // 
            // Medical_history1
            // 
            this.Medical_history1.Location = new System.Drawing.Point(748, 59);
            this.Medical_history1.Multiline = true;
            this.Medical_history1.Name = "Medical_history1";
            this.Medical_history1.Size = new System.Drawing.Size(243, 145);
            this.Medical_history1.TabIndex = 3;
            // 
            // The_reason_for_appointment1
            // 
            this.The_reason_for_appointment1.Location = new System.Drawing.Point(480, 58);
            this.The_reason_for_appointment1.Multiline = true;
            this.The_reason_for_appointment1.Name = "The_reason_for_appointment1";
            this.The_reason_for_appointment1.Size = new System.Drawing.Size(243, 145);
            this.The_reason_for_appointment1.TabIndex = 6;
            // 
            // Doctor_who_needs_appointment1
            // 
            this.Doctor_who_needs_appointment1.Location = new System.Drawing.Point(299, 94);
            this.Doctor_who_needs_appointment1.Multiline = true;
            this.Doctor_who_needs_appointment1.Name = "Doctor_who_needs_appointment1";
            this.Doctor_who_needs_appointment1.Size = new System.Drawing.Size(112, 80);
            this.Doctor_who_needs_appointment1.TabIndex = 5;
            // 
            // Date_birth1
            // 
            this.Date_birth1.Location = new System.Drawing.Point(11, 154);
            this.Date_birth1.Name = "Date_birth1";
            this.Date_birth1.Size = new System.Drawing.Size(100, 20);
            this.Date_birth1.TabIndex = 3;
            // 
            // Surname1
            // 
            this.Surname1.Location = new System.Drawing.Point(132, 94);
            this.Surname1.Name = "Surname1";
            this.Surname1.Size = new System.Drawing.Size(100, 20);
            this.Surname1.TabIndex = 2;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(12, 95);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(100, 20);
            this.Name1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1125, 225);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Видалити дані про паціента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ведіть \"Id_Patient\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Видалення даних сдудента\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(18, 99);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.textBox_Id);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.AppointmentDate);
            this.tabPage4.Controls.Add(this.Medical_history);
            this.tabPage4.Controls.Add(this.The_reason_for_appointment);
            this.tabPage4.Controls.Add(this.Doctor_who_needs_appointment);
            this.tabPage4.Controls.Add(this.Date_birth);
            this.tabPage4.Controls.Add(this.Surname);
            this.tabPage4.Controls.Add(this.Name);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1125, 225);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Відредагувати дані про паціента";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Id_Patient";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(16, 42);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Історія хвороби";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Причина призначення прийому до лікаря";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Дата запису на прийом";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Дата народження ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Лікар якому потрібно потрапити на прийом.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Прізвище";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Ім\'я";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(997, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Додати хворого в базу";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1016, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "Edit data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.Location = new System.Drawing.Point(136, 154);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(100, 20);
            this.AppointmentDate.TabIndex = 46;
            // 
            // Medical_history
            // 
            this.Medical_history.Location = new System.Drawing.Point(748, 59);
            this.Medical_history.Multiline = true;
            this.Medical_history.Name = "Medical_history";
            this.Medical_history.Size = new System.Drawing.Size(243, 145);
            this.Medical_history.TabIndex = 42;
            // 
            // The_reason_for_appointment
            // 
            this.The_reason_for_appointment.Location = new System.Drawing.Point(480, 58);
            this.The_reason_for_appointment.Multiline = true;
            this.The_reason_for_appointment.Name = "The_reason_for_appointment";
            this.The_reason_for_appointment.Size = new System.Drawing.Size(243, 145);
            this.The_reason_for_appointment.TabIndex = 45;
            // 
            // Doctor_who_needs_appointment
            // 
            this.Doctor_who_needs_appointment.Location = new System.Drawing.Point(299, 94);
            this.Doctor_who_needs_appointment.Multiline = true;
            this.Doctor_who_needs_appointment.Name = "Doctor_who_needs_appointment";
            this.Doctor_who_needs_appointment.Size = new System.Drawing.Size(112, 80);
            this.Doctor_who_needs_appointment.TabIndex = 44;
            // 
            // Date_birth
            // 
            this.Date_birth.Location = new System.Drawing.Point(11, 154);
            this.Date_birth.Name = "Date_birth";
            this.Date_birth.Size = new System.Drawing.Size(100, 20);
            this.Date_birth.TabIndex = 43;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(132, 94);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 41;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(12, 95);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 40;
            // 
            // data_baseTableAdapter
            // 
            this.data_baseTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 640);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
        
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mK_BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseBindingSource;
 
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AppointmentDate1;
        private System.Windows.Forms.TextBox Medical_history1;
        private System.Windows.Forms.TextBox The_reason_for_appointment1;
        private System.Windows.Forms.TextBox Doctor_who_needs_appointment1;
        private System.Windows.Forms.TextBox Date_birth1;
        private System.Windows.Forms.TextBox Surname1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorwhoneedsappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thereasonforappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalhistoryDataGridViewTextBoxColumn;
 
        private System.Windows.Forms.BindingSource databaseBindingSource1;
 
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource mKBDDataSetBindingSource;
        private MK_BDDataSet mK_BDDataSet;
        private System.Windows.Forms.BindingSource databaseBindingSource2;
        private MK_BDDataSetTableAdapters.Data_baseTableAdapter data_baseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox AppointmentDate;
        private System.Windows.Forms.TextBox Medical_history;
        private System.Windows.Forms.TextBox The_reason_for_appointment;
        private System.Windows.Forms.TextBox Doctor_who_needs_appointment;
        private System.Windows.Forms.TextBox Date_birth;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label20;
    }
}

