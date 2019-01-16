//Runtime: 168 ms
public class Solution {
    public  string ReverseString(string s) {
        public static string ReverseString(string s)
        {
            return GetMeTheString(s, s.Length, "");
        }

        public static string GetMeTheString(string subject, int pointer, string finalResult)
        {
            if (pointer <= 0) return finalResult;
            pointer--;
            finalResult += subject[pointer];
            return GetMeTheString(subject, pointer, finalResult);
        }
}