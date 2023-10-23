import java.util.Scanner;
import java.util.Random;

public class _1
{
    public static void main(String[]arge){
        Scanner scanner = new Scanner (System.in);
        System.out.print("請輸入最大範圍");
        int max_ans=scanner.nextInt();
        int ans = (int)(Math.random()*max_ans+1);
        int in=-1;
        int max=max_ans;
        int min=0;
        while(true){
            in=scanner.nextInt();
            if(in>ans){
                max=in;
            }else if(in==ans){
                System.out.print("猜對了");
                break;
            }else {
                min=in;
            }
            System.out.print("答案在"+min+"與"+max+"之間");
        }
    }
}