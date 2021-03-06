﻿using System;
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

namespace TCPTools {
	/// <summary>
	/// WinUDPClientCrete.xaml 的交互逻辑
	/// </summary>
	public partial class WinUDPClientCrete : Window {
		public WinUDPClientCrete() {
			InitializeComponent();
		}

		private void confirm_Click(object sender, RoutedEventArgs e) {
			((MainWindow)Owner).ip = ipBox.IP;
			((MainWindow)Owner).port = remotePortBox.Port;
			((MainWindow)Owner).port2 = localPortBox.Port;
			DialogResult = true;
			Close();
		}

		private void cancel_Click(object sender, RoutedEventArgs e) {
			DialogResult = false;
			Close();
		}
	}
}
