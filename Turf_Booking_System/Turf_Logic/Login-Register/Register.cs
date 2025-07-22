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
	public class Register
	{
		DataContext<User> dataContext = new DataContext<User>();
		public string IsNewUser(User user, IDataList<User> serviceDataList)
		{
			List<User> users = dataContext.GetData(serviceDataList);
			if(!(user.strName == null || user.strPassword == null || user.strName.Length == 0 || user.strPassword.Length == 0))
			{
				bool Result = users.Exists(x => x.strName.Contains(user.strName));
				if(!Result)
				{
					dataContext.Add(user, serviceDataList);
					return "Registered Successfully";
				}
				else
				{
					return "Already Registered";
				}
			}
			return "Enter a Valid Username and Password";
		}
	}
}
