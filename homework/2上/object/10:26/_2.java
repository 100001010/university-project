import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; 

public class _2 {
  public static void main(String[] args) {
    try {//嘗試做
      File myObj = new File("test.txt");//myObj=test.txt
      Scanner myReader = new Scanner(myObj);//從myObj輸入資料
      while (myReader.hasNextLine()) {//看有沒有下一行
        String data = myReader.nextLine();//input
        System.out.println(data);//output
      }
      myReader.close();
    } catch (FileNotFoundException e) {//如果嘗試做沒成功，捕獲錯誤
      System.out.println("An error occurred.");
      e.printStackTrace();//印出錯誤種類
    }
  }
}