using System.Collections.Generic;
using System.Linq;

namespace ComputerStore.Database
{
    public static class QueryService
    {
        //Execute database queries
        public static List<Computer> GetAllComputers()
        {
            return DatabaseContext.GetEntities().Computers;
        }

        public static Computer FindComputer(string computerName)
        {
            var entities = DatabaseContext.GetEntities();
            var query = from computer in entities.Computers
                where computer.Name.ToUpper() == computerName.ToUpper()
                select computer;
            return query.FirstOrDefault();
        }

        public static Computer FindComputerByGuid(string guid)
        {
            var entities = DatabaseContext.GetEntities();
            var query = from computer in entities.Computers
                where computer.Guid.ToUpper() == guid.ToUpper()
                select computer;
            return query.FirstOrDefault();
        }

        public static Order FindOrder(string id)
        {
            var entities = DatabaseContext.GetEntities();
            var query = from order in entities.Orders
                where order.Guid.ToUpper() == id.ToUpper()
                select order;
            return query.FirstOrDefault();
        }
    }
}