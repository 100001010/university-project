import java.util.Scanner;


public class _4 {
    public static void main(String args[]) {
        String s = "web.mcu.edu.tw";//有一個字串叫s="web.mcu.edu.tw"
        char result = s.charAt(0);//result = s[0]
        System.out.println(result);//output result
		
		Scanner reader = new Scanner(System.in);
		char operator = reader.nextLine().charAt(0);//operator =讀入一行字的第一個字
		System.out.println(operator);//optput operator
		System.out.println(operator -'a');//optput這個字是小寫的第幾個字母
    }
}