
namespace APITest
{
    public class UnitTest1
    {
        Employee res = new Employee();
    }

    public class Employee()
    {


       

        public void GetEmployee()
        {
            var res = GetPhoneNumber();
        }

        public virtual int GetPhoneNumber()
        {
            return 10;
        }
    }
}