
namespace API.TestDummy
{
    public abstract class Processor
    {
        protected virtual void PostProcessJob(string input)
        {
            //Do some work.
        }

        public void ProcessJob(string input)
        {
            try
            {
                PostProcessJob(input);
            }
            catch (Exception)
            {

            }
        }
    }
}
