using System;
using System.Windows;

namespace Dragablz
{
    public class LocationChangedEventArgs : EventArgs
    {
        public LocationChangedEventArgs(object item, Point location)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            
            Item = item;
            Location = location;
        }

        public object Item { get; }

        public Point Location { get; }
    }
}