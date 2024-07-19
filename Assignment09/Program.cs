using Assignment09.Part02;
using Assignment09.Question02_Authentication;
using Assignment09.Question03_Notification;

namespace Assignment09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 MCQ

            //Question 1:

            //What is the primary purpose of an interface in C#?

            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            //Answer: b) To define a blueprint for a class

            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?

            //a) private
            //b) protected
            //c) internal
            //d) public

            //Answer: a) private

            //Question 3:
            //Can an interface contain fields in C#?

            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are readonly

            //Answer: b) No

            //Question 4:
            //In C#, can an interface inherit from another interface?

            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace

            //Answer: b) Yes, interfaces can inherit from multiple interfaces

            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?

            //a) inherit
            //b) use
            //c) extends
            //d) implements

            //Answer: None of the given options is correct.The correct keyword is ":"

            //Question 6:
            //Can an interface contain static methods in C#?

            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private

            //Answer: a) Yes

            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?

            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed

            //Answer: b) No, all members are implicitly public

            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?

            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            //Answer: a) To hide the interface members from outside access

            //Question 9:
            //In C#, can an interface have a constructor?

            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static

            //Answer: b) No, interfaces cannot have constructors

            //Question 10:
            //How can a C# class implement multiple interfaces?

            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces

            //Answer: c) By separating interface names with commas

            #endregion

            #region Part02


            #region Question 01

            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            //Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.

            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(4, 7);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question02

            //In this example, we start by defining the IAuthenticationService interface
            //with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService
            //class implements this interface and provides the specific implementation for these methods.

            IAuthenticationService authService = new BasicAuthenticationService();

            //Example 01
            //bool isAuthenticated = authService.AuthenticateUser("sohair", "123456");
            //bool isAuthorized = authService.AuthorizeUser("admin", "admin");

            //Console.WriteLine($"Is Authenticated: {isAuthenticated}");
            //Console.WriteLine($"Is Authorized: {isAuthorized}"); // False

            //Example02
            //bool isAuthenticated = authService.AuthenticateUser("sohair", "123456");
            //bool isAuthorized = authService.AuthorizeUser("sohair", "admin");

            //Console.WriteLine($"Is Authenticated: {isAuthenticated}");

            //Console.WriteLine($"Is Authorized: {isAuthorized}"); // True

            #endregion

            #region Question03
            //Define the INotificationService interface with a method SendNotification that takes a recipient
            //and a message as parameters.Implement this interface in three classes: EmailNotificationService,
            //SmsNotificationService, and PushNotificationService.
            
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("sohair@gamil.com", "This is an email notification.");
            smsService.SendNotification("01010101088", "This is an SMS notification.");
            pushService.SendNotification("Hello from push Notification", "This is a push notification.");

            #endregion

            #endregion


        }
}
}
