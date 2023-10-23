import java.util.Scanner;
class _11{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        while(1==1){
            System.out.println("Enter a string");
            String s= sc.nextLine();
            boolean b=true;
            for(char i:s.toCharArray()){
                if(!(i=='1'||i=='0')){
                    System.out.println(s+"is NOT a binary string");
                    
                    b=false;
                    break;
                }

            }
            if(b)
                System.out.println(s+"is a binary string");
        }
    }
}