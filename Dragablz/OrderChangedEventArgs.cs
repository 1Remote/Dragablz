using System;

namespace Dragablz
{
    public class OrderChangedEventArgs : EventArgs
    {
        public OrderChangedEventArgs(object[]? previousOrder, object[] newOrder)
        {
            if (newOrder == null) throw new ArgumentNullException(nameof(newOrder));

            PreviousOrder = previousOrder;
            NewOrder = newOrder;
        }

        public object[]? PreviousOrder { get; }

        public object[] NewOrder { get; }
    }
}