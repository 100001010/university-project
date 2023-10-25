import java.util.Scanner;

public class test {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // 提示用户输入第一个数字
        System.out.print("请输入第一个数字: ");
        int num1 = scanner.nextInt();

        // 提示用户输入第二个数字
        System.out.print("请输入第二个数字: ");
        int num2 = scanner.nextInt();

        // 计算两个数字的和
        int sum = num1 + num2;

        // 输出结果
        System.out.println("这两个数字的和是: " + sum);

        scanner.close(); // 关闭 Scanner 对象
    }
}




