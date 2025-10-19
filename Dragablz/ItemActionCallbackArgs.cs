using System;
using System.Windows;

namespace Dragablz
{
    public delegate void ItemActionCallback(ItemActionCallbackArgs<TabablzControl> args);

    public class ItemActionCallbackArgs<TOwner> where TOwner : FrameworkElement
    {
        public ItemActionCallbackArgs(Window window, TOwner owner, DragablzItem dragablzItem)
        {
            if (window == null) throw new ArgumentNullException(nameof(window));
            if (owner == null) throw new ArgumentNullException(nameof(owner));
            if (dragablzItem == null) throw new ArgumentNullException(nameof(dragablzItem));

            Window = window;
            Owner = owner;
            DragablzItem = dragablzItem;
        }

        public Window Window { get; }

        public TOwner Owner { get; }

        public DragablzItem DragablzItem { get; }

        public bool IsCancelled { get; private set; }

        public void Cancel()
        {
            IsCancelled = true;
        }
    }
}
