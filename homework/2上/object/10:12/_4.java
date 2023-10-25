import java.util.Scanner;
/**
 * Prompt user for a string; and print the input string in reverse order.
 */
public class _4 {
   public static void main(String[] args) {
      // Declare variables
      String inStr;   // input String
      int inStrLen;   // length of the input String
      String rightRotateStr;   // input String
	  
      // Prompt and read input as "String"
      Scanner in = new Scanner(System.in);
      System.out.print("Enter a String: ");
      inStr = in.nextLine();
      inStrLen = inStr.length();
      in.close();

      rightRotateStr = "";
      // Finish the code in the following
      rightRotateStr+=inStr.charAt(inStrLen-1);
      for(int i=0;i<inStrLen-1;i++)
        rightRotateStr+=inStr.charAt(i);
        rightRotateStr.charAt(0)="o";
      ////
      System.out.print("The right rotated string is: " + rightRotateStr);

  }
}