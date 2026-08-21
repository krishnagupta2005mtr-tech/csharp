using System;

namespace Q10_Notification
{
    abstract class Notification
    {
        public abstract void SendNotification();
    }

    class EmailNotification : Notification
    {
        private string email;

        public EmailNotification(string email)
        {
            this.email = email;
        }

        public override void SendNotification()
        {
            Console.WriteLine(
                "Email notification sent to: " + email);
        }
    }

    sealed class ImportantEmailNotification :
        EmailNotification
    {
        public ImportantEmailNotification(string email)
            : base(email)
        {
        }

        public void SendImportantNotification()
        {
            Console.WriteLine(
                "Important email notification sent.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmailNotification email =
                new EmailNotification("student@gmail.com");

            email.SendNotification();

            ImportantEmailNotification importantEmail =
                new ImportantEmailNotification(
                    "admin@gmail.com");

            importantEmail.SendNotification();
            importantEmail.SendImportantNotification();

            Console.ReadKey();
        }
    }
}