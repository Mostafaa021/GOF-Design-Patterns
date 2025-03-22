namespace DecoratorPattern;

class Program
{
    
    static void Main(string[] args)
    {
        // Create a concrete component
        IMailService cloudMailService = new CloudMailService();
        cloudMailService.SendMail("Hello from CloudMailService");
        IMailService localMailService = new LocalMailService();
        localMailService.SendMail("Hello from LocalMailService");
        
        // Create a decorator
        IMailService mailServiceWithLoggingDecorator = new MailServiceWithLoggingDecorator(cloudMailService);
        mailServiceWithLoggingDecorator.SendMail("Hello from MailServiceWithLoggingDecorator");
        
        IMailService mailServiceWithEncryptionDecorator = new MailServiceWithEncryptionDecorator(localMailService);
        mailServiceWithEncryptionDecorator.SendMail("Hello from MailServiceWithEncryptionDecorator");
        
        // Create a decorator with adding dynamic behavior to the object during runtime 
        IMailService mailServiceWithLoggingAndEncryptionDecorator 
            = new MailServiceWithLoggingDecorator(
                new MailServiceWithEncryptionDecorator(cloudMailService));
        mailServiceWithLoggingAndEncryptionDecorator.SendMail("Hello from MailServiceWithLoggingAndEncryptionDecorator");
        
        IMailService mailServiceWithLoggingAndEncryptionAndCompressiongDecorator 
            = new MailServiceWithLoggingDecorator(
                new MailServiceWithEncryptionDecorator(
                    new MailServiceWithCompressionDecorator(localMailService)));
        mailServiceWithLoggingAndEncryptionAndCompressiongDecorator.SendMail("Hello from MailServiceWithLoggingAndEncryptionAndCompressionDecorator");
        
        
    }
}