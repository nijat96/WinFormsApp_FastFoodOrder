using WinFormsApp_FastFoodOrder.Entities;

namespace WinFormsApp_FastFoodOrder
{
    public partial class Form1 : Form
    {
        Menu menu = new Menu();
        public Form1()
        {
            InitializeComponent();
        }

        private void labelMenu1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menu menu1 = new Menu("a",Properties.Resources.az);
            pictureBoxMenu1.Image = menu.MenuList[0].MenuPic;
        }
    }
}
