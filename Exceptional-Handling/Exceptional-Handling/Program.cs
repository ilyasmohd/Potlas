using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exceptional_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int returnValue=0;
            try
            {
                throw new Exception();

                returnValue = MyExceptionMethod();
            }
            catch(Exception ex)
            {
                Console.WriteLine("the main catch block");
            }
            if (returnValue == -1)
            {
                Console.WriteLine("some exception has happend");
            }
            else
            {
                //afasdfasfjosdfosadfosad fs soxofnsoausnxos fo
            }
            //try
            //{
            //    //connectiono.open()
            //    int[] array = new int[2];
            //    array[10] = 9809;
            //    //connection.close()
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("An error has occured, the error is "+ex.Message);
            //}
            //finally
            //{
            //    //connection.close();
            //    Console.WriteLine("the finally block has been executed");
            //}

        }

        public static int MyExceptionMethod()
        {
            try
            {
                try
                {
                    int myint;
                    myint = 0;

                    return 100 / myint;
                }

                catch (IndexOutOfRangeException exMessage)
                {
                    Console.WriteLine("index out of range error");
                    return -1;
                }
                catch (FieldAccessException ex)
                {
                    Console.WriteLine("file access error");
                }
                catch (FileNotFoundException ex)
                {
                   
                    Console.WriteLine("file not found error");
                }
                //catch (Exception ex)
                //{
                //    //baseclass obj=new derivedClass()
                //}

                finally
                {
                    Console.WriteLine("the finally block has been exeucted");
                }
            }
            catch(FieldAccessException ex)
            {
                Console.WriteLine("the outer exceptioin has occured");
            }
            

            return 100;
        }
    }
}
