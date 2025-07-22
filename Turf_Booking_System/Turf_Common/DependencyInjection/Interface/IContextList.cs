using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turf_Booking_System.Entity;

namespace Turf_Booking_System.Common.DependencyInjection.Interface
{
	public  interface IDataList<T> 
	{
		public  void AddList(T data);
		public  List<T> GetList();
	}
}
