namespace ToDoList
{
    partial class ToDoList
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
            this.grDT = new System.Windows.Forms.GroupBox();
            this.Stt_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Note_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.choose_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.task_txt = new System.Windows.Forms.TextBox();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.grbx = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.PrioritySelect = new System.Windows.Forms.Button();
            this.cc_btn = new System.Windows.Forms.Button();
            this.Prg_btn = new System.Windows.Forms.Button();
            this.exp_btn = new System.Windows.Forms.Button();
            this.incplt_btn = new System.Windows.Forms.Button();
            this.cplt_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.Data_View = new System.Windows.Forms.DataGridView();
            this.reset_btn = new System.Windows.Forms.Button();
            this.timkiem_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.grDT.SuspendLayout();
            this.grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).BeginInit();
            this.SuspendLayout();
            // 
            // grDT
            // 
            this.grDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDT.BackColor = System.Drawing.Color.White;
            this.grDT.Controls.Add(this.Stt_cb);
            this.grDT.Controls.Add(this.label7);
            this.grDT.Controls.Add(this.label6);
            this.grDT.Controls.Add(this.dateTimeEnd);
            this.grDT.Controls.Add(this.label4);
            this.grDT.Controls.Add(this.Note_txt);
            this.grDT.Controls.Add(this.label3);
            this.grDT.Controls.Add(this.label2);
            this.grDT.Controls.Add(this.add_btn);
            this.grDT.Controls.Add(this.choose_cb);
            this.grDT.Controls.Add(this.label1);
            this.grDT.Controls.Add(this.task_txt);
            this.grDT.Controls.Add(this.dateTimeBegin);
            this.grDT.Location = new System.Drawing.Point(284, 58);
            this.grDT.Name = "grDT";
            this.grDT.Size = new System.Drawing.Size(676, 200);
            this.grDT.TabIndex = 2;
            this.grDT.TabStop = false;
            // 
            // Stt_cb
            // 
            this.Stt_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Stt_cb.FormattingEnabled = true;
            this.Stt_cb.Items.AddRange(new object[] {
            "Hoàn thành",
            "Chưa hoàn thành",
            "Quá Hạn",
            "Đang làm",
            "Bị huỷ"});
            this.Stt_cb.Location = new System.Drawing.Point(214, 141);
            this.Stt_cb.Name = "Stt_cb";
            this.Stt_cb.Size = new System.Drawing.Size(128, 21);
            this.Stt_cb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(211, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(271, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thời gian hoàn thành:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeEnd.Location = new System.Drawing.Point(414, 71);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(289, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thời gian bắt đầu:";
            // 
            // Note_txt
            // 
            this.Note_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_txt.Location = new System.Drawing.Point(468, 110);
            this.Note_txt.Multiline = true;
            this.Note_txt.Name = "Note_txt";
            this.Note_txt.Size = new System.Drawing.Size(146, 37);
            this.Note_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(408, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mức độ ưu tiên";
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.BackColor = System.Drawing.Color.Teal;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.LightGray;
            this.add_btn.Location = new System.Drawing.Point(595, 158);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // choose_cb
            // 
            this.choose_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.choose_cb.FormattingEnabled = true;
            this.choose_cb.Items.AddRange(new object[] {
            "Trong ngày",
            "Trong ba ngày",
            "Trong tuần",
            "Trong hai tuần",
            "Trong tháng"});
            this.choose_cb.Location = new System.Drawing.Point(37, 141);
            this.choose_cb.Name = "choose_cb";
            this.choose_cb.Size = new System.Drawing.Size(128, 21);
            this.choose_cb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhiệm vụ:";
            // 
            // task_txt
            // 
            this.task_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.task_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.task_txt.Location = new System.Drawing.Point(119, 19);
            this.task_txt.Multiline = true;
            this.task_txt.Name = "task_txt";
            this.task_txt.Size = new System.Drawing.Size(113, 23);
            this.task_txt.TabIndex = 1;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeBegin.Location = new System.Drawing.Point(414, 23);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBegin.TabIndex = 0;
            // 
            // grbx
            // 
            this.grbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbx.BackColor = System.Drawing.Color.Teal;
            this.grbx.Controls.Add(this.show_btn);
            this.grbx.Controls.Add(this.label8);
            this.grbx.Controls.Add(this.timkiem_txt);
            this.grbx.Controls.Add(this.label5);
            this.grbx.Controls.Add(this.dateTime);
            this.grbx.Controls.Add(this.PrioritySelect);
            this.grbx.Controls.Add(this.cc_btn);
            this.grbx.Controls.Add(this.Prg_btn);
            this.grbx.Controls.Add(this.exp_btn);
            this.grbx.Controls.Add(this.incplt_btn);
            this.grbx.Controls.Add(this.cplt_btn);
            this.grbx.Location = new System.Drawing.Point(-6, 12);
            this.grbx.Name = "grbx";
            this.grbx.Size = new System.Drawing.Size(284, 426);
            this.grbx.TabIndex = 3;
            this.grbx.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(35, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lọc theo ngày:";
            // 
            // dateTime
            // 
            this.dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTime.Location = new System.Drawing.Point(134, 352);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(144, 20);
            this.dateTime.TabIndex = 8;
            this.dateTime.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // PrioritySelect
            // 
            this.PrioritySelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrioritySelect.BackColor = System.Drawing.Color.Teal;
            this.PrioritySelect.FlatAppearance.BorderSize = 0;
            this.PrioritySelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrioritySelect.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioritySelect.ForeColor = System.Drawing.Color.LightGray;
            this.PrioritySelect.Location = new System.Drawing.Point(0, 378);
            this.PrioritySelect.Name = "PrioritySelect";
            this.PrioritySelect.Size = new System.Drawing.Size(284, 42);
            this.PrioritySelect.TabIndex = 5;
            this.PrioritySelect.Text = "Lọc mức độ ưu tiên";
            this.PrioritySelect.UseVisualStyleBackColor = false;
            this.PrioritySelect.Click += new System.EventHandler(this.PrioritySelect_Click);
            // 
            // cc_btn
            // 
            this.cc_btn.FlatAppearance.BorderSize = 0;
            this.cc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cc_btn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc_btn.ForeColor = System.Drawing.Color.LightGray;
            this.cc_btn.Location = new System.Drawing.Point(0, 204);
            this.cc_btn.Name = "cc_btn";
            this.cc_btn.Size = new System.Drawing.Size(284, 42);
            this.cc_btn.TabIndex = 4;
            this.cc_btn.Text = "Bị huỷ";
            this.cc_btn.UseVisualStyleBackColor = true;
            this.cc_btn.Click += new System.EventHandler(this.Cc_btn_Click);
            // 
            // Prg_btn
            // 
            this.Prg_btn.FlatAppearance.BorderSize = 0;
            this.Prg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prg_btn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prg_btn.ForeColor = System.Drawing.Color.LightGray;
            this.Prg_btn.Location = new System.Drawing.Point(0, 156);
            this.Prg_btn.Name = "Prg_btn";
            this.Prg_btn.Size = new System.Drawing.Size(284, 42);
            this.Prg_btn.TabIndex = 3;
            this.Prg_btn.Text = "Đang làm";
            this.Prg_btn.UseVisualStyleBackColor = true;
            this.Prg_btn.Click += new System.EventHandler(this.Prg_btn_Click);
            // 
            // exp_btn
            // 
            this.exp_btn.FlatAppearance.BorderSize = 0;
            this.exp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp_btn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_btn.ForeColor = System.Drawing.Color.LightGray;
            this.exp_btn.Location = new System.Drawing.Point(0, 108);
            this.exp_btn.Name = "exp_btn";
            this.exp_btn.Size = new System.Drawing.Size(284, 42);
            this.exp_btn.TabIndex = 2;
            this.exp_btn.Text = "Quá hạn";
            this.exp_btn.UseVisualStyleBackColor = true;
            this.exp_btn.Click += new System.EventHandler(this.Exp_btn_Click);
            // 
            // incplt_btn
            // 
            this.incplt_btn.FlatAppearance.BorderSize = 0;
            this.incplt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incplt_btn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incplt_btn.ForeColor = System.Drawing.Color.LightGray;
            this.incplt_btn.Location = new System.Drawing.Point(0, 60);
            this.incplt_btn.Name = "incplt_btn";
            this.incplt_btn.Size = new System.Drawing.Size(284, 42);
            this.incplt_btn.TabIndex = 1;
            this.incplt_btn.Text = "Chưa hoàn thành";
            this.incplt_btn.UseVisualStyleBackColor = true;
            this.incplt_btn.Click += new System.EventHandler(this.Incplt_btn_Click);
            // 
            // cplt_btn
            // 
            this.cplt_btn.FlatAppearance.BorderSize = 0;
            this.cplt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cplt_btn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cplt_btn.ForeColor = System.Drawing.Color.LightGray;
            this.cplt_btn.Location = new System.Drawing.Point(0, 12);
            this.cplt_btn.Name = "cplt_btn";
            this.cplt_btn.Size = new System.Drawing.Size(284, 42);
            this.cplt_btn.TabIndex = 0;
            this.cplt_btn.Text = "Hoàn thành";
            this.cplt_btn.UseVisualStyleBackColor = true;
            this.cplt_btn.Click += new System.EventHandler(this.Cplt_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.BackColor = System.Drawing.Color.Teal;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.LightGray;
            this.edit_btn.Location = new System.Drawing.Point(804, 24);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Sửa";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_btn.BackColor = System.Drawing.Color.Teal;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.LightGray;
            this.del_btn.Location = new System.Drawing.Point(885, 24);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 1;
            this.del_btn.Text = "Xoá";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Data_View
            // 
            this.Data_View.AllowUserToAddRows = false;
            this.Data_View.AllowUserToDeleteRows = false;
            this.Data_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_View.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_View.Location = new System.Drawing.Point(284, 266);
            this.Data_View.Name = "Data_View";
            this.Data_View.ReadOnly = true;
            this.Data_View.Size = new System.Drawing.Size(676, 172);
            this.Data_View.TabIndex = 4;
            this.Data_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_View_CellClick);
            // 
            // reset_btn
            // 
            this.reset_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_btn.BackColor = System.Drawing.Color.Teal;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.LightGray;
            this.reset_btn.Location = new System.Drawing.Point(723, 24);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Đặt lại";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // timkiem_txt
            // 
            this.timkiem_txt.Location = new System.Drawing.Point(76, 252);
            this.timkiem_txt.Name = "timkiem_txt";
            this.timkiem_txt.Size = new System.Drawing.Size(202, 20);
            this.timkiem_txt.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(6, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tìm kiếm:";
            // 
            // show_btn
            // 
            this.show_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.show_btn.BackColor = System.Drawing.Color.Teal;
            this.show_btn.FlatAppearance.BorderSize = 0;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.ForeColor = System.Drawing.Color.LightGray;
            this.show_btn.Location = new System.Drawing.Point(203, 278);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(75, 23);
            this.show_btn.TabIndex = 6;
            this.show_btn.Text = "hiển thị";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.Data_View);
            this.Controls.Add(this.grbx);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.grDT);
            this.Controls.Add(this.del_btn);
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grDT.ResumeLayout(false);
            this.grDT.PerformLayout();
            this.grbx.ResumeLayout(false);
            this.grbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grDT;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.GroupBox grbx;
        private System.Windows.Forms.TextBox task_txt;
        private System.Windows.Forms.Button cc_btn;
        private System.Windows.Forms.Button Prg_btn;
        private System.Windows.Forms.Button exp_btn;
        private System.Windows.Forms.Button incplt_btn;
        private System.Windows.Forms.Button cplt_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choose_cb;
        private System.Windows.Forms.TextBox Note_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PrioritySelect;
        private System.Windows.Forms.DataGridView Data_View;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.ComboBox Stt_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timkiem_txt;
        private System.Windows.Forms.Button show_btn;
    }
}

