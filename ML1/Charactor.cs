using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML1
{
	class Charactor
	{
		public Charactor(uint address)
		{
			mAddress = address;
		}

		public String Name { get; set; }

		public uint HP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress, 2);
			}

			set
			{
				SaveData.Instance().WriteNumber(mAddress, 2, value);
			}
		}

		private uint mAddress;
	}
}
