﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ML1
{
	class DataContext
	{
		public List<Charactor> Party { get; set; } = new List<Charactor>();
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
		public DataContext()
		{
			Party.Add(new Charactor(0x00) { Name = "マリオ" });
			Party.Add(new Charactor(0x28) { Name = "ルイージ" });

			foreach (var item in Info.Instance().Items)
			{
				Items.Add(new Item(item.Value + 0x54) { Name = item.Name });
			}
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
