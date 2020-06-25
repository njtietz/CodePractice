//https://leetcode.com/problems/roman-to-integer/
class Solution {
    public int romanToInt(String s) {
        int arabicValue = 0;
        int[] arabicValues = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        String[] romanValues = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        while (!s.equals("")) {
			for	(int i = 0; i < romanValues.length; i++){
				if (s.length() >= romanValues[i].length()){
					if (romanValues[i].equals(s.substring(0, romanValues[i].length()))){
						s = s.substring(romanValues[i].length());
						arabicValue = arabicValue + arabicValues[i];
					}
				}
			}
		}
		return arabicValue;
    }
}