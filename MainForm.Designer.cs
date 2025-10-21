namespace ToDoListApp
{
    partial class MainForm
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
            this.lvTasks = new System.Windows.Forms.ListView();
            this.Tugas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioritas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTask = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.btnSortTasks = new System.Windows.Forms.Button();
            this.btnSaveToTxt = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTasks
            // 
            this.lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tugas,
            this.Prioritas,
            this.Deadline,
            this.Status});
            this.lvTasks.HideSelection = false;
            this.lvTasks.Location = new System.Drawing.Point(544, 12);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(244, 45);
            this.lvTasks.TabIndex = 0;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            // 
            // Tugas
            // 
            this.Tugas.Text = "Tugas";
            // 
            // Prioritas
            // 
            this.Prioritas.Text = "Prioritas";
            // 
            // Deadline
            // 
            this.Deadline.Text = "Deadline";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(156, 12);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(112, 20);
            this.txtTask.TabIndex = 1;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbPriority.Location = new System.Drawing.Point(289, 11);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(112, 21);
            this.cbPriority.TabIndex = 2;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(419, 12);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(107, 20);
            this.dtpDeadline.TabIndex = 3;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(12, 79);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(117, 29);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "TAMBAH TUGAS";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(12, 139);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(117, 29);
            this.btnEditTask.TabIndex = 5;
            this.btnEditTask.Text = "EDIT TUGAS";
            this.btnEditTask.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(12, 198);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(117, 29);
            this.btnDeleteTask.TabIndex = 6;
            this.btnDeleteTask.Text = "HAPUS TUGAS";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.Location = new System.Drawing.Point(12, 260);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(117, 29);
            this.btnMarkComplete.TabIndex = 7;
            this.btnMarkComplete.Text = "STATUS SELESAI";
            this.btnMarkComplete.UseVisualStyleBackColor = true;
            // 
            // btnSortTasks
            // 
            this.btnSortTasks.Location = new System.Drawing.Point(12, 325);
            this.btnSortTasks.Name = "btnSortTasks";
            this.btnSortTasks.Size = new System.Drawing.Size(117, 29);
            this.btnSortTasks.TabIndex = 8;
            this.btnSortTasks.Text = "SORTIR TUGAS";
            this.btnSortTasks.UseVisualStyleBackColor = true;
            // 
            // btnSaveToTxt
            // 
            this.btnSaveToTxt.Location = new System.Drawing.Point(12, 389);
            this.btnSaveToTxt.Name = "btnSaveToTxt";
            this.btnSaveToTxt.Size = new System.Drawing.Size(117, 29);
            this.btnSaveToTxt.TabIndex = 9;
            this.btnSaveToTxt.Text = "SIMPAN KE TXT";
            this.btnSaveToTxt.UseVisualStyleBackColor = true;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Location = new System.Drawing.Point(12, 12);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(117, 29);
            this.btnAboutUs.TabIndex = 10;
            this.btnAboutUs.Text = "ABOUT US";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnSaveToTxt);
            this.Controls.Add(this.btnSortTasks);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lvTasks);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ColumnHeader Tugas;
        private System.Windows.Forms.ColumnHeader Prioritas;
        private System.Windows.Forms.ColumnHeader Deadline;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Button btnSortTasks;
        private System.Windows.Forms.Button btnSaveToTxt;
        private System.Windows.Forms.Button btnAboutUs;
    }
}