using System;
using System.Collections;
using System.Windows.Forms;

namespace ImportController {
    public class ItemComparer : IComparer {
        public int Column { get; set; }

        public ItemComparer(int colIndex) {
            Column = colIndex;
        }

        public int Compare(object a, object b) {
            int result;
            ListViewItem itemA = a as ListViewItem;
            ListViewItem itemB = b as ListViewItem;
            if (itemA == null && itemB == null)
                result = 0;
            else if (itemA == null)
                result = -1;
            else if (itemB == null)
                result = 1;
            if (itemA == itemB)
                result = 0;
            result = String.Compare(itemA.SubItems[Column].Text, itemB.SubItems[Column].Text);
            return result;
        }
    }
}