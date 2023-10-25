import java.util.Scanner;

public class _4 {
   public static void main(String[] args) {

      int dec;             
      String hexStr = "";   
      int radix = 16;      
      char[] HEX_CHARS = {'0','1','2','3', '4','5','6','7', '8','9','A','B', 'C','D','E','F'};
   
      Scanner in = new Scanner(System.in);
      System.out.print("Enter a decimal number: ");
      dec = in.nextInt();
      in.close();
      

      System.out.println("Hexadecimal number:" + HEX_CHARS[dec]);
   }
}