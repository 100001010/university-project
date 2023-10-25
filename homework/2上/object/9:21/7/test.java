import java.util.Scanner;

class Add{
    double num1;
    double num2;
    double out;

    void input_2_num(){
        Scanner scanner = new Scanner(System.in);
        System.out.print("請輸入第一個數字");
        this.num1=scanner.nextDouble();
        System.out.print("請輸入第二個數字");
        this.num2=scanner.nextDouble();
    }

    void add(){
        this.out=this.num1+this.num2;
    }
    void printAns(){
        System.out.print(this.num1 + "+" +this.num2 + "=" + this.out);
    }
}

public class test{
    public static void main(String[]arge){
        Add t1 = new Add();
        t1.input_2_num();
        t1.add();
        t1.printAns();

        Add t2 = new Add();
        t2.input_2_num();
        t2.add();
        t2.printAns();
    }
}