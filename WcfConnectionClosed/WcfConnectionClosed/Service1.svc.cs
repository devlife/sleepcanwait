using System.Linq;

namespace WcfConnectionClosed
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public TryEnumWithNoDefaultValueResponse TryEnumWithNoDefaultValue()
        {
            return new TryEnumWithNoDefaultValueResponse();
        }

        public TryDeferredExecutionResponse TryDeferredExecution()
        {
            // NOTE : Works if you don't use the using statement

            using (var context = new Database1Entities())
            {
                var response = new TryDeferredExecutionResponse
                    {
                        Tables = context.Tables.OrderBy(t => t.Field1)
                    };

                return response; 
            }
        }

        public TryReadOnlyDataContractResponse TryReadOnlyDataContract()
        {
            return new TryReadOnlyDataContractResponse();
        }
    }
}