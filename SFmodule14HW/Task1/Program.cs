using Task1;
internal class Program
{
    static void Main(string[] args)
    {
        //  создаём пустой список с типом данных Contact
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));


        var SortedPhoneBook = phoneBook
                             .OrderBy(x => x.Name)
                             .ThenBy(x => x.LastName);

        foreach (var contact in SortedPhoneBook)
            Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber);

        while (true)
        {
            var parsed = int.TryParse(Console.ReadLine(), out var pageNum);

            if (!parsed || !(pageNum < 4 & pageNum > 0))
            {
                Console.WriteLine("Ввели ЕРЕСЬ");
            }
            else
            {
                var page = phoneBook.Skip(pageNum * 2 - 2).Take(2);

                foreach (var contact in page)
                    Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber);
            }
        }
    }
}
