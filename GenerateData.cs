        private static void GenerateData()
        {
            string hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            string name = Environment.UserName;

            Console.WriteLine("HWID: " + hwid);
            Console.WriteLine("PC Name: " + name);

            Console.WriteLine($"Expiry ({DateTime.Now.ToString("dd-MM-yyyy")}): ");
            string expiry = Console.ReadLine();

            Console.WriteLine("Discord Tag (User#0001): ");
            string dcTag = Console.ReadLine();

            Console.WriteLine($"{hwid}|{name}|{expiry}|{dcTag}");
            Console.ReadKey();
        }
