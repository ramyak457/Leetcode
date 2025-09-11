public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastSeen = new Dictionary<char, int>();
        int left = 0, maxLen = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            // If c was seen inside the current window, move left
            if (lastSeen.ContainsKey(c) && lastSeen[c] >= left) {
                left = lastSeen[c] + 1;
            }

            // Update last seen index
            lastSeen[c] = right;

            // Update max length
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}