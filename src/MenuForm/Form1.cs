using RestaurantMenu;

namespace MenuForm
{
    public partial class Form1 : Form
    {
        private MenuMaster menu;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var commonItems = richTextBox2.Text.Split('\n')
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => $"О.М.: {x}")
                .ToArray();

            var winterItems = richTextBox1.Text.Split('\n')
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => $"З.М.: {x}")
                .ToArray();

            var itemsPerPage = 0;

            if (commonItems.Length < 1
                || (!int.TryParse(textBox1.Text, out itemsPerPage) && itemsPerPage < 1))
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }

            menu = new MenuMaster(commonItems, winterItems, itemsPerPage);

            ChangePage(1);

            button6.Enabled = winterItems.Length > 0 && !string.IsNullOrEmpty(winterItems.First());
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void ChangePage(int page)
        {
            label4.Text = $"Страница: {page}";
            richTextBox4.Text = string.Join('\n', menu.GetDishesOnPage(page));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var page = 1;
            if (int.TryParse(label4.Text.Split(' ')[1], out page) && page > 1)
                ChangePage(page - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var page = 1;
            if (int.TryParse(label4.Text.Split(' ')[1], out page) && page < menu.GetPagesNumber())
                ChangePage(page + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePage(menu.GetPagesNumber());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (menu.GetWinterMenuFirstPage() > -1)
                ChangePage(menu.GetWinterMenuFirstPage());
        }
    }
}
