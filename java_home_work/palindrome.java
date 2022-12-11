package java_home_work;
public class palindrome {
  
    public static boolean isPalindrome(String text) {
        String replaced = text.toLowerCase().replaceAll("[^a-zA-Z0-9]", "");
        String reversed = new StringBuffer(replaced).reverse().toString();
        return reversed.equals(replaced);
    }

    public static void main(String[] args) {
        System.out.println(isPalindrome("qwe"));
    }
}