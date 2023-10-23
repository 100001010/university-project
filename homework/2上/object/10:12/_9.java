public class _9 {
	public static void main(String[] args) {
		String str = "MCU CSIE";
		StringBuffer bstr = new StringBuffer(str);

      // Finish the code in the following
        bstr.insert(0,str.charAt(str.length()-1));
        bstr.deleteCharAt(bstr.length()-1);
      ////
		System.out.println(str);
		System.out.println(bstr);
	}
}

