

namespace ProfMon.Item {
	public class Item : ProfObj, IName, IDescription {
		public string Name { get; }
		public string Description { get; }

		public float BuyValue {get;}
		public bool Sellable {get;}
		public float SellValue {get;}

		public float HealthRestored {get;}
		public Status StatusRemoved {get;}

		public bool FullRestore {get;}
		public bool FullHeal {get;}

		private Item () : base(null){}

		public Item (Config config) : base(config.ID) {}

		private class Config {
			public IID ID {get; set;}
			public string Name {get; set;}
			public string Description {get; set;}

			public float BuyValue {get;set;}
			
		}
	}
}
