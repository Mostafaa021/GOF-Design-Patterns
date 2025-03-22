namespace DecoratorPattern;

// Wrapper

// the intent of Decorator Pattern is to add new functionality
// to an existing object dynamically without altering its structure.

// this pattern comes instead of adding new functionality to the class to extend its behavior 
// we don`t need to add responsibility to the object but for it`s instance during runtime

// Component
public interface IMailService
{
    bool SendMail(string message);
}

// Concrete Component 1
public class CloudMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Sending mail from Cloud Service: {message}");
        return true;
    }
}

// Concrete Component 2 

public class LocalMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Sending mail from Local Service: {message}");
        return true;
    }
}

// Decorator
public abstract class MailServiceBaseDecorator : IMailService
{
    private  readonly IMailService _mailService;

    protected MailServiceBaseDecorator(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}

// Concrete Decorator 1 
public class MailServiceWithLoggingDecorator : MailServiceBaseDecorator
{
    public MailServiceWithLoggingDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine("Logging the message");
        return base.SendMail(message);
    }
}

// Concrete Decorator 2
public class MailServiceWithEncryptionDecorator : MailServiceBaseDecorator
{
    public MailServiceWithEncryptionDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine("Encrypting the message");
        return base.SendMail(message);
    }
}

// Concrete Decorator 3 
public class MailServiceWithCompressionDecorator : MailServiceBaseDecorator
{
    public MailServiceWithCompressionDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine("Compressing the message");
        return base.SendMail(message);
    }
}