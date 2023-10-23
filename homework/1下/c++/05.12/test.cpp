
class DateTime{
	int day;
	int month;
	int year;
}

static class TimeCalculator{
	int GetDifferentDays(DateTime t1, DateTime t2){
		//TODO:implement it
			
		//MathHelper.Absolute(user.order.year - thisYear) * 365 +	//2023 - 2022
		//MathHelper.Absolute
	}
}

class Order{
	int price;
	DateTime time;
}

class User{
	String name;
	Order order;
}


static class MathHelper{
	static int Absolute(int value){
		//TODO:implement this
	}
}

User[] GetExpiredUsers(User[] users, DateTime now, int expiredDays){

	LinkedList<User> expiredUsers = new LinkedList<User>();

	for (User user : users) {

		int duration = TimeCalculator.GetDifferentDays(user.order.time, now);

		if(duration > expiredDays){
			expiredUsers.Add(user);
		}
	}

	return expiredUsers;
}