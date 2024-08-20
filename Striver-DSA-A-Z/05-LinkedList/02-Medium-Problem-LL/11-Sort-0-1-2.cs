using Striver_DSA_A_Z._04_LinkedList._1d_Linked_List;

namespace Striver_DSA_A_Z._04_LinkedList._02_Medium_Problem_LL;

public partial class LinkedList
{
    //Complete this function
    public Node segregate(Node head)
    {
        //Your code here

        Node zero=null,firstzero=null;
        Node one =null,firstone = null;
        Node two =null,firsttwo = null;
        Node current = head;

        while(current!=null)
        {
            int data = current.data;

            if(data==0)
            {
                if(zero==null)
                {
                    zero= current;
                    firstzero = zero;

                }
                else
                {
                    zero.next = current;
                    zero = current;
                }
            }
            else if(data ==1)
            {

                if(one==null)
                {

                    one= current;
                    firstone  = one;
                }
                else
                {
                    one.next = current;
                    one = current;

                }
            }
            else{
                if(two==null)
                {

                    two= current;
                    firsttwo = two;
                }
                else
                {
                    two.next = current;
                    two = current;
                }

            }
            current = current.next;
        }

        Node newhead = null;
        if(zero!=null)
        {
            if(firstone!=null)
                zero.next = firstone;
            else
                zero.next = firsttwo;
            newhead = firstzero;
        }

        if(one!=null)
        {
            one.next = firsttwo;

            if(newhead==null)
                newhead =firstone;
        }
        if(two!=null)
        {
            two.next =null;

            if(newhead==null)
                newhead = firsttwo;


        }
        return  newhead;


    }
}