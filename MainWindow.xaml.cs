using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Reflection;

using Excel = Microsoft.Office.Interop.Excel;

namespace SMENG
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataList<AccountData> accountDataList = new DataList<AccountData>();
            dgd_account.ItemsSource = accountDataList;

            accountDataList.Add(new AccountData());
            accountDataList.Add(new AccountData());
            accountDataList.Add(new AccountData());
            accountDataList.Add(new AccountData());
            accountDataList.Add(new AccountData());
            accountDataList.Add(new AccountData());
            accountDataList.Add(new AccountData());
        }

        private void LeftTopMenuButton_Click(object sender, RoutedEventArgs e)
        {
            grd_store.Visibility      = Visibility.Hidden; // 입고 관리
            grd_accounting.Visibility = Visibility.Hidden; // 회계 관리
            grd_account.Visibility    = Visibility.Hidden; // 거래처 관리

            switch((sender as Button).Tag.ToString()) {
                case "store":
                    grd_store.Visibility = Visibility.Visible;
                    break;
                case "accounting":
                    grd_accounting.Visibility = Visibility.Visible;
                    break;
                case "account":
                    grd_account.Visibility = Visibility.Visible;
                    break;
            }
        }
    }

    public class DataList<T>: ObservableCollection<T>
    {
    }

    public class AccountData
    {
        public int No {get; set;}
        public string Sector {get; set;}         // Enum 으로 콤보박스 선택 고민
        public string Company {get; set;}
        public string CEO {get; set;}
        public int CorpKind {get; set;}          // Enum 으로 콤보박스 선택
        public string CorpID {get; set;}
        public string CorpContact {get; set;}
        public string CEO_HP {get; set;}
        public string Manager {get; set;}
        public string ManagerRank {get; set;}    // Enum 으로 콤보박스 선택
        public string Manager_HP {get; set;}
        public string Fax {get; set;}
        public string Email {get; set;}
        public string Bank {get; set;}           // Enum 으로 콤보박스 선택
        public string BankAccount {get; set;}
        public string BankAccountHolder {get; set;}
        public string CompanyAddress {get; set;}

        public AccountData()
        {
            this.No = 1;
            this.Sector = "업종";
            this.Company = "com";
            this.CEO = "name";
            this.CorpKind = 0;
            this.CorpID = "ID";
            this.CorpContact = "123";
            this.CEO_HP = "123";
            this.Manager = "name";
            this.ManagerRank = "rank";
            this.Manager_HP = "123";
            this.Fax = "123";
            this.Email = "123@123";
            this.Bank = "shinhan";
            this.BankAccount = "123";
            this.BankAccountHolder = "commm";
            this.CompanyAddress = "LA";
        }

    }
}