﻿using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace SwordDamageWPFAppEncapsulated
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        SwordDamage swordDamage; 

        public MainWindow()
        {
            InitializeComponent();
            swordDamage = new SwordDamage((random.Next(1,7)+random.Next(1,7)+random.Next(1,7)));
            DisplayDamage();
        }
        public void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            DisplayDamage();
        }
        void DisplayDamage()
        {
            damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = 2;
            DisplayDamage();

        }
        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = 0;
            DisplayDamage();
        }
        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = 1.75M;
            DisplayDamage();
        }
        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = 1M;
            DisplayDamage();
        }
    }
}
