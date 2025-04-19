using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeamProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.browseButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(170)))), ((int)(((byte)(86)))));
            this.browseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(213)))), ((int)(((byte)(97)))));
            this.browseButton.FlatAppearance.BorderSize = 2;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(250, 200);
            this.browseButton.MaximumSize = new System.Drawing.Size(250, 50);
            this.browseButton.MinimumSize = new System.Drawing.Size(250, 50);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(250, 50);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Просмотр событий";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(170)))), ((int)(((byte)(86)))));
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(213)))), ((int)(((byte)(97)))));
            this.createButton.FlatAppearance.BorderSize = 2;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(250, 270);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(250, 50);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать конференцию";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainForm
            // 
            this.BackgroundImage = global::TeamProject2.Properties.Resources.chrome_NuZTd7CyzS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.createButton);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eco Events Manager";
            this.ResumeLayout(false);

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            BrowseEventsForm browseForm = new BrowseEventsForm();
            browseForm.ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateEventForm createForm = new CreateEventForm();
            createForm.ShowDialog();
        }
    }
}