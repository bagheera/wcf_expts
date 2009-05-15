// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
using System;
using System.Runtime.Serialization;

namespace ContentTypes
{
    [DataContract]
    public class LinkItem
    {

        [DataMember]
        private long m_id;
        [DataMember]
        private string m_title;
        [DataMember]
        private string m_description;
        [DataMember]
        private DateTime m_dateStart;
        [DataMember]
        private DateTime m_dateEnd;
        [DataMember]
        private string m_url;

        public DateTime DateStart
        {
            get { return m_dateStart; }
            set { m_dateStart = value; }
        } 

        public DateTime DateEnd
        {
            get { return m_dateEnd; }
            set { m_dateEnd = value; }
        }
       
        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }
        
        public long Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

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
