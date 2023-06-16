using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBagelShop
{
    public partial class MyBagelShopSummary : Form
    {
        public MyBagelShopSummary()
        {
            InitializeComponent();
        }

        private void CloseSummaryButton_Click(object sender, EventArgs e)
        {
            //Closing this form and bringing user back to original form.
            this.Close();
        }

        private void MyBagelShopSummary_Load(object sender, EventArgs e)
        {
            //Calling values from main form to use as output in summary form. 

            NumBaglesTxtBox.Text = MyBagelShop.OverallNumberofBagels.ToString();
            TotalValueSalesTxtBox.Text = MyBagelShop.TotalValueOfSales.ToString("C");
            TotalTransactionTxtBox.Text= MyBagelShop.NumTransactions.ToString();
            AvgValueTransactionTxtBox.Text = MyBagelShop.Avgtransaction.ToString("C");

        }
    }

}


