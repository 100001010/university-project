 public class Main {
   public static void main(String[] args) {
     TrafficLight light = new TrafficLight();
     System.out.println("燈光為紅色： " + light.isRed());
     System.out.println("燈光為綠色： " + light.isGreen());
     light.changeColor("green");
     System.out.println("燈光現在為綠色: " + light.isGreen());
     System.out.println("燈光持續時間為: " + light.getDuration());
     light.setDuration(20);
     System.out.println("燈光現在持續時間為: " + light.getDuration());
   }
 }
