using System;
enum Menu
{
   Login = 1,
   Register
}
enum User
{
    Student = 1,
    Employee,
}
namespace MT_Number2
{
    class Program
    {
        static Registerlist personList;
        static void Main(string[] args)
        {
            PrintMenuScreen();//เรียกใช้ เมธอด PrintMenuScreen() เพื่อแสดงหน้าเมนู
        }
        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new Registerlist();/*สร้างพื้นที่stackก่อนเริ่มโปรแกรม*/

        }
        static void PrintMenuScreen()
        {
            Console.Clear();//เคลียร์หน้าต่าง
            PrintHeader();//เรียกเมธอด PrintHeader() เพื่อแสดงข้อความต้อนรับ
            PrintListMenu();//เรียกเมธอด PrintListMenu() เพื่อแสดงลิสต์เมนู
            InputMenuFromKeyBoard();//เรียกเมธอด InputMenuFromKeyBoard()เพื่อแสดงลิสต์เมนู
        }
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Digital Library");//แสดงข้อความWelcome to Digital Library
            Console.WriteLine("--------------------------");//แสดงข้อความ--------------------------
        }
        static void PrintListMenu()
        {
            Console.WriteLine("1.Login");//แสดงข้อความ 1.Login
            Console.WriteLine("2.Register");//แสดงข้อความ 2.Register
        }
        static void InputMenuFromKeyBoard()
        {
            Console.Write("Select Menu : ");//แสดงข้อความ Select Menu : 
            Menu menu = (Menu)(int.Parse(Console.ReadLine())); // รับค่าจากคัวเลขผู้ใช้แล้วเก็บไว้ในตัวแปรชื่อ menu

            CurrentToMenu(menu);//เรียกใช้เมธอด CurrentToMenu() และส่งค่าตัวแปร menu ไปด้วย

        }
        static void CurrentToMenu(Menu menu)
        {
            if (menu == Menu.Login) //นำตัวแปร menu มาเทียบกีบ enum Login ว่ามีค่า1เท่ากันไหม
            {
                ShowInputLoginScreen();//หากใช่ให้เรียกใช้เมธอด ShowInputLoginScreen() เพื่อแสดงหน้าของLogin
            }
            else if (menu == Menu.Register)//นำตัวแปร menu มาเทียบกีบ enum Register ว่ามีค่า2เท่ากันไหม
            {
                ShowInputRegisterScreen();//หากใช่ให้เรียกใช้เมธอด ShowInputRegisterScreen() เพื่อแสดงหน้าของRegister
            }
        }
        static void ShowInputLoginScreen()//หน้าlogin
        {
            Console.Clear();//เคลียร์หน้าต่าง
            PrintHeaderLoginScreen();//เรียกใช้เมธอด PrintHeaderLoginScreen() เพื่อแสดงหัวข้อของหน้าlogin
            InputLoginInformationFromKeyboard();//เรียกใช้เมธอดInputLoginInformationFromKeyboard() เพื่อเริ่มรับค่าจากผู้ใช้
        }
        static void PrintHeaderLoginScreen()
        {
            Console.WriteLine("Login Screen");//แสดงข้อความ Login Screen
            Console.WriteLine("------------");//แสดงข้อความ ------------
        }
        static void InputLoginInformationFromKeyboard()
        {
                LoginScreen loginscreen = CreateLoginScreen();
        }
        static LoginScreen CreateLoginScreen()
        {
            return new LoginScreen(InputName(), InputPassword()); //เรียกใช้เมธอด InputName() กับ InputPassword()
        }
        static string InputName()
        {
            Console.Write("Name: ");//แสดงข้อความ Name: 
            return Console.ReadLine(); //รับค่า
        }
        static string InputPassword()
        {
            Console.Write("Password: ");//แสดงข้อความ Password: 
            return Console.ReadLine();//รับค่า
        }

        static void ShowInputRegisterScreen()//หน้า register
        {
            Console.Clear();//เคลียร์หน้าต่าง
            PrintHeaderRegisterScreen();////เรียกใช้เมธอด PrintHeaderRegisterScreen() เพื่อแสดงหัวข้อของหน้าฑำเรหะำพ
            InputRegisterInformationFromKeyboard();//เรียกใช้เมธอด InputRegisterInformationFromKeyboard()เพื่อเริ่มรับค่าจากผู้ใช้
            PrintMenuScreen();//เรียกใช้เมธอด  PrintMenuScreen() เพื่อแสดงหน้าเมนู
        }
        static void PrintHeaderRegisterScreen()
        {
            Console.WriteLine("Register new Person");//แสดงข้อความ Register new Person
            Console.WriteLine("-------------------");//รับค่า
        }
        static void InputRegisterInformationFromKeyboard()
        {
        
                RegisterScreen registerscreen = CreteRegisterScreen();
        }
       
        static RegisterScreen CreteRegisterScreen()
        {
            return new RegisterScreen(InputName(), InputPassword(), InputTypeofUser());//เรียกใช้เมธอด InputName() กับ InputPassword()
        }
        static string InputTypeofUser()//หน้าเลือกประเภทผู้ใช้งาน
        {
            Console.Write("Input User Type 1 = Student, 2 = Employee: ");//แสดงข้อความ Input User Type 1 = Student, 2 = Employee: 
            User user = (User)(int.Parse(Console.ReadLine())); //รับค่าตัวเลขจากผู้ใช้แล้วเก็บไว้ในตัวแปรuser

            return CurrenttoInputID(user);
        }
        static string CurrenttoInputID(User user) // หน้าใส่ไอดี
        {
            if (user == User.Student)//ตรวจสอบว่า user เท่ากัน enum Student ไหม
            {
              ShowInputStudentID();//เรียกใช้เมธอด ShowInputStudentID()
            }
            else if (user == User.Employee)
            {
              ShowInputEmployeeID();//เรียกใช้เมธอด ShowInputEmployeeID()
            }
            return Console.ReadLine();
        }
        static void ShowInputStudentID()
        {
            Console.Write("Student ID:"); //แสดงข้อความStudent ID:
        }
        static void ShowInputEmployeeID()
        {
            Console.Write("Employee ID:");//แสดงข้อความEmployee ID:
        }
    }
}
