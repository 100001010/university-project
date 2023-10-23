import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;

public class _3{
    public static void main(String [] args){
        //Arrays sarray=new Arrays();
        Scanner sc =new Scanner(System.in);
        int n =sc.nextInt();
        int [] array = new int [n];
        Random r = new Random();

        for(int i=0;i<n;i++){
            array[i]=r.nextInt(100);

        }
        System.out.println(Arrays.toString(array));
        System.out.println("");
        Arrays.sort(array);
        System.out.println(Arrays.toString(array));

        for(int i=0;i<n;i++){
            array[i]/=10;
        }

        int[] num =new int[10];
        for(int i=0;i<10;i++){
            for(int j:array){
                if(j==i)
                    num[i]++;
            }
        }
        System.out.println(Arrays.toString(num));
        
        for(int i=0;i<10;i++){
            System.out.print((i*10+1)+" ~ "+(i*10+10)+" : ");
            for(int j=0;j<num[i];j++)
                System.out.print("*");
            System.out.println("");
        }
    }

}

