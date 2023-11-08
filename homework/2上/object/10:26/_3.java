

import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; 

public class _3 {
  public static void main(String[] args) {
    try {//嘗試做
      File myObj = new File("test.txt");//myObj=test.txt
      Scanner myReader = new Scanner(myObj);//從myObj輸入資料
      while (myReader.hasNextLine()) {//看有沒有下一行
        String sentence = myReader.nextLine();//input
		    String[] words = sentence.split(" ");//將句子以空白分割
		    for (String word:words)
			    System.out.println(word);//單獨輸出每個字
      }
      myReader.close();
    } catch (FileNotFoundException e) {//如果嘗試做沒成功，捕獲錯誤
      System.out.println("An error occurred.");
      e.printStackTrace();//印出錯誤種類
    }
  }
}