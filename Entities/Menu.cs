using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FastFoodOrder.Entities
{
    internal class Menu
    {
        public string MenuName { get; set; }
        public Image MenuPic { get; set; }

        public Dictionary<int,Menu> MenuList { get; set; }
        public Menu()
        {
            //ImageList imageList = new ImageList();
            //imageList.Images.Add(Image.FromFile("C:\\Users\\Nijat Nabiyev\\source\\repos\\WinFormsApp_KapitalBankATM\\Img\\az.jpg"));
            //imageList.Images.Add(Image.FromFile("C:\\Users\\Nijat Nabiyev\\source\\repos\\WinFormsApp_KapitalBankATM\\Img\\eng.jpg"));
            Image image1 = Image.FromFile("C:\\Users\\Nijat Nabiyev\\source\\repos\\WinFormsApp_KapitalBankATM\\Img\\az.jpg");
            Image image2 = Image.FromFile("C:\\Users\\Nijat Nabiyev\\source\\repos\\WinFormsApp_KapitalBankATM\\Img\\eng.jpg");


            MenuList.Add(1,new Menu("AZE", image1));
            MenuList.Add(2,new Menu("ENG", image2));
            

        }
        public Menu(string name , Image test) 
        {
            MenuName = name;
            MenuPic = test;
        }
    }
}
