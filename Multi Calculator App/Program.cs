using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace Multi_Calculator_App
{
    public static class Program

    {
        static void Main(string[] args)
        {
            // Start the program
            StartProgram();
        }
        static void StartProgram()
        {
            //to support arabic language in VS
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("1: للمتابعة باللغة العربية");
            Console.WriteLine("2: Continue In English Language");
            Console.WriteLine("3: Exit / لمغادرة البرنامج\n");
            Console.Write("Enter your choice number / ادخل رقم اختيارك:\n");

            int language = Convert.ToInt16(Console.ReadLine());
            switch (language)
            {
                case 1:
                    arabic();
                    break;

                case 2:
                    eng();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("اختيار خاطئ، اعد المحاولة");
                    Console.WriteLine("Invalid choice, try again\n");
                    StartProgram();
                    break;
            }
        }

        static void eng()
        {
            System.Data.SqlClient.SqlConnection sqlConnection;
            string connectionString = @"Data Source=DESKTOP-QUB8L8T\SQLEXPRESS;Initial Catalog=UserInfoDB;Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                Console.WriteLine("\n1: Login into an existing account\n2: Create a new account\n");
                Console.Write("Enter your choice number: \n");
                int account = Convert.ToInt16(Console.ReadLine());
                switch (account)
                {
                    case 1:
                        Console.WriteLine("Enter UserName:");
                        string EUserName = Console.ReadLine();

                        Console.WriteLine("Enter Password:");
                        string EPassword = Console.ReadLine();

                        string readQuery = "SELECT * FROM UserInfo WHERE UserName = @Username";

                        using (SqlCommand command = new SqlCommand(readQuery, sqlConnection))
                        {
                            command.Parameters.AddWithValue("@Username", EUserName);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                string userNameFromDB = reader["UserName"].ToString();
                                string passwordFromDB = reader["Password"].ToString();

                                if (EPassword == passwordFromDB)
                                {
                                    Console.WriteLine("\nLogin successful!\n");
                                    string WlcMessage = reader["FName"].ToString();
                                    Console.WriteLine($"Welcome {WlcMessage}\n");
                                }
                                else
                                {
                                    Console.WriteLine("Login failed. Please check your password.");
                                    eng();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Login failed. User not found.");
                                eng();
                            }
                            reader.Close();
                            while (true)

                            {
                                Console.WriteLine("\n1: Show exactly how Old You Are.");
                                Console.WriteLine("2: Calculate The Difference Between Two Dates.");
                                Console.WriteLine("3: View General Information About Your Health.\n");
                                Console.WriteLine("4: Update your information.");
                                Console.WriteLine("5: Exit.");
                                Console.WriteLine("6: Reselect language.\n");
                                Console.Write("Enter your choice number: \n");

                                int choice = Convert.ToInt16(Console.ReadLine());
                                switch (choice)

                                {
                                    case 1:
                                        CalculateAge();
                                        break;

                                    case 2:
                                        CalculateDateDifference();
                                        break;

                                    case 3:
                                        CalculateHealth();
                                        break;

                                    case 4:

                                        bool continueModifying = true;

                                        while (continueModifying)
                                        {
                                            Console.WriteLine("What do you want to modify?");
                                            Console.WriteLine("1: Modify your First Name.");
                                            Console.WriteLine("2: Modify your Last Name.");
                                            Console.WriteLine("3: Modify your Weight.");
                                            Console.WriteLine("4: Modify your Activity Level.");
                                            Console.WriteLine("5: Change your Password.");
                                            Console.WriteLine("6: Exit\n");
                                            int updateNum = Convert.ToInt16(Console.ReadLine());

                                            if (updateNum == 6)
                                            {
                                                continueModifying = false;
                                                continue;
                                            }

                                            string updateQuery = "UPDATE UserInfo SET ";

                                            using (SqlCommand command1 = new SqlCommand("", sqlConnection))
                                            {
                                                switch (updateNum)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Enter New First Name:");
                                                        string newValue1 = Console.ReadLine();
                                                        updateQuery += "FName = @NewValue1";
                                                        command1.Parameters.AddWithValue("@NewValue1", newValue1);
                                                        break;

                                                    case 2:
                                                        Console.WriteLine("Enter New Last Name:");
                                                        string newValue2 = Console.ReadLine();
                                                        updateQuery += "LName = @NewValue2";
                                                        command1.Parameters.AddWithValue("@NewValue2", newValue2);
                                                        break;

                                                    case 3:
                                                        Console.WriteLine("Enter New Weight:");
                                                        double newValue3 = Convert.ToDouble(Console.ReadLine());
                                                        updateQuery += "Weight = @NewValue3";
                                                        command1.Parameters.AddWithValue("@NewValue3", newValue3);
                                                        break;

                                                    case 4:
                                                        Console.WriteLine("Enter New Activity Level:");
                                                        string newValue4 = Console.ReadLine();
                                                        updateQuery += "ActivityLevel = @NewValue4";
                                                        command1.Parameters.AddWithValue("@NewValue4", newValue4);
                                                        break;

                                                    case 5:
                                                        Console.WriteLine("Enter New Password:");
                                                        string newValue5 = Console.ReadLine();
                                                        updateQuery += "Password = @NewValue5";
                                                        command1.Parameters.AddWithValue("@NewValue5", newValue5);
                                                        break;

                                                    default:
                                                        Console.WriteLine("Invalid option.");
                                                        continue;
                                                }

                                                // Add the common part of the SQL query
                                                updateQuery += " WHERE UserName = @NUsername";
                                                command1.Parameters.AddWithValue("@NUsername", EUserName);

                                                command1.CommandText = updateQuery;

                                                // Execute the update query
                                                int rowsAffected = command1.ExecuteNonQuery();

                                                // Check how many rows were updated
                                                if (rowsAffected > 0)
                                                {
                                                    Console.WriteLine(rowsAffected + " rows updated.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No rows updated.");
                                                }

                                                Console.WriteLine("Do you want to modify another piece of data? (Y/N)");
                                                string continueResponse = Console.ReadLine().Trim().ToUpper();
                                                if (continueResponse != "Y")
                                                {
                                                    continueModifying = false;
                                                }
                                            }
                                        }

                                        break;
                                    case 5:
                                        Console.WriteLine("Exit done.");
                                        break;

                                    case 6:
                                        StartProgram();
                                        break;

                                    default:
                                        Console.WriteLine("Invalid choice!");
                                        break;
                                }

                                Console.Write("\nPress any key to continue or 'q' to quit: ");

                                if (Console.ReadLine().ToLower() == "q")

                                {
                                    break;
                                }
                            }


                            void CalculateAge()
                            {
                                Console.WriteLine("\n=========================\n");
                                Console.WriteLine("\nAge Calculator Program");
                                string birthDateFromDB = reader["BirthDate"].ToString();
                                DateTime birthDate = Convert.ToDateTime(birthDateFromDB);

                                DateTime now = DateTime.Now;
                                TimeSpan ageTimeSpan = now - birthDate;

                                int years = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);
                                int months = (int)Math.Floor((ageTimeSpan.TotalDays % 365.242199) / 30.4368499);
                                int days = (int)Math.Floor(ageTimeSpan.TotalDays % 30.4368499);

                                int nextBirthdayMonths = (int)Math.Floor(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) / 30.4368499);
                                int nextBirthdayDays = (int)Math.Ceiling(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) % 30.4368499);

                                int totalDays = (int)ageTimeSpan.TotalDays;
                                int totalHours = (int)ageTimeSpan.TotalHours;
                                Int64 totalMinutes = (Int64)ageTimeSpan.TotalMinutes;
                                Int64 Seconds = (Int64)ageTimeSpan.TotalSeconds;
                                string totalSeconds = Seconds.ToString("N0");
                                Int64 HeartBeats = totalMinutes * 80;
                                string totalHeartBeats = HeartBeats.ToString("N0");
                                double totalFoodTonnes = Math.Round((years * 675.0 / 1000.0), 3);
                                int totalWaterLitres = (int)Math.Floor(totalDays * 1.892079611964252);
                                double totalSleepYears = Math.Round((totalDays / 365.242199) * 0.333333333333, 2);

                                Console.WriteLine("\n=========================\n");

                                if (days == 0 && months == 0)

                                {
                                    Console.WriteLine("\nHappy Birthday < 3");
                                }

                                Console.WriteLine($"The day you were born is : {birthDate.DayOfWeek}");
                                Console.WriteLine($"\nYour Age Is {years} Years & {months} Months & {days} Days.");
                                Console.WriteLine($"Next Birthday In {nextBirthdayMonths} Month & {nextBirthdayDays} Day");
                                Console.WriteLine($@"You Lived For:
{years} Years.
{months} Months.
{(int)(totalDays / 7)} Weeks.
{totalDays} Days.
{totalHours} Hours.
{totalMinutes} Minutes.
{totalSeconds} Seconds.");
                                Console.WriteLine("Amazing Facts About You…\n");
                                Console.WriteLine($"Your heart has beat for {totalHeartBeats} Times.\nYou ate {totalFoodTonnes} Ton of food.\nYou drank {totalWaterLitres} litres of water.");
                                Console.WriteLine($"You have slept for {totalSleepYears} Years.");

                            }

                            void CalculateDateDifference()
                            {
                                Console.WriteLine("\nDifference Between Dates Calculator\n");
                                Console.WriteLine("Enter Dates Like[Ex: 2000 4 16]\n");
                                DateTime firstDate, secondDate;
                                Console.WriteLine("Enter First Date: ");
                                firstDate = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("\nEnter Second Date: ");
                                secondDate = Convert.ToDateTime(Console.ReadLine());

                                TimeSpan difference = firstDate - secondDate;
                                int totalDays = (int)difference.TotalDays;
                                int totalYears = (int)(totalDays / 365.242199);
                                double remainingDays = totalDays % 365.242199;
                                int totalMonths = (int)(remainingDays / 30.4368499);
                                int remainingMonthsDays = (int)(remainingDays % 30.4368499);

                                Console.WriteLine($"\nThe Difference Between The First Date And The Second Date Is…\n{totalYears}Years & {totalMonths} Months & {remainingMonthsDays} Days.");
                            }

                            void CalculateHealth()
                            {
                                // Read user inputs for weight, height, age, gender, and activity level from DataBase
                                string weightFromDB = reader["Weight"].ToString();
                                double weight = Convert.ToDouble(weightFromDB);

                                string heightFromDB = reader["Height"].ToString();
                                double height = Convert.ToDouble(heightFromDB);

                                string ageFromDB = reader["Age"].ToString();
                                int age = Convert.ToInt32(ageFromDB);

                                string genderFromDB = reader["Gender"].ToString();
                                string gender = Convert.ToString(genderFromDB);

                                string activityFromDB = reader["ActivityLevel"].ToString();
                                string activityLevel = Convert.ToString(activityFromDB);

                                // Calculate BMI
                                double bmi = Math.Round(weight / Math.Pow(height / 100, 2), 1);

                                // Calculate basal metabolic rate (BMR)
                                double bmr = gender == "male" ? 66 + (13.7 * weight) + (5 * height) - (6.8 * age) : 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);

                                // Calculate daily calorie needs based on activity level
                                double dailyCalorieNeeds = 0;
                                switch (activityLevel)

                                {
                                    case "lazy":
                                        dailyCalorieNeeds = bmr * 1.2;
                                        break;
                                    case "lightly":
                                        dailyCalorieNeeds = bmr * 1.375;
                                        break;
                                    case "medium":
                                        dailyCalorieNeeds = bmr * 1.55;
                                        break;
                                    default:
                                        dailyCalorieNeeds = bmr * 1.725;
                                        break;
                                }

                                int cal = Convert.ToInt32(dailyCalorieNeeds);

                                // Determine BMI category
                                String category = "";
                                switch (bmi)

                                {
                                    case double b when b < 18.5:
                                        category = "Underweight";
                                        break;
                                    case double b when b < 25:
                                        category = "Normal weight";
                                        break;
                                    case double b when b < 30:
                                        category = "Overweight";
                                        break;
                                    default:
                                        category = "Obesity";
                                        break;
                                }
                                // Calculate ideal weight
                                double idealWeight = gender == "male" ? height - 105 : height - 110;

                                Console.WriteLine("\n ========================\n");

                                // Display BMI and category
                                Console.WriteLine("\nYour BMI Is: " + bmi);
                                Console.WriteLine("Your BMI Category Is: " + category);

                                // Display daily calorie needs
                                Console.WriteLine("Your daily calorie needs are: " + cal + " calories");

                                // Display ideal weight
                                Console.WriteLine("Your Ideal Weight Is: " + idealWeight);

                                // Provide advice based on BMI category
                                if (category == "Underweight")

                                {
                                    Console.WriteLine("\nYour weight is under the minimum recommended weight.We advise you to do the following:");
                                    Console.WriteLine("\n1.Eat more meals.");
                                    Console.WriteLine("2.Drink smoothies.");
                                    Console.WriteLine("3.Monitor and avoid drinks and foods that reduce appetite.");
                                    Console.WriteLine("4.Exercise regularly.");
                                    Console.WriteLine("\nIf you do not find a result, we recommend that you see a doctor.");
                                }
                                else if (category == "Obesity")
                                {
                                    Console.WriteLine("\nYour weight is over the maximum recommended weight, we advise you to do the following:");
                                    Console.WriteLine("\n1. Exercise regularly.");
                                    Console.WriteLine("2. Follow a diet with specialist follow-up.");
                                    Console.WriteLine("3. Medicinal obesity treatment prescribed by a doctor.");
                                    Console.WriteLine("4. Surgical treatment.");
                                    Console.WriteLine("5. Do sports with the follow-up of a specialist or a professional coach.");
                                }
                                else if (category == "Overweight")
                                {
                                    Console.WriteLine("\nYour weight exceeds the recommended limit. To prevent obesity, follow the following steps:");
                                    Console.WriteLine("\n1. Eat five small meals a day.");
                                    Console.WriteLine("2. Avoid processed foods such as sausage and canned meat.");
                                    Console.WriteLine("3. Reduce your sugar consumption.");
                                    Console.WriteLine("4. Reduce the use of artificial sweeteners.");
                                    Console.WriteLine("5. Avoid saturated fats.");
                                    Console.WriteLine("6. Cook food at home.");
                                    Console.WriteLine("7. Exercise regularly.");
                                }
                            }
                        }
                        break;

                    case 2:
                        // Add code for creating a new account
                        Console.WriteLine("Enter your first name:");
                        string Fname = Console.ReadLine();

                        Console.WriteLine("Enter your last name:");
                        string Lname = Console.ReadLine();

                        Console.WriteLine("Enter your Email:");
                        string Email = Console.ReadLine();

                        Console.WriteLine("Create a UserName:");
                        string UserName = Console.ReadLine();

                        string Password = GetUserInput("Create a Password:");
                        string rePassword = GetUserInput("Re-enter Password:");

                        while (Password != rePassword)
                        {
                            Console.WriteLine("Passwords do not match. Please re-enter.");
                            Password = GetUserInput("Create a Password:");
                            rePassword = GetUserInput("Re-enter Password:");
                        }

                        Console.WriteLine("Enter your BirthDate (YYYY MM DD):");
                        DateTime BirthDate = Convert.ToDateTime(Console.ReadLine());
                        DateTime now = DateTime.Now;
                        TimeSpan ageTimeSpan = now - BirthDate;
                        int Age = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);

                        string gender = SelectGender();

                        Console.WriteLine("Enter your Weight (KG):");
                        int Weight = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter your Height (CM):");
                        int Height = Convert.ToInt16(Console.ReadLine());

                        string activityLevel = SelectActivity();

                        // Calculate BMI
                        double BMI = Math.Round(Weight / Math.Pow(Height / 100.0, 2), 1);

                        // Insert user data into the database
                        string insertQuery = "INSERT INTO UserInfo (FName, LName, Email, UserName, Password, BirthDate, Gender, Height, Weight, Age, ActivityLevel, BMI) " +
                                             "VALUES (@Fname, @Lname, @Email, @UserName, @Password, @BirthDate, @gender, @Height, @Weight, @Age, @activityLevel, @BMI)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection))
                        {
                            insertCommand.Parameters.AddWithValue("@Fname", Fname);
                            insertCommand.Parameters.AddWithValue("@Lname", Lname);
                            insertCommand.Parameters.AddWithValue("@Email", Email);
                            insertCommand.Parameters.AddWithValue("@UserName", UserName);
                            insertCommand.Parameters.AddWithValue("@Password", Password);
                            insertCommand.Parameters.AddWithValue("@BirthDate", BirthDate);
                            insertCommand.Parameters.AddWithValue("@gender", gender);
                            insertCommand.Parameters.AddWithValue("@Height", Height);
                            insertCommand.Parameters.AddWithValue("@Weight", Weight);
                            insertCommand.Parameters.AddWithValue("@Age", Age);
                            insertCommand.Parameters.AddWithValue("@activityLevel", activityLevel);
                            insertCommand.Parameters.AddWithValue("@BMI", BMI);

                            insertCommand.ExecuteNonQuery();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice!\n");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            static string GetUserInput(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }

            static string SelectGender()
            {
                while (true)
                {
                    Console.WriteLine("Enter your Gender (male/female):");
                    string gender = Console.ReadLine().ToLower();

                    if (gender == "male" || gender == "female")
                    {
                        return gender;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'male' or 'female'.");
                    }
                }
            }

            static string SelectActivity()
            {
                while (true)
                {
                    Console.WriteLine("Please enter your activity level (lazy, lightly, medium, active): ");
                    string activityLevel = Console.ReadLine().ToLower();

                    if (activityLevel == "lazy" || activityLevel == "lightly" || activityLevel == "medium" || activityLevel == "active")
                    {
                        return activityLevel;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'lazy', 'lightly', 'medium', or 'active'.");
                    }
                }
            }


        }
        static void arabic()
        {
            Console.WriteLine("\nمرحبا بك في اول برنامج لي");

            while (true)
            {
                Console.WriteLine("\n1: لحساب كم عمرك.");
                Console.WriteLine("2: لحساب الفرق بين تاريخين.");
                Console.WriteLine("3: لعرض معلومات عامة عن صحتك.\n");
                Console.WriteLine("4: للخروج");
                Console.WriteLine("5: لإعادة اختيار اللغة\n");
                Console.Write("ادخل رقم اختيارك: \n");

                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CalculateAge();
                        break;

                    case 2:
                        CalculateDateDifference();
                        break;

                    case 3:
                        CalculateHealth();
                        break;

                    case 4:
                        Console.WriteLine("تم الخروج.");
                        break;

                    case 5:
                        StartProgram();
                        break;

                    default:
                        Console.WriteLine("اختيار خاطئ!");
                        break;
                }

                Console.Write("\nاضغط اي زر للإستمرار او 'q' للخروج من التطبيق: ");

                if (Console.ReadLine().ToLower() == "q")
                {
                    break;
                }
            }


            void CalculateAge()
            {
                Console.WriteLine("\nبرنامج حساب العمر");
                Console.Write("ادخل تاريخ ميلادك (YYYY MM DD): ");
                DateTime birthDate;

                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    DateTime now = DateTime.Now;
                    TimeSpan ageTimeSpan = now - birthDate;

                    int years = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);
                    int months = (int)Math.Floor((ageTimeSpan.TotalDays % 365.242199) / 30.4368499);
                    int days = (int)Math.Floor(ageTimeSpan.TotalDays % 30.4368499);

                    int nextBirthdayMonths = (int)Math.Floor(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) / 30.4368499);
                    int nextBirthdayDays = (int)Math.Ceiling(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) % 30.4368499);

                    int totalDays = (int)ageTimeSpan.TotalDays;
                    int totalHours = (int)ageTimeSpan.TotalHours;
                    Int64 totalMinutes = (Int64)ageTimeSpan.TotalMinutes;
                    Int64 Seconds = (Int64)ageTimeSpan.TotalSeconds;
                    string totalSeconds = Seconds.ToString("N0");
                    Int64 HeartBeats = totalMinutes * 80;
                    string totalHeartBeats = HeartBeats.ToString("N0");

                    double totalFoodTonnes = Math.Round((years * 675.0 / 1000.0), 3);
                    int totalWaterLitres = (int)Math.Floor(totalDays * 1.892079611964252);
                    double totalSleepYears = Math.Round((totalDays / 365.242199) * 0.333333333333, 2);

                    Console.WriteLine("\n========================\n");

                    if (days == 0 && months == 0)
                    {
                        Console.WriteLine("\nكل عام وانت بخير <3");
                    }
                    CultureInfo arabicCulture = new CultureInfo("ar-SA"); // Create an instance of Arabic culture

                    Console.WriteLine("اليوم الذي ولدت فيه هو " + birthDate.DayOfWeek);
                    Console.WriteLine("\nعمرك " + years + " سنة و " + months + " اشهر و " + days + " يوم.");
                    Console.WriteLine("ذكرى يوم ميلادك بعد " + nextBirthdayMonths + " اشهر و " + nextBirthdayDays + " يوم.");
                    Console.WriteLine("لقد عشت لمدة " + years + " سنة " + months + " اشهر " + ((int)(totalDays / 7)) + " اسبوع " + totalDays + " يوم " + totalHours + " ساعة " + totalMinutes + " دقيقة " + totalSeconds + " ثانية.");
                    Console.WriteLine("حقائق مذهلة عنك…\n");
                    Console.WriteLine("قام قلبك بالنبض " + totalHeartBeats + " مرة.\nلقد اكلت " + totalFoodTonnes + " طن من الطعام.\nلقد شربت " + totalWaterLitres + " لتر من الماء.");
                    Console.WriteLine("لقد نمت لمدة " + totalSleepYears + " سنة.");
                }
            }

            void CalculateDateDifference()
            {
                Console.WriteLine("\nحاسبة الفرق بين تاريخين\n");
                Console.WriteLine("ادخل التاريخين على صورة: [16 4 2000]\n");
                DateTime firstDate, secondDate;
                Console.WriteLine("ادخل التاريخ الاول: ");
                firstDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nادخل التاريخ الثاني: ");
                secondDate = Convert.ToDateTime(Console.ReadLine());

                TimeSpan difference = firstDate - secondDate;
                int totalDays = (int)difference.TotalDays;
                int totalYears = (int)(totalDays / 365.242199);
                double remainingDays = totalDays % 365.242199;
                int totalMonths = (int)(remainingDays / 30.4368499);
                int remainingMonthsDays = (int)(remainingDays % 30.4368499);

                Console.WriteLine("\nالفرق بين التاريخ الاول والثاني هو…\n" + totalYears + " سنة و " + totalMonths + " اشهر و " + remainingMonthsDays + " يوم.");
            }

            void CalculateHealth()
            {
                // Read user inputs for weight, height, age, gender, and activity level
                Console.WriteLine("ادخل وزنك بالكيلو غرام: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("ادخل طولك بالسنتيميتر: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("ادخل عمرك: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Validate user input for gender
                Console.WriteLine("ادخل جنسك: \n1: ذكر\n2: أنثى");
                Console.Write("ادخل اختيارك: \n");
                int gender = Convert.ToInt16(Console.ReadLine());
                double bmr = 0;
                // Calculate basal metabolic rate (BMR)
                switch (gender)
                {
                    case 1:
                        bmr = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
                        break;
                    case 2:
                        bmr = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
                        break;
                    default:
                        Console.WriteLine("#ادخال خاطئ، حاول مجددا#");

                        break;
                }

                Console.WriteLine("ادخل مستوى نشاطك... \n1: لكثير الجلوس\n2: لقليل النشاط\n3: لمتوسط النشاط\n4: للنشيط");

                double bmi = Math.Round(weight / Math.Pow(height / 100, 2), 1);

                // Calculate daily calorie needs based on activity level
                double dailyCalorieNeeds = 0;

                // Validate user input for activity level
                Console.Write("ادخل اختيارك: \n");
                int activityLevel = Convert.ToInt16(Console.ReadLine());
                switch (activityLevel)
                {
                    case 1:
                        dailyCalorieNeeds = bmr * 1.2;
                        break;
                    case 2:
                        dailyCalorieNeeds = bmr * 1.375;
                        break;
                    case 3:
                        dailyCalorieNeeds = bmr * 1.55;
                        break;
                    case 4:
                        dailyCalorieNeeds = bmr * 1.725;
                        break;
                    default:
                        Console.WriteLine("#ادخال خاطئ، حاول مجددا#");

                        break;
                }

                int cal = Convert.ToInt32(dailyCalorieNeeds);

                // Determine BMI category
                String category = "";
                switch (bmi)
                {
                    case double b when b < 18.5:
                        category = "النحافة";
                        break;
                    case double b when b < 25:
                        category = "طبيعي";
                        break;
                    case double b when b < 30:
                        category = "وزن زائد";
                        break;
                    default:
                        category = "السمنة";
                        break;
                }
                // Calculate ideal weight
                double idealWeight = gender == 'M' ? height - 105 : height - 110;

                Console.WriteLine("\n========================\n");

                // Display BMI and category
                Console.WriteLine("\nمؤشر كتلة جسمك هو :" + bmi);
                Console.WriteLine("فئة وزن جسمك هي: " + category);

                // Display daily calorie needs
                Console.WriteLine("يحتاج جسدك الى " + cal + " سعرة يوميا");

                // Display ideal weight
                Console.WriteLine("وزنك المثالي هو : " + idealWeight);

                // Provide advice based on BMI category
                if (category == "النحافة")
                {
                    Console.WriteLine("\nوزنك يقل عن الحد الأدنى الموصى به. ننصحك باتباع ما يلي:");
                    Console.WriteLine("\n1. تناول وجبات أكثر في اليوم.");
                    Console.WriteLine("2. شرب العصائر السموثي.");
                    Console.WriteLine("3. مراقبة وتجنب المشروبات والأطعمة التي تقلل الشهية.");
                    Console.WriteLine("4. ممارسة التمارين الرياضية بانتظام.");
                    Console.WriteLine("\nإذا لم تحصل على نتائج ملموسة، نوصيك بزيارة الطبيب.");
                }
                else if (category == "السمنة")
                {
                    Console.WriteLine("\nوزنك يتجاوز الحد الأقصى الموصى به، ننصحك باتباع ما يلي:");
                    Console.WriteLine("\n1. ممارسة التمارين الرياضية بانتظام.");
                    Console.WriteLine("2. اتباع نظام غذائي مع متابعة أخصائي تغذية.");
                    Console.WriteLine("3. العلاج الدوائي للسمنة الموصوف من قبل الطبيب.");
                    Console.WriteLine("4. العلاج الجراحي.");
                    Console.WriteLine("5. ممارسة الرياضة بمتابعة أخصائي أو مدرب محترف.");
                }
                else if (category == "وزن زائد")
                {
                    Console.WriteLine("\nوزنك يتجاوز الحد الموصى به. للوقاية من السمنة، اتبع الخطوات التالية:");
                    Console.WriteLine("\n1. تناول خمس وجبات صغيرة في اليوم.");
                    Console.WriteLine("2. تجنب الأطعمة المصنعة مثل السجق واللحوم المعلبة.");
                    Console.WriteLine("3. قلل استهلاكك للسكر.");
                    Console.WriteLine("4. قلل استخدام المحليات الاصطناعية.");
                    Console.WriteLine("5. تجنب الدهون المشبعة.");
                    Console.WriteLine("6. قم بطهي الطعام في المنزل.");
                    Console.WriteLine("7. مارس التمارين بانتظام.");
                }
            }
        }
    }
}