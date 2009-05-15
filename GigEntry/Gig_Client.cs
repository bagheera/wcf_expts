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
            gig.GigManagerServiceContractClient client;
                        client = new gig.GigManagerServiceContractClient();
            gig.LinkItem item = new gig.LinkItem();
            item.m_description = "some desc";
            item.m_title = "some boring event";
            item.m_url = "http://askfdj.com";
            item.m_dateStart = new DateTime(2009, 10, 31, 22, 30, 0);
            item.m_dateEnd = new DateTime(2009, 11, 01, 5, 30, 0);
            client.SaveGig(item);

        }
    }
}