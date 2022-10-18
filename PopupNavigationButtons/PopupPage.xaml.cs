using CommunityToolkit.Maui.Views;
using System;

namespace PopupNavigationButtons.View;

public partial class PopupPage : Popup
{
	public PopupPage()
	{
		InitializeComponent();
	}

	private void ClosePopupBtn_Clicked(object sender, EventArgs e) => Close();
	
}