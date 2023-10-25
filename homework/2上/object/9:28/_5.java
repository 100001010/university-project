import java.util.Stack;
import java.util.Scanner;

public class _5 {
   public static void main(String[] args) {

      int dec;             
      String hexStr = "";   
      int radix = 16;      
      char[] HEX_CHARS = {'0','1','2','3', '4','5','6','7', '8','9','A','B', 'C','D','E','F'};
   
      Scanner in = new Scanner(System.in);
      System.out.print("Enter a decimal number: ");
      dec = in.nextInt();
      in.close();
      while(dec>0){
        hexStr=HEX_CHARS[dec%16]+hexStr;
        dec/=16;
      }

      System.out.println("Hexadecimal number:" + hexStr);
   }
}