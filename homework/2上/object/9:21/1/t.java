import java.util.Scanner;

public class t {
    public static void main(String[]args){
        Scanner scanner = new Scanner(System.in);
        System.out.print("請輸入第一個數字");
        int num = scanner.nextInt();
        System.out.print("請輸入第二個數字");
        int num1 = scanner.nextInt();

        System.out.print("相加等於"+(num+num1));
        scanner.close();

    }
}