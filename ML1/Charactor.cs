using System;

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
				Util.WriteNumber(mAddress, 2, value, 0, 999);
			}
		}

		public uint BP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x02, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x02, 2, value, 0, 999);
			}
		}

		public uint HPPlus
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x04, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x04, 2, value, 0, 999);
			}
		}

		public uint BPPlus
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x08, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x08, 2, value, 0, 999);
			}
		}

		public uint POWPlus
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x0C, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x0C, 2, value, 0, 999);
			}
		}

		public uint DEFPlus
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x10, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x10, 2, value, 0, 999);
			}
		}

		public uint SPEEDPlus
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x14, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x14, 2, value, 0, 999);
			}
		}

		public uint Exp
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x1C, 4);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x1C, 4, value, 0, 9999999);
			}
		}


		private uint mAddress;
	}
}
