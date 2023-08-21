using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            var list13 = new ListNode(4);
            var list12 = new ListNode(2, list13);
            var list1 = new ListNode(1, list12);
            
            var list23 = new ListNode(4);
            var list22 = new ListNode(3, list23);
            var list2 = new ListNode(1, list22);

            var merge = MergeTwoLists(list1, list2);
            var t = 0;
        }
        
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            
            if (list1 == null && list2 != null)
            {
                return list2;
            }
            
            if (list2 == null && list1 != null)
            {
                return list1;
            }

            if (list1.val <= list2.val)
            {
                return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
            }
            
            return new ListNode(list2.val, MergeTwoLists(list2.next, list1));
        }
        
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}