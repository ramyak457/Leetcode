using System.Linq;
public class Solution {
    public int MaxArea(int[] height) {
        /*int maxarea=0;
        for (int a=0;a<height.Length;a++)
        {
            for(int b = a+1;b<height.Length;b++)
            {
                int area = Math.Min(height[a],height[b])*(b-a);
                maxarea = Math.Max(area,maxarea);
            }
        }
        return maxarea;*/

        int maxarea = 0;
        int p1 = 0, p2 = height.Length-1;
        while(p1<=p2)
        {
            int area = Math.Min(height[p1],height[p2])*(p2-p1);
            maxarea = Math.Max(area, maxarea);
            if(height[p1]<height[p2])
            {
                p1++;
            }
            else{p2--;}
        }
        return maxarea;
    }
}