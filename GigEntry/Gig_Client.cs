// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System;
using System.Collections.Generic;

namespace GigEntry
{
    static class Gig_Client
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            gig.GigManagerServiceContractClient client;
                        client = new gig.GigManagerServiceContractClient();
            gig.LinkItem item = new gig.LinkItem();
            item.Description = "some desc";
            item.Title = "some boring event";
            item.Url = "http://askfdj.com";
            item.DateStart = new DateTime(2009, 10, 31, 22, 30, 0);
            item.DateEnd = new DateTime(2009, 11, 01, 5, 30, 0);
            client.SaveGig(item);

        }
    }
}