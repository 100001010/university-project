import java.util.Scanner;

public class _8{
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        String s = sc.nextLine();
        for(int i=0;i<s.length();i++){
            int t=s.charAt(i)-'0';
            if(t>10)
                t-=39;
            for(double j=3;j>=0;j--){
                int p=1;
                for(int k=0;k<j;k++)
                    p*=2;
                System.out.print(t/p);
                t%=p;
            }
            //System.out.println(t);
        }

    }
}