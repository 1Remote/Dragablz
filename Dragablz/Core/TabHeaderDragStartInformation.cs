using System;

namespace Dragablz.Core
{
    internal class TabHeaderDragStartInformation
    {
        public TabHeaderDragStartInformation(
            DragablzItem dragItem,
            double dragablzItemsControlHorizontalOffset, double dragablzItemControlVerticalOffset, double dragablzItemHorizontalOffset, double dragablzItemVerticalOffset)
        {
            if (dragItem == null) throw new ArgumentNullException(nameof(dragItem));

            DragItem = dragItem;
            DragablzItemsControlHorizontalOffset = dragablzItemsControlHorizontalOffset;
            DragablzItemControlVerticalOffset = dragablzItemControlVerticalOffset;
            DragablzItemHorizontalOffset = dragablzItemHorizontalOffset;
            DragablzItemVerticalOffset = dragablzItemVerticalOffset;
        }

        public double DragablzItemsControlHorizontalOffset { get; }

        public double DragablzItemControlVerticalOffset { get; }

        public double DragablzItemHorizontalOffset { get; }

        public double DragablzItemVerticalOffset { get; }

        public DragablzItem DragItem { get; }
    }
}