using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turf_Booking_System.Common.DependencyInjection.Interface;
using Turf_Booking_System.Common.DependencyInjection.Services;
using Turf_Booking_System.DataContext;
using Turf_Booking_System.Entity;

namespace Turf_Booking_System.Logic.Login_Register
{
	public class Login
	{
		DataContext<User> dataContext = new DataContext<User>();
		public string CheckAccess(string strUsername, string strUserPassword, IDataList<User> serviceDataList)
		{
			List<User> users = dataContext.GetData(serviceDataList);
			if(!(strUsername == null || strUserPassword == null))
			{
				var Result = users.Find(x => x.strName.Contains(strUsername));
				if(Result != null && Result.strPassword == strUserPassword)
				{
					return "Valid";
				}
				else
				{
					return "Incorrect Username or password";
				}
			}
			return "Enter a Valid Username and Password";
		}
	}
}
