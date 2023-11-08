import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; // Import the Scanner class to read text files

public class ReadFile03 {
  public static void main(String[] args) {
    try {
      File myObj = new File("test03.txt");
      Scanner myReader = new Scanner(myObj);
	  int row=0;
	  int column = 0;
	  int[][] numbers = new int[10][10];
	  
      while (myReader.hasNextLine()) {
        String sentence = myReader.nextLine();
		String[] words = sentence.split(" ");
		column=0;
		for (String word:words) {
			int number = Integer.parseInt(word);
			numbers[row][column] = number;
			column++;
		}
		row++;	
      }
	  
	for (int i=0; i<row; i++) {
		for (int j=0; j < column; j++)
			System.out.printf("%4d", numbers[i][j]); 
        System.out.println();
    }		

	//System.out.println(numbers[0][1]+numbers[0][2]);
	
      myReader.close();
    } catch (FileNotFoundException e) {
      System.out.println("An error occurred.");
      e.printStackTrace();
    }
  }
}