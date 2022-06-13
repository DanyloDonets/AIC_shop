﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Drug_Shop
{
    /// <summary>
    /// Логика взаимодействия для Sell.xaml
    /// </summary>
    public partial class Sell : Window
    {
        public Sell()

        {
            context = new DataContext();
            InitializeComponent();
            UpdateData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ReceiptsItemList.SelectedItem is Receipt selectedReceipt)
            {
                //видаляємо його з контексту
                context.Receipts.Remove(selectedReceipt);
                //синхронізуємо з базою даних
                context.SaveChanges();
                //синхронізуємо з інтерфейсом
                UpdateData();
            }
            //якщо рядок не вибраний - повідомлення користувачу
            else
            {
                MessageBox.Show(" Select some row ", " Error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        public void UpdateData()
        {
            List <Receipt> DatabaseReceipts = context.Receipts.Include(receipt =>
            receipt.Products).Include(receipt => receipt.ReceiptProduct).ToList();
            ReceiptsItemList.ItemsSource = DatabaseReceipts;
        }
        private DataContext context { get; set; }
        public void Window_Closed(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void ReceiptsItemList_SelectionChanged(object sender,
SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
{
                Receipt receipt = (Receipt)e.AddedItems[0];
                ReceiptProductsItemList.ItemsSource = receipt.ReceiptProduct;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Puschase purchase = new Puschase();
            purchase.Closed += Window_Closed;
            purchase.ShowDialog();
        }
    }
}
