    internal class Employee1
    {
        private readonly Func<int, int> hoildaysPermitted;
        private string address;
        private long id, mobile;
        private string name;
        private int numberOfHolidays;
        //Assume getters,setters, toString and other common functions.

        private Employee1(Func<int, int> holidaysPermitted)
        {
            hoildaysPermitted = holidaysPermitted;
        }

        public static Employee1 CreatePermanentEmployee()
        {
            return new Employee1(PermanentEmployeeHolidays);
        }

        public static Employee1 CreateTemporaryEmployee()
        {
            return new Employee1(TemporaryEmployeeHolidays);
        }

        private static int PermanentEmployeeHolidays(int month)
        {
            return (month == 12) ? 4 : 3;
        }

        private static int TemporaryEmployeeHolidays(int month)
        {
            return 2;
        }
    }
