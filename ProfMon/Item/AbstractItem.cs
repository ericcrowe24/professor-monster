using ProfMon.Framework;
using ProfMon.Framework.Item;
using ProfMon.Framework.Monster;
using static ProfMon.Framework.Item.IItem;

namespace ProfMon.Item {
    public abstract class AbstractItem : ProfObj, IItem {
        protected string _name { get; }
        protected string _description { get; }

        protected float _buyValue { get; }
        protected bool _sellable { get; }
        protected float _sellValue { get; }

        protected float _healthRestored { get; }
        protected IStatus _statusRemoved { get; }

        protected bool _fullHeal { get; }
        protected bool _removesAllStatus { get; }
        protected bool _removesAnyStatus { get; }
        protected bool _fullRestore { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract float BuyValue { get; }
        public abstract bool Sellable { get; }
        public abstract float SellValue { get; }

        public abstract float HealthRestored { get; }
        public abstract IStatus StatusRemoved { get; }

        public abstract bool FullHeal { get; }
        public abstract bool RemovesAllStatus { get; }
        public abstract bool RemovesAnyStatus { get; }

        private AbstractItem () : base(null) { }

        protected AbstractItem (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;

            _buyValue = config.BuyValue;
            _sellable = config.Sellable;
            _sellValue = config.SellValue;

            _healthRestored = config.HealthRestored;
            _statusRemoved = config.StatusRemoved;

            _fullHeal = config.FullHeal;
            _removesAllStatus = config.RemovesAllStatus;
            _removesAnyStatus = config.RemovesAnyStatus;
        }

        protected class Config {
            public IID ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            public float BuyValue { get; set; }
            public bool Sellable { get; set; }
            public float SellValue { get; set; }

            public float HealthRestored { get; set; }
            public IStatus StatusRemoved { get; set; }

            public bool FullHeal { get; set; }
            public bool RemovesAllStatus { get; set; }
            public bool RemovesAnyStatus { get; set; }
        }

        public abstract class AbstractItemBuilder : IItemBuilder {
            public abstract IItemBuilder WithID (IID id);
            public abstract IItemBuilder WithName (string name);
            public abstract IItemBuilder WithDescription (string Description);

            public abstract IItemBuilder WithBuyValue (float buy);
            public abstract IItemBuilder CanSell (bool option);
            public abstract IItemBuilder WithSellValue (float sell);

            public abstract IItemBuilder WithHealthRestored (float resotred);
            public abstract IItemBuilder WithStatusRemoved (IStatus status);

            public abstract bool CanFullHeal (bool option);
            public abstract bool RemovesAnyStatus (bool option);
            public abstract bool RemovesAllStatus (bool option);

            public abstract IItem Build ();
        }
    }
}
