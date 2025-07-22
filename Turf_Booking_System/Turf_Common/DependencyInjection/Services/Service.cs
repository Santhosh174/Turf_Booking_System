using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turf_Booking_System.Common.DependencyInjection.Interface;
using Turf_Booking_System.Entity;

namespace Turf_Booking_System.Common.DependencyInjection.Services
{
	public class Service<T> : IDataList<T> where T : Base
	{
		private List<T> _Collections = [];

		public void AddList(T data)
		{
			data.nId = _Collections.Count + 1;
			_Collections.Add(data);
		}
		public List<T> GetList()
		{
			return _Collections;
		}
	}
}
