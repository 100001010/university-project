import java.util.Scanner;

public class main{
    public static void main(String[] arge){
        System.out.print("請輸入成績");
        Scanner scanner = new Scanner(System.in);
        double s= scanner.nextDouble();
        if(s>=90)
            System.out.print("A");
        else if(s>=80)
            System.out.print("B");
        else if(s>=70)
            System.out.print("C");
        else if(s>=60)
            System.out.print("D");
        else if(s>=0)
            System.out.print("E");
        else 
            System.out.print("Error");
    }
}