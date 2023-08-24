namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new()
            {
                "Porter Ross", "Camila Mccoy", "Josiah O'donnell", "Alexus Daugherty", "Aracely Knox", "Reginald Willis",
                "Dillon Acevedo", "Evelyn Larsen", "Ean Drake", "Jessie Ochoa", "Kyra Howe", "Ace Moyer", "Jermaine Conway",
                "Haylee Trevino", "Alice Lawson", "Janiah Davies", "Zaiden Leblanc", "Efrain Boyd", "Litzy Wilson", "Lewis Dennis"
            };
            //Console.WriteLine("Input: ");
            //foreach (string listName in names)
            //{
            //    Console.WriteLine(listName);
            //}

            //IEnumerable<IGrouping<char, string>> orderByName = names.OrderBy(x => x.Split(' ')[1]).GroupBy(x => x.Split(' ')[1][0]);

            //Console.WriteLine("Output: ");
            //foreach (IGrouping<char, string> lastName in orderByName)
            //{
            //    Console.WriteLine($"{lastName.Key}");
            //    foreach (string item in lastName)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            string nhapLai;
            do
            {
                Console.WriteLine("Nhập vào kí tự muốn tìm: ");
                string inputString = Console.ReadLine();

                List<string> result = names.Where(name =>
                        inputString.ToLower().All(c => name.ToLower().Contains(c.ToString().ToLower()))).ToList();


                Console.WriteLine("ket qua");
                if (result.Count == 0)
                {
                    Console.WriteLine("khong co gia tri nao");
                }
                else
                {
                    foreach (string name in result)
                    {
                        Console.WriteLine(name);
                    }
                }

                Console.WriteLine("Nhập lại không? (Y/N)");
                nhapLai = Console.ReadLine();
            } while (nhapLai.ToUpper() == "Y");


            Console.ReadKey();
        }
    }
}