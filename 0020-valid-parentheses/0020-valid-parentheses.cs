public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 1) { return false;}
        if (s.Length == 0) { return true;}
        Stack<char> st = new Stack<char>();
        for (int i=0;i<s.Length;i++)
        {
            if(s[i] == '(' || s[i] == '[' || s[i]=='{')
            {
                st.Push(s[i]);
            } 
            else if (s[i] == ')' || s[i] == ']' || s[i]=='}')
            {
                if (st.Count>0)
                {
                    if(s[i] == ')' && st.Peek() =='(')
                    {
                        st.Pop();
                    }
                    else if (s[i] == '}' && st.Peek() == '{')
                    {
                        st.Pop();
                    }
                    else if (s[i] == ']' && st.Peek() == '[')
                    {
                        st.Pop();
                    } 
                    else
                    {
                        return false;
                    }                
                } 
                else 
                {
                    st.Push(s[i]);
                }        
            }  
        }
        if (st.Count() > 0) 
        { return false;} 
        else {return true;}
    }
}