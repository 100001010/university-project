import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; 

public class a7 {
  public static void main(String[] args) {
    try {//嘗試做
      File myObj = new File("test03.txt");//myObj=test.txt
      Scanner myReader = new Scanner(myObj);//從myObj輸入資料
      //int to=0,the=0,total=0;
      int[][] x= new int [4][4];
      for (int i=0;i<4;i++) {//看有沒有下一行
        String sentence = myReader.nextLine();//input
		    String[] words = sentence.split(" ");//將句子以空白分割
            for(int j=0;j<4;j++){
                x[i][j]=Integer.parseInt(words[j]);
                
            }
			    //System.out.println(word);//單獨輸出每個字
      }
      for(int i=0;i<4;i++){
        int total=0;
        for(int j=0;j<4;j++)
            total+=x[i][j];
        System.out.println("row"+i+":"+total);

      }
      for(int i=0;i<4;i++){
        int total=0;
        for(int j=0;j<4;j++)
            total+=x[j][i];
        System.out.println("cow"+i+":"+total);

      }



      myReader.close();
    } catch (FileNotFoundException e) {//如果嘗試做沒成功，捕獲錯誤
      System.out.println("An error occurred.");
      e.printStackTrace();//印出錯誤種類
    }
  }
}