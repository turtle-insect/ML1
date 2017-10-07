using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML1
{
	class DataContext
	{
		public List<Charactor> Party { get; set; } = new List<Charactor>();
		public DataContext()
		{
			Party.Add(new Charactor(0x00) { Name = "マリオ" });
			Party.Add(new Charactor(0x28) { Name = "ルイージ" });
		}
		public uint PlayHour
		{
			get
			{
				return SaveData.Instance().ReadNumber(0x250C, 4) / 3600000;
			}
			set
			{
				uint number = SaveData.Instance().ReadNumber(0x250C, 4) / 60000 % 60;
				SaveData.Instance().WriteNumber(0x250C, 4, (value * 60 + number) * 60000);
			}
		}

		public uint PlayMinute
		{
			get
			{
				return SaveData.Instance().ReadNumber(0x250C, 4) / 60000 % 60;
			}
			set
			{
				uint number = SaveData.Instance().ReadNumber(0x250C, 4) / 3600000;
				SaveData.Instance().WriteNumber(0x250C, 4, (value + number * 60) * 60000);
			}
		}
		public uint Coin
		{
			get
			{
				return SaveData.Instance().ReadNumber(0x50, 4);
			}

			set
			{
				Util.WriteNumber(0x50, 4, value, 0, 999999);
			}
		}
	}
}
