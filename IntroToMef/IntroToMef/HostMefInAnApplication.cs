using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace IntroToMef
{
    public class HostMefInAnApplication
    {
        /// <summary>
        /// The Compose method is responsible for creating our container and manually injecting our dependencies.
        /// We wouldn't typically want to do things this way but it can be done this way if needed.
        /// </summary>
        private void Compose()
        {
            var container = new CompositionContainer();

            // NOTE : Before this line executes, Logger is null.  Once this line is executed, our class instance is composed with
            // the parts that it needs to run.  Additionally, it is worth noting that there are multiple ILogger implementations is this solution.
            // However, we are only adding a single implementation to the container.
            container.ComposeParts(this, new SomeRandomLogger());
        }
    }
}