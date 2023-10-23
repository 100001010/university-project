public class _7 {
	public static void main(String[] args) {
		String str = "MCU CSIE";
		StringBuffer bstr = new StringBuffer(str);		
		System.out.println("bstr1 : " + bstr);
		bstr.setCharAt(3, '+');//在第三個index加入“＋”
		System.out.println("bstr2 : " + bstr);
		bstr.replace(0,3, "Ming Chuan University");//把index0-3的地方替換成目標字串
		System.out.println("bstr3 : " + bstr);
		System.out.println("bstr4 : " + bstr.reverse());//將字串返轉
		System.out.println("bstr5 : " + bstr.reverse());
	}
}
	
