// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
   
using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace Host
{
    class GigServiceHost
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(GigManager.GigManagerService)))
            {
                host.Open();

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate Host");
                Console.ReadLine();
            }
        }
    }
}
