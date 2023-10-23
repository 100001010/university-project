import java.util.Scanner;
class c_b{
    double h;
    double w;
    double b;

    void in(){
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("請輸入身高（m）");
        this.h=scanner.nextDouble();
        System.out.print("請輸入體重（kg）");
        this.w=scanner.nextDouble();

    }
    void cul(){
        this.b=this.w/this.h/this.h;
    }
    void out(){
        System.out.print(b+'\n');
    }
}

public class t{
    public static void main(String[] arge){
        c_b t1=new c_b();
        t1.in();
        t1.cul();
        t1.out();

    }
}