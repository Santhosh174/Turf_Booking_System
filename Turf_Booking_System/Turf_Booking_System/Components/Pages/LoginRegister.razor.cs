using Microsoft.Win32;
using Turf_Booking_System.Common.DependencyInjection.Interface;
using Turf_Booking_System.DataContext;
using Turf_Booking_System.Entity;
using Turf_Booking_System.Logic.Login_Register;

namespace Turf_Booking_System.Web.Components.Pages
{
	public partial class LoginRegister
	{
		private bool _bIsLogin {  get; set; } = true;
		private string? _strLoginName {  get; set; }
		private string? _strLoginPassword {  get; set; }
		private string? _strRegisterName {  get; set; }
		private string? _strRegisterPassword {  get; set; }
		private string? _LoginErrorField {  get; set; }
		private string? _RegisterErrorField {  get; set; }

		Login login = new Login();
		Register register = new Register();
		User user = new User();
		private void Login()
		{
			IDataList<User> serviceDataList = ServiceProvider.GetRequiredService<IDataList<User>>();
			_LoginErrorField = login.CheckAccess(_strLoginName,_strLoginPassword, serviceDataList);
		}

		private void Register()
		{
			IDataList<User> serviceDataList = ServiceProvider.GetRequiredService<IDataList<User>>(); 

			User user = new User() { strName = _strRegisterName, strPassword = _strRegisterPassword };
			_RegisterErrorField = register.IsNewUser(user, serviceDataList);
		}
		private void NewUser()
		{
			_bIsLogin = false;
		}

		private void OldUser()
		{
			_bIsLogin = true;
		}
	}
}
