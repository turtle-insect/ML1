using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML1
{
	class Item
	{
		public String Name { get; set; }

		private readonly uint mAddress;

		public Item(uint address)
		{
			mAddress = address;
		}

		public uint Count
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress, 1);
			}

			set
			{
				Util.WriteNumber(mAddress, 1, value, 0, 0xFF);
			}
		}
	}
}
