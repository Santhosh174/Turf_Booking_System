using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turf_Booking_System.Entity
{
	public class Turf : Base
	{
		public int nOwnerId { get; set; }
		public string[]? strGames { get; set; }
		public string[]? strFacility { get; set; }
		public string strLocation { get; set; } = string.Empty;
		public string strDistrict { get; set; } = string.Empty;
		public int nAmountPerHour { get; set; }
		public byte[]? Images { get; set; }
	}
}
