// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace GigEntry
{
    public partial class GigInfoForm : Form
    {
        private localhost.GigManagerServiceContractClient client;

        public GigInfoForm()
        {
            InitializeComponent();
            client = new localhost.GigManagerServiceContractClient();

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            localhost.LinkItem item = new localhost.LinkItem();
            item.Description = this.txtDescription.Text;
            item.Title = this.txtDescription.Text;
            client.SaveGig(item);
        }

        private void cmdGet_Click(object sender, EventArgs e)
        {
            localhost.LinkItem gig = client.GetGig();
            this.txtDescription.Text = gig.Description;
            this.txtTitle.Text = gig.Title;
        }
    }
}