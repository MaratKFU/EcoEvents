using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TeamProject2
{
    public partial class BrowseEventsForm : Form
    {
        private DataGridView eventsGrid;
        private Button backButton;

        public BrowseEventsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            // Form settings
            this.Text = "Просмотр событий";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(139, 170, 86); // #8baa56

            // Create DataGridView
            eventsGrid = new DataGridView();
            eventsGrid.Location = new Point(20, 20);
            eventsGrid.Size = new Size(860, 480);
            eventsGrid.BackgroundColor = Color.FromArgb(139, 170, 86); // #8baa56
            eventsGrid.BorderStyle = BorderStyle.None;
            eventsGrid.RowHeadersVisible = false;
            eventsGrid.AllowUserToAddRows = false;
            eventsGrid.ReadOnly = true;
            eventsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            eventsGrid.DefaultCellStyle.BackColor = Color.FromArgb(139, 170, 86);
            eventsGrid.DefaultCellStyle.ForeColor = Color.White;
            eventsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(90, 112, 55); // #5a7037
            eventsGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            eventsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 170, 86);
            eventsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            eventsGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            eventsGrid.GridColor = Color.FromArgb(201, 213, 97); // #c9d561
            eventsGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            eventsGrid.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(eventsGrid);

            // Create Back button
            backButton = new Button();
            backButton.Text = "Главное меню";
            backButton.Size = new Size(150, 40);
            backButton.Location = new Point(367, 520);
            backButton.Font = new Font("Arial", 10, FontStyle.Bold);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.BackColor = Color.FromArgb(201, 213, 97); // #c9d561
            backButton.ForeColor = Color.FromArgb(90, 112, 55); // #5a7037
            backButton.FlatAppearance.BorderColor = Color.FromArgb(90, 112, 55);
            backButton.FlatAppearance.BorderSize = 1;
            backButton.Click += new EventHandler(BackButton_Click);
            this.Controls.Add(backButton);
        }

        private void LoadData()
        {
            // Create DataTable
            DataTable eventsTable = new DataTable();
            eventsTable.Columns.Add("Название", typeof(string));
            eventsTable.Columns.Add("Дата", typeof(DateTime));
            eventsTable.Columns.Add("Время", typeof(DateTime));
            eventsTable.Columns.Add("Категория", typeof(string));
            eventsTable.Columns.Add("Участники", typeof(int));
            eventsTable.Columns.Add("Описание", typeof(string));

            string connectionString = "ваша_строка_подключения";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "SELECT Name, Date, Time, Category, Participants, Description FROM Events";
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //            {
            //                // Fill the DataTable with data from the database
            //                adapter.Fill(eventsTable);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            // Bind data to grid
            eventsGrid.DataSource = eventsTable;

            // Format date column
            eventsGrid.Columns["Дата"].DefaultCellStyle.Format = "yyyy-MM-dd";
            eventsGrid.Columns["Время"].DefaultCellStyle.Format = "HH:mm:ss";

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
