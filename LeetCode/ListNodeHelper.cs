namespace LeetCode;

public class ListNodeHelper
{
    public static void WriteLine(ListNode list)
    {
        var current = list;


        while (current != null)
        {
            Console.Write($"{current.val }");
            current = current.next;
        }
    }


    public static ListNode FromArray(int[] arr)
    {
        if (arr.Length == 0) return null;

        var head = new ListNode(arr[0]);
        var last = head;
        
        for (int i = 1; i < arr.Length; i++)
        {
            last = last.next = new ListNode(arr[i]);
            
        }

        return head;
    }
}