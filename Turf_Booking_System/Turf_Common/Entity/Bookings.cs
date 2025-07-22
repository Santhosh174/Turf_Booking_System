using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turf_Booking_System.Entity
{
	public class Bookings : Base
	{
		public int nUserId { get; set; }
		public int nTurfId {  get; set; }
		public DateOnly DateOnly { get; set; }
		public string strTime { get; set; } = string.Empty;
	}
}
