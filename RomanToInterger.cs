//https://leetcode.com/problems/roman-to-integer/
public class Solution {
    public int RomanToInt(string s) {
        int arabicValue = 0;
        int[] arabicValues = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] romanValues = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        
        while(s!=String.Empty){
            for (int i = 0; i < romanValues.Length; i++){
                if (s.Length >= romanValues[i].Length){
                    if (romanValues[i] == s.Substring(0, romanValues[i].Length)){
                        s = s.Substring(romanValues[i].Length);
                        arabicValue += arabicValues[i];
                    }
                }
            }
        }
        return arabicValue;
    }
}