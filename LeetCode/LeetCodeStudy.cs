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
}