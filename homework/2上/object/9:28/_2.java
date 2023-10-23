import java.util.Scanner;

public class _2{
    public static void main(String[] arge){
        Scanner scanner = new Scanner(System.in);
        
        while(1==1){
            System.out.print("請輸入大小");
            int size = scanner.nextInt();

            System.out.printf(" *  |");
            for(int i=1;i<=size;i++){
                System.out.printf("%4d",i);    
            }
            System.out.print("\n"); 

            System.out.printf("-"); 
            for(int i=0;i<=size;i++){
                System.out.printf("----");    
            }
            System.out.print("\n"); 



            for(int i=1;i<=size;i++){
                System.out.printf("%2d  |",i);
                for(int j=1;j<=size;j++){
                    System.out.printf("%4d",i*j);
                }
                System.out.print("\n");
            }
        }
    }
}