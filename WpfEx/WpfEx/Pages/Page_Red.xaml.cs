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
	/// Логика взаимодействия для Page_Red.xaml
	/// </summary>
	public partial class Page_Red : Page
	{
		private User _currentUser = new User();


		public Page_Red(User selectedUser) // Меняет данные для конкретного пользователя
		{
			InitializeComponent();

			if (selectedUser != null)
				_currentUser = selectedUser;

			DataContext = _currentUser;
		}
		public Page_Red()
		{
			InitializeComponent();

			DataContext = _currentUser;

			StringBuilder errors = new StringBuilder();

			if (string.IsNullOrWhiteSpace(_currentUser.Login))
				errors.AppendLine("Укажите логин!"); // Если логин пустой при сохранений пользователя
			if (string.IsNullOrWhiteSpace(_currentUser.Password))
				errors.AppendLine("Укажите пароль!"); // Если пароль пустой при сохранений пользователя
			if ((_currentUser.Role == null) || (cmbRole.Text == ""))
				errors.AppendLine("Выберите роль!"); // Если роль пустая при сохранений пользователя
			else
				_currentUser.Role = cmbRole.Text;


			if (errors.Length > 0)
			{
				MessageBox.Show(errors.ToString());
				return;
			}



		}

		private void ButtonSave_Click(object sender, RoutedEventArgs e) // Сохраняет данные в SQL таблицу
		{


			try
			{
				WpfExEntities.GetContext().SaveChanges();
				MessageBox.Show("Данные успешно сохранены!");
				if (_currentUser.ID == 0)
					WpfExEntities.GetContext().User.Add(_currentUser);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}


		}

		private void ButtonCancel_Click(object sender, RoutedEventArgs e) // Отменяет редактирование и возвращает пользователя назад
		{
			NavigationService?.Navigate(new Page_Admi());
		}
	}
}
