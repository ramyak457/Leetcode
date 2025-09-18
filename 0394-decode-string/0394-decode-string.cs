public class Solution {
    public string DecodeString(string s) {
        var rep = new Stack<int>();
        var seg = new Stack<StringBuilder>();
        seg.Push(new());

        int no = 0;

        foreach(char c in s)
        {
            if(char.IsDigit(c))
            {
                no = no*10 +(c-'0');
            }
            else if(c == '[')
            {
                rep.Push(no);
                seg.Push(new());
                no = 0;
            }
            else if(c == ']')
            {
                var r = rep.Pop();
                var s1 = seg.Pop();
                for (int i=0;i<r;i++) seg.Peek().Append(s1);
            }
            else{
                seg.Peek().Append(c);
            }
        }
        return seg.Pop().ToString();

    }
}