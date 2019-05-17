/*
循环链表是一种链式存储结构，它的最后一个结点指向头结点，形成一个环。因此，从循环链表中的任何一个结点出发都能找到任何其他结点。循环链表的操作和单链表的操作基本一致，差别仅仅在于算法中的循环条件有所不同。
 */

namespace DataStructure
{

  public class CircylarLinkedList
  {
    ListNode head;

    public ListNode GetLast()
    {
      var cur = head;
      while (cur != null && cur.next != head)
      {
        cur = cur.next;
      }
      return cur;
    }

    public void Add(ListNode node)
    {
      if (head == null)
      {
        head = node;
        head.next = head;
        return;
      }

      //在尾部追加
      var last = GetLast();
      last.next = node;
      node.next = head;
    }

    public ListNode GetParent(ListNode node){
      return null;
    }

    public void Remove(ListNode node)
    {
      if (head == null)
      {
        return;
      }

      if (head == node)
      {
        head = head.next;
        if (head != null)
        {
          GetLast().next = head;
        }
        return;
      }
      

    }

    public ListNode Get(int index)
    {
      if (null == head)
      {
        throw new System.Exception("empty list");
      }

      //计数，需要找多少次
      var count = index + 1;
      var temp = head;
      var c = 1;
      //找到最后一个节点为止
      while (c < count && temp.next != head)
      {
        temp = temp.next;
        c++;
      }

      //计数不够，index超了
      if (c < count)
      {
        throw new System.IndexOutOfRangeException(string.Format("index:{0}", index));
      }

      return temp;
    }

    public int Size()
    {
      return 0;
    }

    public int IndexOf(ListNode node)
    {
      return 0;
    }

  }

}
