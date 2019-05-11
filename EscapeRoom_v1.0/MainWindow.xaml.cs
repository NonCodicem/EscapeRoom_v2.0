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

namespace EscapeRoom_v1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room currentRoom;

        public MainWindow()
        {
            InitializeComponent();

            //define room
            Room room1 = new Room("Bedroom", "I seem to be in a medium sized bedroom. " +
                "There is a locker to the left, a nice rug on the" +
                "floor, and a bed to the right. ");

            //define items
            Item key1 = new Item("Small silver key", "A small silver key, " +
                "makes me think of one I hadat highschool. ");
            Item key2 = new Item("Large key", "A large key. Could this be the way out?");

            Item locker = new Item("Locker", "A locker. I wonder what's inside.");
            locker.HiddenItem = key2;
            locker.IsLocked = true;
            locker.Key = key1;

            Item bed = new Item("Bed", "Just a bed. I am not tired now.");
            bed.HiddenItem = key1;

            room1.Items.Add(new Item("Floor mat", "A bit ragged floor mat, " +
                "but still one of the most popular designs. "));
            room1.Items.Add(bed);
            room1.Items.Add(locker);

            currentRoom = room1;
            lblMessage.Content = "I am awke, but cannot remember who I am. Must have been a hell of a partu last night ...";
            txtRoomDesc.Text = currentRoom.Description;
            UpdateUI();


        }

        private void UpdateUI()
        {

            lstRoomItems.Items.Clear();
            foreach (Item itm in currentRoom.Items)
            {
                lstRoomItems.Items.Add(itm);
            }
        }

        private void LstRoomItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCheck.IsEnabled = lstRoomItems.SelectedValue != null;
            btnPickUp.IsEnabled = lstRoomItems.SelectedValue != null;
            btnUseOne.IsEnabled = lstRoomItems.SelectedValue != null && lstMyItems.SelectedValue != null;

        }

        private void LstMyItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnCheck.IsEnabled = lstRoomItems.SelectedValue != null;
            btnPickUp.IsEnabled = lstRoomItems.SelectedValue != null;
            btnUseOne.IsEnabled = lstRoomItems.SelectedValue != null && lstMyItems.SelectedValue != null;
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            //find item to check
            Item roomitem = (Item)lstRoomItems.SelectedItem;

            //is it locked 
            if (roomitem.IsLocked)
            {
                lblMessage.Content = $"{roomitem.Description} It is firmly locked!";
                return;
            }

            if (true)
            {

            }

        }

        private void BtnUseOne_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPickUp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
