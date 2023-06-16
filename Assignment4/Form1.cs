using System.Linq.Expressions;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Windows.Forms.Design;

namespace MyBagelShop
{
    //Francis Mc Nabola
    //22210289
    //Assignment4, MyBagelshop.
    //Creating an ordering application for both staff and managers of a bagel shop.
    //It will allow staff to process orders and notify them if there is any unavailable stock.
    //It will allow managers to check stock levels and see sales reports.

    public partial class MyBagelShop : Form
    {

        //Declaring strings and variables.

        string Bagel, Size, BagelPrice, TRANSACTIONID, DATETIME;

        decimal TotalOrderCost, BagelCost, PriceTextBoxIndex;

        private int NumBagels, BagelTypeIndex, BagelSizeIndex, AvailableStock, BAGELSTOCK;

        string FILENAME = "TransactionRecords.Txt", COMPANYNAME = "MyBagelShop", STOCKREPORT = "StockLevels.Txt", PRICELIST = "Price_List.Txt";



        int TRANSLENGTH = 1;


        //Creating public variables to display in the summary view.
        public static decimal Avgtransaction { get; private set; }
        public static decimal TotalValueOfSales { get; private set; }
        public static int OverallNumberofBagels { get; private set; }
        public static int NumTransactions { get; private set; } = 0;



        //Decalring arrays and collections to access as the user moves through the application.


        readonly static string[] BAGELTYPE = {"Plain","Sesame", "Classic", "Everything", "Cheese", "Garlic","Chicken",
        "Blueberry","Raisin","Cinnamon","Whole Grain","Chocolate","Egg"};

        string[] BAGELSIZE = { "Small", "Medium", "Regular", "Large", "Extra Large" };

       
        readonly static decimal[,] BagelPrices = 
           {
            {2.50m, 3.00m, 3.50m, 4.00m, 4.50m},
            {3.00m, 3.50m, 4.00m, 4.50m, 5.00m},
            {3.50m, 4.00m, 4.50m, 5.00m, 5.50m},
            {3.75m, 4.25m, 4.75m, 5.25m, 5.50m},
            {3.50m, 3.75m, 4.25m, 4.50m, 5.00m},
            {3.25m, 3.50m, 4.00m, 4.25m, 4.50m},
            {4.00m, 4.25m, 4.50m, 5.00m, 5.50m},
            {2.75m, 3.00m, 3.25m, 3.50m, 4.00m},
            {3.00m, 3.25m, 3.50m, 3.75m, 4.25m},
            {3.25m, 3.75m, 4.25m, 4.75m, 5.25m},
            {3.00m, 3.25m, 3.75m, 4.00m, 4.25m},
            {3.50m, 3.75m, 4.25m, 4.75m, 5.00m},
            {2.50m, 3.00m, 3.50m, 4.00m, 4.50m }
                                    };


        int[,] BagelStockLevels =
        {
            {2,3,4,5,6},
            {4,5,2,6,10},
            {9,6,7,9,10},
            {12,11,14,3,6},
            {8,4,8,9,8},
            {7,8,6,9,10},
            {9,9,8,9,12},
            {10,10,12,13,15},
            {11,12,13,14,15},
            {6,8,9,12,4},
            {9,8,11,14,7},
            {10,13,7,9,11},
            {9,8,4,7,9},
        };

        

        public MyBagelShop()
        {
            InitializeComponent();
        }
     
        private void EnterButton_Click(object sender, EventArgs e)
        {
            BagelTypeIndex = BagelTypeListBox.SelectedIndex;
            BagelSizeIndex = BagelSizeListBox.SelectedIndex;
            PriceTextBoxIndex = BagelTypeListBox.SelectedIndex;
            


            //Making the fields visible that the user needs to process an order.
            LogoPictureBox.Visible = false;
            EnterLabel.Visible = false;
            EnterButton.Visible = false;
            BagelSizeListBox.Visible = true;
            BagelTypeListBox.Visible = true;
            OrderGroupBox.Visible = true;
            AddToOrderButton.Visible = true;
            ClearButton.Visible = true;
            ChooseBagelLabel.Visible = true;
            ChooseSizeLabel.Visible = true;
            OrderedItemsListBox.Visible = true;
            ButtonPanel.Visible = true;
            SearchPanel.Visible = true;
            CompleteOrderButton.Visible = true;
            TransactionsListBox.Visible = true;
            QuantityListLabel.Visible = true;
            SizeListLabel.Visible = true;
            BagelListLabel.Visible = true;
            PriceOutputTxtBox.Text = PriceTextBoxIndex.ToString("C");
            SummaryButton.Enabled = false;
            IDNumLabel.Visible = true;
            DateTimeLabel.Visible = true;
            QuantityListBoxLabel.Visible = true;
            TypeListLabel.Visible = true;
            PriceListLabel.Visible = true;
            TotalListLabel.Visible = true;
            ClearSearchButton.Visible = true;



        }
        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            BagelTypeIndex = BagelTypeListBox.SelectedIndex;
            BagelSizeIndex = BagelSizeListBox.SelectedIndex;
            AvailableStock = BagelStockLevels[BagelTypeIndex, BagelSizeIndex];

