using System;

namespace CardGameEngine.Entities {
    /// <summary>
    /// Represents a set of cards like hand cards.
    /// </summary>
    public partial class Set : CardCollection {
        public Set() : base() {
            // Nothing to do
        }

        public Set(Card[] cards) : base(cards) {
            // Nothing to do
        }

        override public void AddCard(Card card, int position = 0) {
            if (position < 0 || position > this.Cards.Count)
                this.Cards.AddLast(card);
            else {
                var iterator = this.Cards.First;
                for (int i = 0; i < position; i++) iterator = iterator.Next;
                this.Cards.AddBefore(iterator, card);
            }
        }
    }
}
