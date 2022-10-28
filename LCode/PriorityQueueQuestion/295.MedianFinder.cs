using System;
using System.Collections.Generic;

namespace LCode.PriorityQueueQuestion;

public class MedianFinder
{
    private PriorityQueue<int, int> queueMin;
    private PriorityQueue<int, int> queueMax;

    public MedianFinder()
    {
        queueMin = new PriorityQueue<int, int>();
        queueMax = new PriorityQueue<int, int>();
    }

    public void AddNum(int num)
    {
        if (queueMin.Count == 0 || queueMin.Peek() >= num)
        {
            queueMin.Enqueue(num, -num);
        }
        else
        {
            queueMax.Enqueue(num, num);
        }

        if (queueMin.Count < queueMax.Count)
        {
            var temp = queueMax.Dequeue();
            queueMin.Enqueue(temp, -temp);
        }

        if (queueMin.Count > queueMax.Count + 1)
        {
            var temp = queueMin.Dequeue();
            queueMax.Enqueue(temp, temp);
        }
    }

    public double FindMedian()
    {
        if (queueMax.Count == queueMin.Count)
        {
            return (queueMax.Peek() + queueMin.Peek()) / 2.0;
        }

        return queueMin.Peek();
    }
}