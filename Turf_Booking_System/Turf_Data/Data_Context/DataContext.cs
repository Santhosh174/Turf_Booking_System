using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turf_Booking_System.Common.DependencyInjection.Interface;
using Turf_Booking_System.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Turf_Booking_System.DataContext
{
	public class DataContext<T> where T : Base
	{
		public void Add(T data, IDataList<T> serviceDataList)
		{
			serviceDataList.AddList(data);
		}
		public List<T> GetData(IDataList<T> serviceDataList)
		{
			return serviceDataList.GetList();
		}
	}
}
