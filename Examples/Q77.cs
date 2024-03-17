    internal abstract class Employee
    {
        private String address;
        private long id, mobile;
        private String name;
        //Assume public constructor, getters,setters, toString and other common functions.
        public abstract int CalculateHolidaysPermitted(int month);
    }

    internal class PermanentEmployee : Employee
    {
        public override int CalculateHolidaysPermitted(int month)
        {
            return (month == 12) ? 4 : 3;
        }
    }

    internal class TemporaryEmployee : Employee
    {
        public override int CalculateHolidaysPermitted(int month)
        {
            return 2;
        }
    }
//Replace simple hierarchy with Higher-order functions