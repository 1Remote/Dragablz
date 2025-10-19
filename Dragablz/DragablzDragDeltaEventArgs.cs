using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Dragablz
{
    public delegate void DragablzDragDeltaEventHandler(object sender, DragablzDragDeltaEventArgs e);

    public class DragablzDragDeltaEventArgs : DragablzItemEventArgs
    {
        public DragablzDragDeltaEventArgs(DragablzItem dragablzItem, DragDeltaEventArgs dragDeltaEventArgs)
            : base(dragablzItem)
        {
            if (dragDeltaEventArgs == null) throw new ArgumentNullException(nameof(dragDeltaEventArgs));

            DragDeltaEventArgs = dragDeltaEventArgs;
        }

        public DragablzDragDeltaEventArgs(RoutedEvent routedEvent, DragablzItem dragablzItem, DragDeltaEventArgs dragDeltaEventArgs) 
            : base(routedEvent, dragablzItem)
        {
            if (dragDeltaEventArgs == null) throw new ArgumentNullException(nameof(dragDeltaEventArgs));

            DragDeltaEventArgs = dragDeltaEventArgs;
        }

        public DragablzDragDeltaEventArgs(RoutedEvent routedEvent, object source, DragablzItem dragablzItem, DragDeltaEventArgs dragDeltaEventArgs) 
            : base(routedEvent, source, dragablzItem)
        {
            if (dragDeltaEventArgs == null) throw new ArgumentNullException(nameof(dragDeltaEventArgs));

            DragDeltaEventArgs = dragDeltaEventArgs;
        }

        public DragDeltaEventArgs DragDeltaEventArgs { get; }

        public bool Cancel { get; set; }        
    }
}