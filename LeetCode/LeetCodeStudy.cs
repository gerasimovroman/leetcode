namespace LeetCode;

public class LeetCodeStudy
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var i = m - 1;
        var j = n - 1;
        var k = m + n - 1;
        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
    
    public int RemoveElement(int[] nums, int val)
    {
        var j = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                (nums[j], nums[i]) = (nums[i], nums[j]);
                j++;
            }
        }

        return j;
    } 
    
    
    public int RemoveDuplicates(int[] nums)
    {
        var j = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != nums[j])
            {
                nums[j + 1] = nums[i];
                j++;
            }    
        }

        return j + 1;
    }
    
    
    public int RemoveDuplicates2(int[] nums) {
        var j = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != nums[j])
            {
                if (nums[j] == nums[i - 1])
                {
                    j++;
                    nums[j + 1] = nums[i];
                    j++;
                }
                else
                {
                    nums[j + 1] = nums[i];
                    j++;
                }
                
            }
        }

        return j + 1;
    }
    
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        if (x == 0) return true;

        var r = 0;
        var i = x;

        while (i != 0)
        {
            i = Math.DivRem(i, 10, out var div);
            r = r * 10 + div;
        }

        return x - r == 0;
    }
    
    public int RomanToInt(string s) {
        s = s.ToLower();

        var dic = new Dictionary<char, int>()
        {
            { 'i', 1 },
            { 'v', 5 },
            { 'x', 10 },
            { 'l', 50 },
            { 'c', 100 },
            { 'd', 500 },
            { 'm', 1000 }
        };

        var r = 0;
        var i = s.Length - 1;

        var prev = 0;
        
        while (i >= 0)
        {
            var ch = s[i];
            var v = dic[ch];

            if (prev > v)
            {
                r -= v;
            }
            else
            {
                r += dic[ch];
            }

            prev = v;
            
            i--;
        }

        return r;
    }
    
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);

        var longestPrefix = strs[0];
        var startPos = 1;
        var i = startPos;
        
        while(i < strs.Length)
        {
            if (strs[i].StartsWith(longestPrefix))
            {
                startPos = i;
                i++;
            }
            else
            {
                if (longestPrefix.Length == 1)
                {
                    longestPrefix = "";
                    break;
                }
                
                longestPrefix = longestPrefix.Substring(0, longestPrefix.Length - 1);
                i = startPos;
            }
        }

        return longestPrefix;
    }
}