using Decorator;

SenderNotifications SendMail = new Email(new List<string> { "exampleA@mail.ru", "exampleB@gmail.com" });
DecoratorNotify SendSMS = new SMSSender(new List<string> {"+79131234567", "+777111222333"});
DecoratorNotify SendFacebook = new FaceBookSender(new List<string> {"MagDak", "gamer_pro_227"});

SendMail.Send("хай");
Console.WriteLine("=================================");

SendSMS.sender = SendMail;
SendSMS.Send("Hi");

Console.WriteLine("=================================");
SendFacebook.sender = SendSMS;

SendFacebook.Send("hello");
