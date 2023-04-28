using Strategy.Pattern;
using Strategy.Pattern.Concrete;

Verification verification = new Verification();

string emailNotificationResponse = verification.SendNotification(new EmailNotificationSender());
Console.WriteLine(emailNotificationResponse);
string smsNotificationResponse = verification.SendNotification(new SmsNotificationSender());
Console.WriteLine(smsNotificationResponse);

Console.ReadLine();




