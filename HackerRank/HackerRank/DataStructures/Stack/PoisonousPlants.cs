using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Stack
{
    class PoisonousPlants
    {
        public static void Test()
        {
            List<int> p = new List<int>() { 1, 4, 7, 6, 2 };
            int result = poisonousPlants(p);
            Console.WriteLine(result);
        }
        public static int poisonousPlants(List<int> p)
        {
            // Create stacks from p
            List<LinkedList<int>> stacks = new List<LinkedList<int>>();
            // Add the first stack by default, empty
            LinkedList<int> current = new LinkedList<int>();
            stacks.Add(current);
            // Start and End of sub sequence of decreasing numbers
            int start = 0, end = 0;
            bool isLast = false;
            // Create stacks from the list
            for (int i = 0; i < p.Count; i++)
            {
                // Get left number
                int left = p[i];
                // Get right number
                if (i + 1 >= p.Count)
                    isLast = true;
                int right = (isLast == false) ? p[i + 1] : -1;

                // if left > right, keep adding in the current stack
                if (left < right || isLast == true)
                {
                    // right is greater, that means new sequence
                    // save i as end
                    end = i;
                    // Store in the current stack - end to start
                    for (int j = end; j >= start; j--)
                    {
                        current.AddLast(p[j]);
                    }
                    // Add new stack for next sequence
                    stacks.Add(new LinkedList<int>());
                    current = stacks[stacks.Count - 1];
                    // Start index will also change
                    start = i + 1;
                    end = i + 1;
                }
            }

            // If last stack is empty, then remove it from the list
            int lastStack = stacks.Count - 1;
            if (stacks[lastStack].Count == 0)
                stacks.RemoveAt(lastStack);

            int days = 0;
            
            int diedPlants;

            while (true)
            {
                // Remove empty stacks
                for (int i = stacks.Count - 1; i >= 1; i--)
                {
                    if (stacks[i].Count == 0)
                        stacks.RemoveAt(i);
                }
                    // If we can merge two adjacent lists, then merge
                    for (int i = stacks.Count - 1; i >= 1; i--)
                {
                    if (stacks[i - 1].First.Value > stacks[i].Last.Value)
                    {
                        // Merge i into i - 1
                        while (stacks[i].Count > 0)
                        {
                            stacks[i - 1].AddFirst(stacks[i].Last.Value);
                            stacks[i].RemoveLast();
                        }
                        // Remove i
                        stacks.RemoveAt(i);
                    }
                        
                }
                diedPlants = 0;
                // Remove the first item from each stack, except first
                for (int i = stacks.Count - 1; i >= 1; i--)
                {
                    // If stack has 1 item, compare it with the previous stack
                    if (stacks[i].Count >= 1 && stacks[i].Last() > stacks[i - 1].First())
                    {
                        // pop item and delete this stack from the list
                        stacks[i].RemoveLast();
                        diedPlants++;
                    }
                }

                // If no plant died, then break
                if (diedPlants == 0)
                    break;
                else
                    // Increment the day
                    days++;
            }


            return days;
        }
        public static int poisonousPlantsLinkedList(List<int> p)
        {
            // Create linked list from p
            LinkedList<int> list = new LinkedList<int>();
            foreach (int item in p)
                list.AddLast(item);

            List<LinkedListNode<int>> toDie;
            int days = 0;
            
            LinkedListNode<int> current = list.First;
            // Traverse the list
            while (current != null)
            {
                // Store the dying plants for each day
                toDie = new List<LinkedListNode<int>>();
                // Left should be greater than right
                LinkedListNode<int> cmp = current;
                while (cmp.Next != null)
                {
                    if (cmp.Next.Value > cmp.Value)
                    {
                        toDie.Add(cmp.Next);
                    }
                    
                    cmp = cmp.Next;
                }
                // Remove the dying plants, if any
                if (toDie.Count == 0)
                    break;
                else
                {
                    if (current.Previous != null) current = current.Previous;
                    // 1 day has passed
                    days++;
                    // Remove the dying plants, in reverse order,
                    // so that index position is not changed when deleting from the list
                    for (int d = toDie.Count - 1; d >= 0; d--)
                    {
                        list.Remove(toDie[d]);
                    }
                }
                current = current.Next;
            }

            return days;
        }

        public static int poisonousPlantsArray(List<int> p)
        {
            int days = 0;
            List<int> toDie;

            // Find which plants die
            for (int i = 0; i < p.Count; i++)
            {
                // Store plants to die, for each day
                toDie = new List<int>();
                // Left should be greater than right
                for (int j = i; j < p.Count; j++)
                {
                    // If right plant is greater
                    if (j + 1 < p.Count && p[j + 1] > p[j])
                    {
                        // Save the plants to die in a list
                        toDie.Add(j + 1);
                    }
                }
                // Remove the dying plants, if any
                if (toDie.Count == 0)
                    break;
                else
                {
                    i--;
                    // 1 day has passed
                    days++;
                    // Remove the dying plants, in reverse order,
                    // so that index position is not changed when deleting from the list
                    for (int d = toDie.Count - 1; d >= 0; d--)
                    {
                        p.RemoveAt(toDie[d]);
                    }
                }
            }

            return days;
        }
    }
}
