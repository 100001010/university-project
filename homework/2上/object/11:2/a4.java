import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.Scanner; // Import the Scanner class to read text files
import java.util.Map.Entry;
import java.util.*;



public class a4 {
	
	public static void countFrequencies(ArrayList<String> list)
    { 
        HashMap<String,Integer > hmap = new HashMap<String,Integer>();

        for(String i:list){
            if(hmap.containsKey(i)){
                int t=hmap.get(i);
                hmap.put(i,t+1);
            }else{
                hmap.put(i,1);
            }
        }
        for(String i:hmap.keySet())
          System.out.println(i + " : " + hmap.get(i));
   
   
    }
	
	
  public static void main(String[] args) {
	  
	ArrayList<String> list = new ArrayList<String>();
    try {
      File myObj = new File("test.txt");
      Scanner myReader = new Scanner(myObj);
      while (myReader.hasNextLine()) {
        String sentence = myReader.nextLine();
		String[] words = sentence.split(" ");
		for (String word:words)
			list.add(word);
      }
      myReader.close();
    } catch (FileNotFoundException e) {
      System.out.println("An error occurred.");
      e.printStackTrace();
    }
	
	countFrequencies(list);

  }
}