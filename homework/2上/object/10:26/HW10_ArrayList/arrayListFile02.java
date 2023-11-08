import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; // Import the Scanner class to read text files
import java.util.*;

public class arrayListFile02 {
  public static void main(String[] args) {
    try {
      File myObj = new File("test03.txt");
      Scanner myReader = new Scanner(myObj);
	  ArrayList< ArrayList<Integer> > nestedArrayList = new ArrayList<>();
	  
      while (myReader.hasNextLine()) {
        String sentence = myReader.nextLine();
		String[] words = sentence.split(" ");
		ArrayList<Integer> innerList = new ArrayList<>();
		for (String word:words) {
			int number = Integer.parseInt(word);
			innerList.add(number);
		}
		nestedArrayList.add(innerList);
      }
	  
      for (ArrayList<Integer> innerList : nestedArrayList) {
          for (int number : innerList) {
              System.out.print(number + " ");
          }
          System.out.println(); // 換行
      }		
	  
      System.out.println(nestedArrayList.get(0));
	  //System.out.println(nestedArrayList.get(0).get(2));
	  
      myReader.close();
    } catch (FileNotFoundException e) {
      System.out.println("An error occurred.");
      e.printStackTrace();
    }
  }
}