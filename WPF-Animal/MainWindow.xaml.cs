using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimalDLL;

namespace WPF_Animal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            Cat cat = new Cat();
            cat.SetSpecies();
            cat.Color = CatColor.Text;
            cat.Weight = CatWeight.Text;
            cat.Owner = CatOwner.Text;

            Shark shark = new Shark();
            shark.SetSpecies();
            shark.Color = SharkColor.Text;
            shark.Weight = SharkWeight.Text;
            shark.Length = Int32.Parse(SharkLength.Text);
            string LengthOfShark = shark.Length.ToString();

            tbCat.Text = "Spicies: " + cat.GetSpecies() + "\n"
                       + "Color: " + cat.Color + "\n"
                       + "Weight: " + cat.Weight + "\n"
                       + "Owner: " + cat.Owner;

            tbShark.Text = "Spicies: " + shark.GetSpecies() + "\n"
                       + "Color: " + shark.Color + "\n"
                       + "Weight: " + shark.Weight + "\n"
                       + "Length: " + LengthOfShark;

        }
    }
}

    
