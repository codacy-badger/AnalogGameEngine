using AnalogGameEngine.Entities;

namespace AnalogGameEngine.Tests {
    class MockPlayer : Player {
        public MockPlayer() : base("Mockingbird") {
            // Nothing to do
        }

        protected override string[] GetSetIds() {
            return new string[0];
        }

        protected override string[] GetStackIds() {
            return new string[0];
        }
    }
}
