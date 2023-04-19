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

namespace WpfEx.Pages
{
	/// <summary>
	/// Логика взаимодействия для Page_Part.xaml
	/// </summary>
	public partial class Page_Part : Page
	{
		private User _currentUser = new User();

		public Page_Part(User selectedUser) 
		{
			InitializeComponent();

			if (selectedUser != null)
				_currentUser = selectedUser;

			DataContext = _currentUser;
		}
		public Page_Part()
		{
			InitializeComponent();

			DataContext = _currentUser;

			StringBuilder errors = new StringBuilder();


			if (errors.Length > 0)
			{
				MessageBox.Show(errors.ToString());
				return;
			}



		}

		private void ButtonAnswer_Click(object sender, RoutedEventArgs e) // Записывает данные введённые пользователем в таблицу
		{

			MessageBox.Show("Данные записаны");
			WpfExEntities db = new WpfExEntities();
			User userObject = new User
			{
				ID = 5,
				Login = Login.Text,
				Role = "Участник",
				Answer_1 = Answ1.Text,
				Answer_2 = Answ2.Text,
				Answer_3 = Answ3.Text
			};
			db.User.Add(userObject);
			db.SaveChanges();

		}

	}
}

