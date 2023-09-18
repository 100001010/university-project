import java.util.Scanner;

public class bmi {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // 提示用户输入第一个数字
        System.out.print("请输入身高（公尺）: ");
        double num1 = scanner.nextDouble();

        // 提示用户输入第二个数字
        System.out.print("请输入體重: ");
        double num2 = scanner.nextDouble();

        // 计算两个数字的和
        double ans = num2/num1/num1 ;

        // 输出结果
        System.out.println("bmi: " + ans);

        scanner.close(); // 关闭 Scanner 对象
    }
}




