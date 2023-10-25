import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;

public class _2{
    public static void main(String [] args){
        //Arrays sarray=new Arrays();
        int [] array = new int [10];
        Random r = new Random();

        for(int i=0;i<10;i++){
            array[i]=r.nextInt(100);

        }
        System.out.println(Arrays.toString(array));
        System.out.println("");
        Arrays.sort(array);
        System.out.println(Arrays.toString(array));

    }

}

