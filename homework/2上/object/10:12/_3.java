import java.util.Scanner;
/**
 * Prompt user for a string; and print the input string in reverse order.
 */
public class _3 {
   public static void main(String[] args) {
      // Declare variables
      String inStr;   // input String
      int inStrLen;   // length of the input String
      String leftRotateStr;   // input String
	  
      // Prompt and read input as "String"
      Scanner in = new Scanner(System.in);
      System.out.print("Enter a String: ");
      inStr = in.nextLine();
      inStrLen = inStr.length();
      in.close();

      leftRotateStr = "";
      // Finish the code in the following
        for(int i=1;i<inStrLen;i++)
            leftRotateStr+=inStr.charAt(i);
        leftRotateStr+=inStr.charAt(0);
      ////
 
      System.out.print("The left rotated string is: " + leftRotateStr);

  }
}