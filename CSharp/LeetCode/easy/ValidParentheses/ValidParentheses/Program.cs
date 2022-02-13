//https://leetcode.com/problems/valid-parentheses/

bool Solution(string s)
{
    Stack<char> stack = new Stack<char>();
    stack.Push(s[0]);
    for (int i = 1; i < s.Length; i++)
    {
        char cur = s[i];
        if (cur == '(' || cur == '{' || cur == '[')
            stack.Push(cur);
        else
        {
            if (stack.Count == 0)
                return false;

            char tmp;
            char prev = stack.Peek();
            if (prev == '(') tmp = ')';
            else if (prev == '[') tmp = ']';
            else if (prev == '{') tmp = '}';
            else return false;

            if (tmp != cur) return false;
            else stack.Pop();
        }
    }

    return stack.Count > 0 ? false : true;
}

Console.WriteLine(Solution("()"));