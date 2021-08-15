using ProfMon.Framework.Descriptors;
using ProfMon.Framework.ID;
using System.Collections.Generic;

namespace ProfMon.Monster {
    public class Element : ProfObj, IName, IDescription {
        public string Name { get; }

        public string Description { get; }

        public Dictionary<Element, int> Strengths { get; }

        public Dictionary<Element, int> Weaknesses { get; }

        private Element () : base(null) { }

        private Element (Config config) : base(config.ID) {
            Name = config.Name;
            Description = config.Description;
            Strengths = config.Strengths;
            Weaknesses = config.Weaknesses;
        }

        public class Builder {
            private Config config;

            public Builder () {
                config = new Config();
            }

            public Builder WithID (IID id) {
                config.ID = id;
                return this;
            }

            public Builder WithName (string name) {
                config.Name = name;
                return this;
            }

            public Builder WithDescription (string description) {
                config.Description = description;
                return this;
            }

            public Builder WithWeaknesses (Dictionary<Element, int> weaknesses) {
                config.Weaknesses = weaknesses;
                return this;
            }

            public Builder WithStrengths (Dictionary<Element, int> strengths) {
                config.Strengths = strengths;
                return this;
            }

            public Element Build () {
                return new Element(config);
            }
        }

        private class Config {
            public IID ID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public Dictionary<Element, int> Strengths = new Dictionary<Element, int>();

            public Dictionary<Element, int> Weaknesses = new Dictionary<Element, int>();
        }
    }
}
