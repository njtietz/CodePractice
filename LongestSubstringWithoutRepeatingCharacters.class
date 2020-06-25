//https://leetcode.com/problems/longest-substring-without-repeating-characters/
class Solution {
    public int lengthOfLongestSubstring(String s) {
        int Longest = 0;
        outerloop: for (int i = 0; i < s.length(); i++){
            String UsedCharacters = "";
            UsedCharacters += s.charAt(i);
            //System.out.println(UsedCharacters);
            for (int j = 1; j < s.length() - i; j++){
                if (UsedCharacters.indexOf(s.charAt(i+j)) > -1){
                    if (j>Longest){
                        //System.out.println(UsedCharacters);
                        Longest = j;
                        //System.out.println(Longest);
                    }
                    continue outerloop;
                } else {
                    UsedCharacters += s.charAt(i+j);
                    if (j>Longest){
                        Longest = j+1;
                    }
                }
                //System.out.println(UsedCharacters);
            }
            if (Longest < UsedCharacters.length()){
                Longest = UsedCharacters.length();
            }
        }
        return Longest;
    }
}