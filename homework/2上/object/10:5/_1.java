import java.util.Scanner;
import java.util.Random;

public class _1{
    public static void main(String [] args){
        int [] array = new int [10];
        Random r = new Random();
        for(int i:array){
            i=r.nextInt(100);
            System.out.print(i + " ");
        }
    }

}