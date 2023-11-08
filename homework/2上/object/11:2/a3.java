import java.util.*;
import java.util.Collections;

public class a3 {

   public static void main(String args[]) {

      /* This is how to declare HashMap */
      HashMap<Integer, String> hmap = new HashMap<Integer, String>();

      /*Adding elements to HashMap*/
      hmap.put(12, "Chaitanya");
      hmap.put(2, "Rahul");
      hmap.put(7, "Singh");
      hmap.put(49, "Ajeet");
      hmap.put(3, "Anuj");

      /* Display content using Iterator*/
	  for (Integer i : hmap.keySet()) {
           System.out.println(i + " : " + hmap.get(i));
        }
	  
      /* Get values based on key*/
      String var= hmap.get(2);
      System.out.println("\nValue at key 2 is: "+var);
	 
	  Integer k = 17;
	  if(hmap.containsKey(k))
		System.out.println("\nValue at key " + k + " is " + hmap.get(k));
	  else
		System.out.println("No value at key " + k);

      /* Remove values based on key*/
      hmap.remove(3);
      System.out.println("\nMap key and values after removal:");
	  
	  for (Integer i : hmap.keySet()) {
           System.out.println(i + " : " + hmap.get(i));
        }
		
	// Sort by key
	   TreeMap<Integer, String> map = new TreeMap<Integer, String>(hmap); 
		 System.out.println("\nAfter Sorting:");
	  for (Integer i : map.keySet()) {
           System.out.println(i + " : " + map.get(i));
        }

	// Sort by key in reverse order
      ArrayList<Integer> keys = new ArrayList<Integer>();
	  for (Integer key : hmap.keySet()) {
           keys.add(key);
        }
	  Collections.sort(keys, Collections.reverseOrder());
	  System.out.println("\nAfter reverse Sorting:");
	  for (Integer i : keys) {
           System.out.println(i + " : " + map.get(i));
        }



   }
}