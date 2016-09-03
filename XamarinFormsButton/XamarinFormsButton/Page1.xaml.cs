using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsButton
{
	public partial class Page1 : ContentPage
	{
		private int m_count;

		public Page1()
		{
			InitializeComponent();
		}

		public void Button_Clicked(object sender, EventArgs e)
		{
			Button button = sender as Button;
			switch (button.Text)
			{
				case "Plus":
					m_count++;
					break;
				case "Minus":
					m_count--;
					break;
			}
			MainLabel.Text = "Count: " + m_count;
		}
	}

}
