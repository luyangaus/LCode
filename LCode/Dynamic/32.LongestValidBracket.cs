using System;
using System.Collections.Generic;

namespace LCode.Dynamic;

public class LongestValidBracket
{
    public int LongestValidParentheses(string s)
    {
        var max = 0;
        Stack<int> stack = new Stack<int>();
        stack.Push(-1);
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    stack.Push(i);
                }
                else
                {
                    max = Math.Max(max, i - stack.Peek());
                }
            }
        }

        return max;
    }
}