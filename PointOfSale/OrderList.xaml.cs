﻿/* OrderList.xaml.cs
 * Author: Dustin Wilson
 */
 
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for when selection is changed
        /// </summary>
        /// <param name="sender">object sent</param>
        /// <param name="args">Event argument</param>
        private void OnSelectionChanged(Object sender, EventArgs args)
        {
            
        }
    }
}
