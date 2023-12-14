namespace TimeKeeper
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            TB_Path = new TextBox();
            btn_start = new Button();
            label1 = new Label();
            DGV_day_file_time = new DataGridView();
            Date_Column = new DataGridViewTextBoxColumn();
            FileName_Column = new DataGridViewTextBoxColumn();
            TimeSpan_Column = new DataGridViewTextBoxColumn();
            DGV_PerDay = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV_day_file_time).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_PerDay).BeginInit();
            SuspendLayout();
            // 
            // TB_Path
            // 
            TB_Path.Location = new Point(12, 12);
            TB_Path.Name = "TB_Path";
            TB_Path.Size = new Size(776, 27);
            TB_Path.TabIndex = 0;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(797, 12);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 27);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 2;
            label1.Text = "１１時出社  休憩１時間";
            // 
            // DGV_day_file_time
            // 
            DGV_day_file_time.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_day_file_time.Columns.AddRange(new DataGridViewColumn[] { Date_Column, FileName_Column, TimeSpan_Column });
            DGV_day_file_time.Location = new Point(12, 65);
            DGV_day_file_time.Name = "DGV_day_file_time";
            DGV_day_file_time.RowTemplate.Height = 29;
            DGV_day_file_time.Size = new Size(860, 784);
            DGV_day_file_time.TabIndex = 3;
            DGV_day_file_time.CellContentClick += DGV_day_file_time_CellContentClick;
            // 
            // Date_Column
            // 
            Date_Column.HeaderText = "日付";
            Date_Column.Name = "Date_Column";
            // 
            // FileName_Column
            // 
            FileName_Column.HeaderText = "ファイルネーム";
            FileName_Column.Name = "FileName_Column";
            FileName_Column.Width = 640;
            // 
            // TimeSpan_Column
            // 
            TimeSpan_Column.HeaderText = "時間";
            TimeSpan_Column.Name = "TimeSpan_Column";
            // 
            // DGV_PerDay
            // 
            DGV_PerDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PerDay.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3 });
            DGV_PerDay.Location = new Point(878, 12);
            DGV_PerDay.Name = "DGV_PerDay";
            DGV_PerDay.RowTemplate.Height = 29;
            DGV_PerDay.Size = new Size(493, 837);
            DGV_PerDay.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "ファイルネーム";
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "ファイル書込時間";
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 861);
            Controls.Add(DGV_PerDay);
            Controls.Add(DGV_day_file_time);
            Controls.Add(label1);
            Controls.Add(btn_start);
            Controls.Add(TB_Path);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Main";
            Text = "TimeKeeper";
            ((System.ComponentModel.ISupportInitialize)DGV_day_file_time).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_PerDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Path;
        private Button btn_start;
        private Label label1;
        private DataGridView DGV_day_file_time;
        private DataGridViewTextBoxColumn Date_Column;
        private DataGridViewTextBoxColumn FileName_Column;
        private DataGridViewTextBoxColumn TimeSpan_Column;
        private DataGridView DGV_PerDay;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
    }
}