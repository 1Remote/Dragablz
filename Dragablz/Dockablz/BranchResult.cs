using System;

namespace Dragablz.Dockablz
{
    public class BranchResult
    {
        public BranchResult(Branch branch, TabablzControl tabablzControl)
        {
            if (branch == null) throw new ArgumentNullException(nameof(branch));
            if (tabablzControl == null) throw new ArgumentNullException(nameof(tabablzControl));
            
            Branch = branch;
            TabablzControl = tabablzControl;
        }

        /// <summary>
        /// The new branch.
        /// </summary>
        public Branch Branch { get; }

        /// <summary>
        /// The new tab control.
        /// </summary>
        public TabablzControl TabablzControl { get; }
    }
}