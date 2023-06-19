        public static void Request()
        {
            try
            {
                string hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
                string name = Environment.UserName;
                string api = "// INSERT HERE YOUR PASTEBIN RAW URL //";

                var textFromFile = new WebClient().DownloadString("https://pastebin.com/raw/XBqUbHVB");
                string[] lines = textFromFile.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                foreach (string line in lines)
                {
                    if (line.Contains(hwid))
                    {
                        var auth = line.Split('|');

                        if (auth[1] == name)
                        {
                            var date = auth[2].Split('-');
                            DateTime currentDate = DateTime.Now;
                            DateTime expiryDate = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]), 0, 0, 0);
                            int result = DateTime.Compare(currentDate, expiryDate);

                            if (result < 0)
                            {

                                // If Login Successful
                                Console.WriteLine($"HWID: {auth[0]}");
                                Console.WriteLine($"Name: {auth[1]}");
                                Console.WriteLine($"Expiry: {auth[2]}");
                                Console.WriteLine($"Discord Tag: {auth[3]}");
                            }
                            else
                            {
                                // If User Sub Expired
                                Console.WriteLine("The subscription has expired.");
                            }
                        }
                        else
                        {
                            // If PC Name does not match with DB
                            Console.WriteLine($"The PC name does not match with Database. ({name})");
                        }
                    }
                }
                Console.ReadKey();
            } catch
            {

            }
        }
    }
