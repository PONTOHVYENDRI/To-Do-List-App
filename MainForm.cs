using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoListApp
{
    public partial class MainForm : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public class TaskItem
        {
            public string Task { get; set; }
            public string Priority { get; set; }
            public DateTime Deadline { get; set; }
            public bool IsCompleted { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
            LoadTasksFromFile();
            RefreshListView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Kosong, atau tambah inisialisasi jika perlu
        }

        private void RefreshListView()
        {
            lvTasks.Items.Clear();
            foreach (var task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Task);
                item.SubItems.Add(task.Priority);
                item.SubItems.Add(task.Deadline.ToShortDateString());
                item.SubItems.Add(task.IsCompleted ? "Selesai" : "Belum");
                lvTasks.Items.Add(item);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
            {
                TaskItem newTask = new TaskItem
                {
                    Task = txtTask.Text,
                    Priority = cbPriority.SelectedItem?.ToString() ?? "Low",
                    Deadline = dtpDeadline.Value,
                    IsCompleted = false
                };
                tasks.Add(newTask);
                RefreshListView();
                txtTask.Clear();
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                int index = lvTasks.SelectedIndices[0];
                tasks[index].Task = txtTask.Text;
                tasks[index].Priority = cbPriority.SelectedItem?.ToString() ?? "Low";
                tasks[index].Deadline = dtpDeadline.Value;
                RefreshListView();
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                int index = lvTasks.SelectedIndices[0];
                tasks.RemoveAt(index);
                RefreshListView();
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count > 0)
            {
                int index = lvTasks.SelectedIndices[0];
                tasks[index].IsCompleted = !tasks[index].IsCompleted;
                RefreshListView();
            }
        }

        private void btnSortTasks_Click(object sender, EventArgs e)
        {
            tasks.Sort((a, b) => a.Deadline.CompareTo(b.Deadline));
            RefreshListView();
        }

        private void btnSaveToTxt_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.Task},{task.Priority},{task.Deadline},{task.IsCompleted}");
                }
            }
            MessageBox.Show("Tugas disimpan ke tasks.txt!");
        }

        private void LoadTasksFromFile()
        {
            if (File.Exists("tasks.txt"))
            {
                foreach (var line in File.ReadLines("tasks.txt"))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        tasks.Add(new TaskItem
                        {
                            Task = parts[0],
                            Priority = parts[1],
                            Deadline = DateTime.Parse(parts[2]),
                            IsCompleted = bool.Parse(parts[3])
                        });
                    }
                }
            }
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan MainForm
            AboutForm aboutForm = new AboutForm();
            aboutForm.FormClosed += (s, args) => this.Show(); // Tampilkan kembali MainForm setelah AboutForm ditutup
            aboutForm.Show();
        }
    }
}