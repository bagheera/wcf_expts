// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
using System;
using System.Runtime.Serialization;

namespace ContentTypes
{
    [DataContract (Namespace="wcf_expts")]
    public class LinkItem
    {

        private long m_id;
        private string m_title;
        private string m_description;
        private DateTime m_dateStart;
        private DateTime m_dateEnd;
        private string m_url;

        [DataMember]
        public DateTime DateStart
        {
            get { return m_dateStart; }
            set { m_dateStart = value; }
        }

        [DataMember]
        public DateTime DateEnd
        {
            get { return m_dateEnd; }
            set { m_dateEnd = value; }
        }

        [DataMember]
        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        [DataMember]
        public long Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        [DataMember]
        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        [DataMember]
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public override string ToString()
        {
            return "title=" + Title + "\ndesc=" + Description + "\nurl=" + Url + "\nstart=" + DateStart + "\nend=" + DateEnd;
        }
    }
}
