using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace cardata_api_v3.Controllers
{
    class SendMessages
    {
        public static async Task SendMail(string name, string email)
        {
            // daca memorez api_key intr-o variabila de sistem
            //var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("mihaiste@gmail.com");
            var to = new EmailAddress(email);
            var subject = "Message send with SendGrid from C# app to: " + name;
            var plainTextContent = "This is the plain message text.";
            var htmlContent = "<b> And this is HTML content of the message</b>" +
                "<h3>Second mail</h3>";
            //acum creem mailul, cu ajutorul constructorului:
            var msg = MailHelper.CreateSingleEmail(
                from,
                to,
                subject,
                plainTextContent,
                htmlContent
                );

            //send email, by calling client:
            var response = await client.SendEmailAsync(msg);


        }
    }
}