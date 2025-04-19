using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TeamProject2
{
    public partial class CreateEventForm : Form
    {
        private TextBox nameTextBox;
        private TextBox categoryTextBox;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private TextBox participantsTextBox;
        private TextBox descriptionTextBox;
        private Button createButton;
        private Button backButton;

        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form settings
            this.Text = "Создать событие";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(139, 170, 86); // #8baa56
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Title label
            Label titleLabel = new Label();
            titleLabel.Text = "Создание новой конференции";
            titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Size = new Size(560, 30);
            titleLabel.Location = new Point(20, 20);
            this.Controls.Add(titleLabel);

            // Name field
            Label nameLabel = new Label();
            nameLabel.Text = "Название";
            nameLabel.Size = new Size(100, 30);
            nameLabel.Location = new Point(20, 70);
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font("Arial", 10);
            this.Controls.Add(nameLabel);

            nameTextBox = new TextBox();
            nameTextBox.Size = new Size(400, 30);
            nameTextBox.Location = new Point(130, 70);
            nameTextBox.BackColor = Color.FromArgb(201, 213, 97); // #c9d561
            nameTextBox.ForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            nameTextBox.Font = new Font("Arial", 10);
            this.Controls.Add(nameTextBox);
            
            // Category field
            Label categoryLabel = new Label();
            categoryLabel.Text = "Категория";
            categoryLabel.Size = new Size(100, 30);
            categoryLabel.Location = new Point(20, 110);
            categoryLabel.ForeColor = Color.White;
            categoryLabel.Font = new Font("Arial", 10);
            this.Controls.Add(categoryLabel);

            categoryTextBox = new TextBox();
            categoryTextBox.Size = new Size(400, 30);
            categoryTextBox.Location = new Point(130, 110);
            categoryTextBox.BackColor = Color.FromArgb(201, 213, 97); // #c9d561
            categoryTextBox.ForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            categoryTextBox.Font = new Font("Arial", 10);
            this.Controls.Add(categoryTextBox);
            
            // Date field
            Label dateLabel = new Label();
            dateLabel.Text = "Дата";
            dateLabel.Size = new Size(100, 30);
            dateLabel.Location = new Point(20, 150);
            dateLabel.ForeColor = Color.White;
            dateLabel.Font = new Font("Arial", 10);
            this.Controls.Add(dateLabel);

            datePicker = new DateTimePicker();
            datePicker.Size = new Size(400, 30);
            datePicker.Location = new Point(130, 150);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.CalendarForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            datePicker.CalendarMonthBackground = Color.FromArgb(201, 213, 97); // #c9d561
            this.Controls.Add(datePicker);
            
            // Time field
            Label timeLabel = new Label();
            timeLabel.Text = "Время";
            timeLabel.Size = new Size(100, 30);
            timeLabel.Location = new Point(20, 190);
            timeLabel.ForeColor = Color.White;
            timeLabel.Font = new Font("Arial", 10);
            this.Controls.Add(timeLabel);

            timePicker = new DateTimePicker();
            timePicker.Size = new Size(400, 30);
            timePicker.Location = new Point(130, 190);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            this.Controls.Add(timePicker);
            
            // Participants field
            Label participantsLabel = new Label();
            participantsLabel.Text = "Участники";
            participantsLabel.Size = new Size(100, 30);
            participantsLabel.Location = new Point(20, 230);
            participantsLabel.ForeColor = Color.White;
            participantsLabel.Font = new Font("Arial", 10);
            this.Controls.Add(participantsLabel);

            participantsTextBox = new TextBox();
            participantsTextBox.Size = new Size(400, 30);
            participantsTextBox.Location = new Point(130, 230);
            participantsTextBox.BackColor = Color.FromArgb(201, 213, 97); // #c9d561
            participantsTextBox.ForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            participantsTextBox.Font = new Font("Arial", 10);
            this.Controls.Add(participantsTextBox);
            
            // Description field
            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Описание";
            descriptionLabel.Size = new Size(100, 30);
            descriptionLabel.Location = new Point(20, 270);
            descriptionLabel.ForeColor = Color.White;
            descriptionLabel.Font = new Font("Arial", 10);
            this.Controls.Add(descriptionLabel);

            descriptionTextBox = new TextBox();
            descriptionTextBox.Size = new Size(400, 90);
            descriptionTextBox.Location = new Point(130, 270);
            descriptionTextBox.BackColor = Color.FromArgb(201, 213, 97); // #c9d561
            descriptionTextBox.ForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            descriptionTextBox.Font = new Font("Arial", 10);
            descriptionTextBox.Multiline = true;
            this.Controls.Add(descriptionTextBox);

            // Create button
            createButton = new Button();
            createButton.Text = "Создать";
            createButton.Size = new Size(120, 40);
            createButton.Location = new Point(382, 380);
            createButton.Font = new Font("Arial", 12, FontStyle.Bold);
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.BackColor = Color.FromArgb(201, 213, 97); // #c9d561
            createButton.ForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            createButton.FlatAppearance.BorderColor = Color.FromArgb(90, 112, 55);
            createButton.FlatAppearance.BorderSize = 1;
            createButton.Click += new EventHandler(CreateButton_Click);
            this.Controls.Add(createButton);

            // Back button
            backButton = new Button();
            backButton.Text = "Назад";
            backButton.Size = new Size(100, 30);
            backButton.Location = new Point(20, 430);
            backButton.Font = new Font("Arial", 10);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.BackColor = Color.FromArgb(139, 170, 86); // #8baa56
            backButton.ForeColor = Color.White;
            backButton.FlatAppearance.BorderColor = Color.White;
            backButton.FlatAppearance.BorderSize = 1;
            backButton.Click += new EventHandler(BackButton_Click);
            this.Controls.Add(backButton);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {   
            // Validate input
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите название события.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }

            if (string.IsNullOrWhiteSpace(categoryTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите категорию события.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int participants;
            if (!int.TryParse(participantsTextBox.Text, out participants) || participants <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное количество участников.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand LoadEvent = new SqlCommand($"INSERT INTO [Events] (Name, Date, Time, Category, Participants, Description) VALUES (N'@Name, @Date, @Time, @Category, @Participants, @Description)");

            DateTime date = DateTime.Parse(datePicker.Text);
            DateTime time = DateTime.Parse(timePicker.Text);

            LoadEvent.Parameters.AddWithValue("Name", nameTextBox.Text);
            LoadEvent.Parameters.AddWithValue("Date", date);
            LoadEvent.Parameters.AddWithValue("Time", time);
            LoadEvent.Parameters.AddWithValue("Category", categoryTextBox.Text);
            LoadEvent.Parameters.AddWithValue("Participants", participantsTextBox.Text);
            LoadEvent.Parameters.AddWithValue("Description", descriptionTextBox.Text);


            //Sql
            MessageBox.Show("Событие успешно создано!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
