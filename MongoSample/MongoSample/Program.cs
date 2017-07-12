using MongoDB.Bson;

namespace MongoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MongoDBContext();

            // Get all employees
            var allEmployees = db.GetEmployee();

            // Get by id
            var employeeById = db.GetEmployee(new ObjectId("595152fd28c7b9be12251719"));

            // Get by name
            var employeesByName = db.GetEmployeeByName("Türhan");

            // Create new employee
            var employee = new Employee();
            employee.Name = "Türhan";
            employee.Surname = "Yıldırım";
            employee.Email = "yildirimturhan@gmail.com";
            db.Create(employee);

            // Update existing record
            db.Update(new ObjectId("595152fd28c7b9be12251719"), employee);

            // Remove record
            db.Remove(new ObjectId("595152fd28c7b9be12251719"));
        }
    }
}
