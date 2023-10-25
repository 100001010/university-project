public class _8 {
	public static void main(String[] args) {
		String str = "MCU CSIE";
		StringBuffer bstr = new StringBuffer(str);
      // Finish the code in the following
        bstr.insert(8, str.charAt(0));
        bstr.deleteCharAt(0);
      ////
	    System.out.println(str);
		System.out.println(bstr);
	}
}