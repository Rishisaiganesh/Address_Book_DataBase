using System;

namespace Addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address book");
            AddressBookADO Add = new AddressBookADO();
            Add.DSConnection();
            Console.ReadLine();
        }
    }
}
