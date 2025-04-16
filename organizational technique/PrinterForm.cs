//Строки подключения библиотек
using MySql.Data.MySqlClient;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace organizational_technique
{
    public partial class PrinterForm : Form
    {
        // Строка подключения к базе данных через MAMP

        private string connectionString = ("Server=localhost;User ID=pk41;Password=123456789;Database=warehouse");



        public PrinterForm()
        {
            InitializeComponent();
            // Инициализация ComboBox для статусов
            comboBox1.Items.AddRange(new string[] { "В наличии", "В ремонте", "Списано" });
            comboBox1.SelectedIndex = 0;
            // Инициализация ComboBox для кабинетов
            comboBox2.Items.AddRange(new string[] { "Кабинет 101", "Кабинет 102", "Кабинет 201", "Кабинет 202", "Склад" });
            comboBox2.SelectedIndex = 0;
            LoadItems();// Загружаем данные при запуске формы


        }

        private void LoadItems()
        {
            ListBox1.Items.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, Model, Status, RoomID FROM printers";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListBox1.Items.Add($"{reader["Model"]} [{reader["Status"]}] [{reader["RoomID"]}]");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }
        // Добавление нового предмета
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите название предмета");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO `printers` (Model, Status, RoomID) VALUES (@Model, @Status, @RoomID)",
                    conn);

                    cmd.Parameters.AddWithValue("@Model", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Status", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@RoomID", comboBox2.SelectedItem);

                    cmd.ExecuteNonQuery();
                }

                textBox1.Clear();
               
                LoadItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления: {ex.Message}");
            }
        }
        // Обновление статуса предмета
        private void button3_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите предмет для изменения");
                return;
            }

            // Извлекаем ID из строки
            var selectedItem = ListBox1.SelectedItem.ToString();
            int itemId = int.Parse(selectedItem.Split('.')[0]);

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "UPDATE items SET Status = @Status, RoomID = @RooID WHERE ID = @ID",
                        conn);

                    cmd.Parameters.AddWithValue("@Status", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@RoomID", comboBox2.SelectedItem);
                    cmd.Parameters.AddWithValue("@ID", itemId);

                    cmd.ExecuteNonQuery();
                }

                LoadItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: {ex.Message}");
            }
        }
        // Удаление выбранного предмета
        private void button2_Click(object sender, EventArgs e)
        {
            // Проверяем, что строка выбрана
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите предмет для удаления");
                return;
            }

            // Получаем выбранный элемент
            string selectedItem = ListBox1.SelectedItem.ToString();

            try
            {
                // Извлекаем ID из строки (формат: "ID. Название [Статус] (Кабинет)")
                int itemId;
                if (!int.TryParse(selectedItem.Split('.')[0], out itemId))
                {
                    MessageBox.Show("Ошибка: не удалось определить ID предмета");
                    return;
                }

                // Удаляем из базы данных
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM items WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", itemId);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Предмет не найден в базе данных");
                        return;
                    }
                }

                // Обновляем список
                LoadItems();
                MessageBox.Show("Предмет успешно удалён");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

    }
}

