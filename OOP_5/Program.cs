using System.Collections.Generic;
namespace OOP_5
{
    #region Q1
    //public interface IShape
    //{
    //    double Area { get; }
    //    void DisplayShapeInfo();
    //}
    //
    //public interface ICircle : IShape
    //{
    //    double Redius { get; }
    //}
    //
    //public interface IRectangle : IShape
    //{
    //    double Width { get; }
    //    double Height { get; }
    //}
    //
    //public class Circle : ICircle
    //{
    //    public double Redius { get; private set; }
    //    public double Area => Math.PI * Redius * Redius;
    //    public Circle (double redius)
    //    {
    //        Redius = redius;
    //    }
    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Shape : Circle\n Redius : {Redius}\n Area : {Area}\n");
    //    }
    //}
    //
    //public class Rectangle : IRectangle
    //{
    //    public double Width { get; private set; }
    //    public double Height { get; private set; }
    //    public double Area => Width * Height;
    //    public Rectangle (double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }
    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Shape : Rectangle\n Width : {Width}\n Height : {Height}\n Area : {Area}");
    //    }
    //}

    #endregion

    #region Q2
    //public interface IAuthenticationService
    //{
    //    bool AuthenticateUser(string username, string password);
    //    bool AuthorizeUser(string username, string role);
    //}
    //
    //// i use dictoinary her 
    // public class BasicAuthenticationService : IAuthenticationService
    //{
    //    private Dictionary<string, (string Password, List<string> Roles)> users =
    //        new Dictionary<string, (string, List<string>)>
    //    {
    //           { "alice", ("12345", new List<string> { "admin", "user" }) },
    //           { "bob", ("abcde", new List<string> { "user" }) }
    //    };
    //
    //    // to chek if user name and password are correct it will return true else it will return false
    //    public bool AuthenticateUser(string username, string password)
    //    {
    //        return users.ContainsKey(username) && users[username].Password == password;
    //    }
    //
    //    // to chek if user name and role are correct it will return true else it will return false
    //    public bool AuthorizeUser(string username, string role)
    //    {
    //        return users.ContainsKey(username) && users[username].Roles.Contains(role);
    //    }
    //}
    #endregion

    #region Q3
    // public interface INotificationService
    // {
    //     void SendNotification(string recipient, string message);
    // }
    //
    // public class EmailNotificationService : INotificationService
    // {
    //     public void SendNotification(string recipient, string message)
    //     {
    //         Console.WriteLine($"📧 Email sent to {recipient}: {message}");
    //     }
    // }
    //
    // public class SmsNotificationService : INotificationService
    // {
    //     public void SendNotification(string recipient, string message)
    //     {
    //         Console.WriteLine($"📲 SMS sent to {recipient}: {message}");
    //     }
    // }
    //
    // public class PushNotificationService : INotificationService
    // {
    //     public void SendNotification(string recipient, string message)
    //     {
    //         Console.WriteLine($"🔔 Push notification to {recipient}: {message}");
    //     }
    // }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implement Q1
            //ICircle circle = new Circle(5.0);
            //IRectangle rectangle = new Rectangle(5.0, 4.0);
            //
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Implement Q2
            // IAuthenticationService authService = new BasicAuthenticationService();
            //
            // string username = "alice";
            // string password = "12345";
            // string role = "admin";
            //
            // bool isAuthenticated = authService.AuthenticateUser(username, password);
            // bool isAuthorized = authService.AuthorizeUser(username, role);
            //
            // Console.WriteLine($"Authenticated: {isAuthenticated}");
            // Console.WriteLine($"Authorized as '{role}': {isAuthorized}");

            #endregion

            #region Implement Q2
            // INotificationService emailService = new EmailNotificationService();
            // INotificationService smsService = new SmsNotificationService();
            // INotificationService pushService = new PushNotificationService();
            //
            //emailService.SendNotification("Hassan@example.com", "Hello Hassan !");
            //smsService.SendNotification("01023500854", "Your balance has been deducted");
            //pushService.SendNotification("hassan_18122022", "You have a new Notification!");
            #endregion
        }
    }
}