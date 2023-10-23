import java.util.Scanner;
/**
 * Prompt user for a string; and print the input string in reverse order.
 */
public class _2 {
   public static void main(String[] args) {
      // Declare variables
      String inStr;   // input String
      int inStrLen;   // length of the input String
      String reverseStr;   // input String
	  
      // Prompt and read input as "String"
      Scanner in = new Scanner(System.in);
      System.out.print("Enter a String: ");
      inStr = in.nextLine();
      inStrLen = inStr.length();
      in.close();

      reverseStr = "";
      // Finish the code in the following
      for(int i=inStrLen-1;i>=0;i--)
        reverseStr+=inStr.charAt(i);
      ////
 

      System.out.print("The reverse is: " + reverseStr);

  }
}