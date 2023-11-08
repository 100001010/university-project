import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; 

public class a5 {
  public static void main(String[] args) {
    try {//嘗試做
      File myObj = new File("test.txt");//myObj=test.txt
      Scanner myReader = new Scanner(myObj);//從myObj輸入資料
      int to=0,the=0,total=0;
      while (myReader.hasNextLine()) {//看有沒有下一行
        String sentence = myReader.nextLine();//input
		    String[] words = sentence.split(" ");//將句子以空白分割
		    for(String word:words){
                total++;
                if(word.equals("to"))
                    to++;
                if(word.equals("the"))
                    the++;
            }
			    //System.out.println(word);//單獨輸出每個字
      }
      System.out.println("total:"+total);
      System.out.println("the:"+the);
      System.out.println("to:"+to);
      myReader.close();
    } catch (FileNotFoundException e) {//如果嘗試做沒成功，捕獲錯誤
      System.out.println("An error occurred.");
      e.printStackTrace();//印出錯誤種類
    }
  }
}