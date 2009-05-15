// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using ContentTypes;

namespace GigManager
{
    [ServiceContract(
        Name = "GigManagerServiceContract", 
        Namespace = "http://www.thatindigogirl.com/samples/2006/06", 
        SessionMode = SessionMode.NotAllowed)]
    public interface IGigManagerService
    {
        [OperationContract]
        void SaveGig(LinkItem item);

        [OperationContract]
        LinkItem GetGig();
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class GigManagerService : IGigManagerService
    {

        private LinkItem m_linkItem;

        #region IGigManager Members

        public void SaveGig(LinkItem item)
        {
            Console.WriteLine("SaveGig called with "+ item);
            m_linkItem = item;
        }

        public LinkItem GetGig()
        {
            return m_linkItem;
        }

        #endregion
    }
}
