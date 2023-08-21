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

            var merge = MergeTwoLists(list1);
            var t = 0;
        }
        
        public static ListNode MergeTwoLists(ListNode list1) //, ListNode list2
        {
            ListNode res = new ListNode();
            ListNode cur = list1;
            while (true)
            {
                res.val = cur.val;
                cur = cur.next;
                res.next = cur;
                if (cur == null)
                {
                    return res;
                }
            }
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