public class _6
 {
	public static void main(String[] args) {
		String str = "MCU";
		//char[] ch1 = {'J', 'A', 'V', 'A'};
		String ch1 = "JAVA";
		//char[] ch2 = {'C', 'S', 'I', 'E'};
		String ch2 = "CSIE";
		StringBuffer bstr = new StringBuffer(str);
		System.out.println("bstr1 : " + bstr);
		bstr.append('+');
		System.out.println("bstr2 : " + bstr);
		bstr.append(ch2);
		System.out.println("bstr3 : " + bstr);		

		bstr.insert(3, ch1);		
		System.out.println("bstr4 : " + bstr);

		bstr.deleteCharAt(1);		
		System.out.println("bstr5 : " + bstr);

		bstr.delete(5, 7);		
		System.out.println("bstr5 : " + bstr);

		bstr.append(ch2, 1, 3);		
		System.out.println("bstr7 : " + bstr);
	}
}
	
