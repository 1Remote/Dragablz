using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Dragablz
{
    public delegate void DragablzDragCompletedEventHandler(object sender, DragablzDragCompletedEventArgs e);

    public class DragablzDragCompletedEventArgs : RoutedEventArgs
    {
        public DragablzDragCompletedEventArgs(DragablzItem dragablzItem, DragCompletedEventArgs dragCompletedEventArgs)
        {
            if (dragablzItem == null) throw new ArgumentNullException(nameof(dragablzItem));
            if (dragCompletedEventArgs == null) throw new ArgumentNullException(nameof(dragCompletedEventArgs));
            
            DragablzItem = dragablzItem;
            DragCompletedEventArgs = dragCompletedEventArgs;
        }

        public DragablzDragCompletedEventArgs(RoutedEvent routedEvent, DragablzItem dragablzItem, DragCompletedEventArgs dragCompletedEventArgs)
            : base(routedEvent)
        {
            if (dragablzItem == null) throw new ArgumentNullException(nameof(dragablzItem));
            if (dragCompletedEventArgs == null) throw new ArgumentNullException(nameof(dragCompletedEventArgs));

            DragablzItem = dragablzItem;            
            DragCompletedEventArgs = dragCompletedEventArgs;
        }

        public DragablzDragCompletedEventArgs(RoutedEvent routedEvent, object source, DragablzItem dragablzItem, DragCompletedEventArgs dragCompletedEventArgs)
            : base(routedEvent, source)
        {
            if (dragablzItem == null) throw new ArgumentNullException(nameof(dragablzItem));
            if (dragCompletedEventArgs == null) throw new ArgumentNullException(nameof(dragCompletedEventArgs));

            DragablzItem = dragablzItem;
            DragCompletedEventArgs = dragCompletedEventArgs;
        }

        public DragablzItem DragablzItem { get; }

        public DragCompletedEventArgs DragCompletedEventArgs { get; }
    }
}