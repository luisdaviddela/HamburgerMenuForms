using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamburgerMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HamburgerMenu : MasterDetailPage
	{
		public HamburgerMenu ()
		{
			InitializeComponent ();
            MyMenu();

        }
        public void MyMenu()
        {
            Detail = new NavigationPage(new Feed());
            List<Menu> menu = new List<Menu>
            {
                new Menu{ Page= new Feed(),MenuTitle="My Profile",  MenuDetail="Mi perfil",icon="user.png"},
                new Menu{ Page= new Feed(),MenuTitle="Messages",  MenuDetail="Mensajes",icon="message.png"},
                new Menu{ Page= new Feed(),MenuTitle="Contacts",  MenuDetail="Contactos",icon="contacts.png"},
                new Menu{ Page= new Feed(),MenuTitle="Settings",  MenuDetail="Configuración",icon="settings.png"}
            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }

            public ImageSource icon
            {
                get;
                set;
            }

            public Page Page
            {
                get;
                set;
            }
        }
	}
}