namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new ChatRoom();

            // Laywers
            var mohamed = new Lawyer("mohamed");
            var Ahmed = new Lawyer("Ahmed");
            //Account Managers
            var Mostafa = new AccountManager("Mostafa");
            var Ali = new AccountManager("Ali");

            chatRoom.Register(mohamed);
            chatRoom.Register(Ahmed);
            chatRoom.Register(Ali);
            chatRoom.Register(Mostafa);
            Mostafa.Send("Hello Everey one , i`m new to this company ");
            Console.ReadLine();
        }
    }
}
