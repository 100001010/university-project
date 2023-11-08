import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; // Import the Scanner class to read text files
import java.util.*;

public class arrayListFile01 {
  public static void main(String[] args) {
    try {
      File myObj = new File("test02.txt");
      Scanner myReader = new Scanner(myObj);
	  ArrayList<Integer> numbers = new ArrayList<>();
	  
      while (myReader.hasNextLine()) {
	    String line= myReader.nextLine();
	    int number = Integer.parseInt(line);
        numbers.add(number);
      }
	  int total=0;
      for (int i=0;i<numbers.size();i+=2) {
          total+=numbers.get(i);
      }	
	  
	  System.out.println(total);

      myReader.close();
    } catch (FileNotFoundException e) {
      System.out.println("An error occurred.");
      e.printStackTrace();
    }
  }
}