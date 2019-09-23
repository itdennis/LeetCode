class Solution:
    def isPalindrome(self, x: int) -> bool:
        if(x < 0 or (x%10==0 and x != 0)):
            return False
        revertedNum = 0
        while x>revertedNum:
            revertedNum = revertedNum * 10 + x % 10
            x = x // 10

        return x == revertedNum or x == revertedNum // 10

sl = Solution
print (sl.isPalindrome(sl, 121))