            if (BagelTypeIndex != -1)
            {
                if (BagelSizeIndex != -1)
                {

                    if (NumBagels <= BagelStockLevels[BagelTypeIndex, BagelSizeIndex])
                    {
                        //Checking avaiable stock levels to what amounnt user is trying to order.


                        try
                        {
                            NumBagels = int.Parse(QuantityTextBox.Text);
                            //PriceOutputTxtBox.Text = (BagelPrices[BagelTypeListBox.SelectedIndex, BagelSizeListBox.SelectedIndex]).ToString("C");

                            //Accessing the collections to then output desired selection into labels and listboxes.


                            Bagel = BAGELTYPE[BagelTypeIndex];
                            Size = BAGELSIZE[BagelSizeIndex];
                            TotalOrderCost = ((BagelPrices[BagelTypeIndex, BagelSizeIndex]) * NumBagels);
                            BagelCost = BagelPrices[BagelTypeIndex, BagelSizeIndex];
                            TotalPriceTextBox.Text = TotalOrderCost.ToString("C");
                            OrderedItemsListBox.Items.Add(Bagel + "\t" + "\t" + Size + "\t" + "\t" + NumBagels);

                        }
                        catch
                        {
                            //Helping user by notifying them about incorrect input into form.

                            MessageBox.Show("Please enter a numerical value for Quantity.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            QuantityTextBox.Focus();
                            QuantityTextBox.SelectAll();
                        }

                    }
                    else
                    {
                        //If there is unaviable stock Im highlighting the quantity txt box with the current level of available stock all ready enetered for user to be able to see.

                        QuantityTextBox.Text = AvailableStock.ToString();
                        MessageBox.Show("Unavailable stock to complete order. \nStock Levels available:" + "\t" + AvailableStock, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        QuantityTextBox.Focus();
                        QuantityTextBox.SelectAll();
                    }

                }
                else
                {
                    //Helping user by notifying them when there is input errors.
                    MessageBox.Show("Please select a Size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                //Helping user by notifying them when there is input errors.
                MessageBox.Show("Please select a Bagel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Reseting form for new order to take place.

            QuantityTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            BagelSizeListBox.ClearSelected();
            BagelTypeListBox.ClearSelected();
            PriceOutputTxtBox.Text = "";


        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            Boolean UniqueNum;
            string Message;
            BAGELSTOCK = AvailableStock;

          
            StreamWriter OutputFile, StockFile;

         
            //Adding transaction to summary details, clearing form for next order.

            NumTransactions++;
            TRANSACTIONID = TransactionID();
            OverallNumberofBagels = OverallNumberofBagels + NumBagels;
            TotalValueOfSales = TotalValueOfSales + TotalOrderCost;
            Avgtransaction = TotalOrderCost / NumTransactions;
            DATETIME = DateTime.Now.ToString("g");

            //Saving transaction details once order is finalised.


            OutputFile = File.AppendText(FILENAME);
            OutputFile.WriteLine(TRANSACTIONID + ',' + DATETIME  +',' + NumBagels + ',' + Bagel +',' + Size + ',' + BagelCost.ToString("C") +',' +  TotalOrderCost.ToString("C"));
            OutputFile.Close();
            
     

            //Displaying the completed order details to the user when order is confirmed.

            Message = "\t" + "\t"+ COMPANYNAME + "\n" + "\n" + "Transaction Number:" + "\t" + TRANSACTIONID + "\nDate/Time:" + "\t" + "\t" + DATETIME
            + "\nQuantity:" + "\t" + "\t" + "\t" + NumBagels + "\nType:" + "\t" + "\t" + "\t" + Bagel + "\nSize:" + "\t" + "\t" + "\t" + Size
            + "\nPrice:" + "\t" + "\t" + "\t" + BagelTypeIndex.ToString("C") + "\nTotal Cost:" + "\t" + "\t" + TotalOrderCost.ToString("C"); ;

            MessageBox.Show(Message, "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Outputing data to textfile.

            StockFile = File.AppendText(STOCKREPORT);
            StockFile.WriteLine("Bagel Type:");

            for ( int col = 0; col <BAGELSIZE.Length; col++ )
            {
                StockFile.WriteLine(BAGELSIZE);

                for (int ColumnCounter = 0; ColumnCounter < BAGELTYPE.Length; ColumnCounter++)
                {
                    StockFile.WriteLine(BAGELTYPE.ToString());
                }

                StockFile.Write("\n");
                
            }

            StockFile.Close();



            //Reseting the form for a new order to begin after previous order is confirmed.

            PriceOutputTxtBox.Text = "";
            QuantityTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            BagelSizeListBox.ClearSelected();
            BagelTypeListBox.ClearSelected();
            OrderedItemsListBox.Items.Clear();
            SummaryButton.Enabled = true;

        }

       
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //A new seperate form appears displaying the summary views for the transations.

            MyBagelShopSummary Summary = new MyBagelShopSummary();
            Summary.ShowDialog();

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            //A new seperate form disaplays the sales view sold items

            MyBagelShopSales Sales = new MyBagelShopSales();
            Sales.ShowDialog();
            // StreamReader InputFile = File.OpenText(FILENAME);
            String[] Text = File.ReadAllLines(FILENAME);
            //List<String[,]> SalesToday = new String[Text.Length, 5];
            for (int i = 0; i < Text.Length; i++)
            {
                String[] LineSplit = Text[i].Split(",");
               // List<string> Details = new List<string>();  
                for(int j = 2; j < LineSplit.Length; j++)
                {
                    //SalesToday[i, j - 2] = LineSplit[j].ToString();
                }
            }


        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clearing the order form for a new order to begin.

            PriceOutputTxtBox.Text = "";
            QuantityTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            BagelSizeListBox.ClearSelected();
            BagelTypeListBox.ClearSelected();
            OrderedItemsListBox.Items.Clear();
        }

        private void SearchIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           if(SearchIDRadioButton.Checked)
            {
                //Bringing user to desired textbox for searching previous transactions.

                IDTxtBox.Focus();
                IDTxtBox.SelectAll();
            }
        }

        private void DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Bringing user to desired textbox for searching previous transactions.

            if (DateRadioButton.Checked)
            {
                DateTxtBox.Focus();
                DateTxtBox.SelectAll();

            }
        }
        private void IDSearchButton_Click(object sender, EventArgs e)
        {
            //Calling search method to look for previous transactions.

            if (IDTxtBox.Text != "")
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FindIDNum(IDTxtBox.Text,FILENAME);
        }
        private void DateSearchButton_Click(object sender, EventArgs e)
        {
            //Calling search method to look for previous transactions.

            if (DateTxtBox.Text != "")
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TransactionsListBox.Items.Add(FindDate);
            }
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            //Clearing the search textboxs and listbox to be ready for a new search.

            TransactionsListBox.Items.Clear();
            IDTxtBox.Text = "";
            DateTxtBox.Text = "";
            SearchIDRadioButton.Checked = false;
            DateRadioButton.Checked = false;

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closing the application fully.

            this.Close();
        }
        private string TransactionID()
        {
            //Generating a random 5 digit ID number for each transaction.

            Random Random = new Random();

            return Random.Next(10000, 100000).ToString();

        }
        private Boolean IsUnique(string SeacrhString, string FILENAME)
        {
            //Creating a method to ensure that TransactionID numbers are unique.


            try
            {
                StreamReader OutputFile = File.OpenText(FILENAME);

                while (!OutputFile.EndOfStream)
                {
                    if (SeacrhString.Equals(OutputFile.ReadLine()))

                        OutputFile.Close();
                    return false;

                    for (int i = 0; i < TRANSLENGTH; i++)
                    {
                        OutputFile.ReadLine();
                    }

                }

                OutputFile.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been a process error" + ex, "Contact your manager",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }
        }
        private int FindIDNum(string SearchString, string FIlENAME)
        {
            //Creating a search method to call when looking for previous transactions.

            string[] ReadText = File.ReadAllLines(FILENAME);

            for (int i = 0; i < ReadText.Length; i++)
            {
                String[] SplitLine = ReadText[i].Split();
                for (int j = 0; j < SplitLine.Length; j++)
                {
                    if (SplitLine[j].ToString() == SearchString)
                    {
                        TransactionsListBox.Items.Add(i);
                    }
                }
            }
            if (TransactionsListBox.Items.Count < 1)
            {
                MessageBox.Show("Cannot find records.", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return -1;
        }

        private string FindDate(string DATETIME, String FILENAME)
        {

            //Creating a search method to call when looking for previous transactions.
            string[] ReadText = File.ReadAllLines(FILENAME);

            for (int i = 0; i < ReadText.Length; i++)
            {
                String[] SplitLine = ReadText[i].Split();
                for (int j = 0; j < SplitLine.Length; j++)
                {
                    if (SplitLine[j] == DATETIME)
                    {
                        TransactionsListBox.Items.Add(i);
                    }
                }
            }
            if(TransactionsListBox.Items.Count < 1)
            {
                MessageBox.Show("Cannot find records.", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;

        }
    }

    }


    
