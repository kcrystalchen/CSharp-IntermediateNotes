using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        private const string Value = "An unexpected error occurred";

        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            // below is global exception error handling block: the exceptions are from the most specific one to the most generic exception

            // defined a stream reader, stream reader is a class for reading any streams of data(files, network, etc)


            try
            {

                // option 2: use using method: using method will create the finally block under the hook
                // so you do not have to create finally block for using() method
                using (var streamReader0 = new StreamReader(@"c:\file.zip"))
                {
                    var content0 = streamReader0.ReadToEnd();
                }


                // option 1: {
                streamReader = new StreamReader(@"c:\file.zip");

                // in try block, we can read the content of the this file
                var content = streamReader.ReadToEnd();
                throw new Exception("opps");


                // } option 1 



                // option calculator {
                Calculator calculator = new Calculator();
                calculator.Divide(5, 0);
                // } option calculator
            }
            // catch the errors from the most specific to the most generic 
            catch (DivideByZeroException ex)    // DivideByZeroException class 
            // if you are using Exception class, it is a parent of all of Excepts
            {
                Console.WriteLine("You can not divide by 0.");
            }
            catch(ArithmeticException ex) // ex is an argument 
            {
                Console.WriteLine("second level exception error.");
            }
            catch (Exception ex)
            {
                // 1. recover from the error
                Console.WriteLine("An unexpected error occurred.");
                // 2. re-throw the error 

            }
            finally // finally block is not applied to using method in try block 

            // finally block, in .Net there are some classes are access unmanaged resources,
            //which these resources are not managed by CLR, it means there is no garbage collection to apply to them.
            //it means we need to manually clean out, by using IDisposable interface, and a method call Dispose()
            // we use finally to call IDisposable method for clean out unmanaged resources


            {
                if (streamReader != null)
                {
                    streamReader.Dispose(); 
                    // if anything goes wrong inside the try block during reading the file, we want to make sure streamReader is closed
                    // if we do not Dispose streamReader, it will keep the file opened on the disk, keep database opens, or keep network opens

                    // so whenever using unmanaged resource, make sure to dispose in the finally block
                }


           //     Console.WriteLine("Finally block is to call the <dispose method> of the class that is using the manage resources");
            }




            // For YouTubeAPI class
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
