using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_FastFoodOrder.Entities
{
    internal class Burger : Menu
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public PictureBox BurgerPicture { get; set; }

        public Dictionary<int,Burger> BurgerList { get; set; }

        public Burger()
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Properties.Resources.ru;
            BurgerList.Add(1, new Burger(MenuList,"Twister",3.50m,pictureBox1));
        }

        public Burger(Dictionary<int,Menu> menu ,string name, decimal price, PictureBox picture)
        {
            MenuList[0] = menu[0];
            Name = name;
            Price = price;
            BurgerPicture = picture;
        }
    }
}
