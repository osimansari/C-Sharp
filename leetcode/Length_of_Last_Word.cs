/*
  58. Length of Last Word (Easy)
  
  Given a string s consisting of words and spaces, return the length of the last word in the string.
  A word is a maximal substring  consisting of non-space characters only.
*/

public class Solution {
    public int LengthOfLastWord(string s) {        
        s = s.Trim();        
        string[] str  = s.Split(' ');

        return str[str.Length - 1].Length;
    }
}
