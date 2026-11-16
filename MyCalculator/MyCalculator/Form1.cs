namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            string FilePath = txtFilePath.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(FilePath))
                {
                    MessageBox.Show("Вкажіть шлях до файлу!");
                    return;
                }

                string fileContent = File.ReadAllText(FilePath);

                txtFileContent.Text = fileContent;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не знайдено!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Не вірний шлях до файлу!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Не вірний шлях до файлу!");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Немає доступу до файлу!");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка при відкритті файлу!");
            }
        }


        private void txtMyInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
