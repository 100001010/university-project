import java.util.Scanner;

public class _1 {
   public static void main(String[] args) {
      
      String inStr;   
      int inStrLen;   
      String doubleStr;   
	  
   
      Scanner in = new Scanner(System.in);
      System.out.print("Enter a String: ");
      inStr = in.nextLine();
      inStrLen = inStr.length();
      in.close();

      // Finish the code in the following
      doubleStr=inStr+inStr;
      ////
      System.out.print("The double is: " + doubleStr);

  }
}