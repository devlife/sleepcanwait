using System.Linq;

namespace WcfConnectionClosed
{
    public class Service1 : IService1
    {
        // This operation should work without an issue
        public bool WorksFine()
        {
            return true;
        }

        // This operation should throw a connection closed exception because we
        // are not setting the enum to a valid value and there is no default
        public TryEnumWithNoDefaultValueResponse TryEnumWithNoDefaultValue()
        {
            return new TryEnumWithNoDefaultValueResponse();
        }

        // This operation should throw a connection closed exception because we
        // are not materializing the deferred execution of the OrderBy operation.
        // NOTE : This seems to be fixed with .NET 4.5.
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

        // This operation should throw a connection closed exception because
        // the DataContractSerializer doesn't know how to serialize a value 
        // on a property with no setter.
        public TryReadOnlyDataContractResponse TryReadOnlyDataContract()
        {
            return new TryReadOnlyDataContractResponse();
        }
    }
}