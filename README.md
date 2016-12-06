# CustomGooeyMenu

Path menu with gooey effects

This is a obj-c binding project based on https://github.com/KittenYang/KYGooeyMenu

###Usage

```
var gooeyMenu = new KYGooeyMenu(new CGPoint((this.View.Frame.Width / 2) - 25, this.View.Frame.Height - 40f), 50f, this.View, UIColor.Blue);
gooeyMenu.MenuDelegate = new MenuDelegate();
gooeyMenu.Radius = 80 / 4f;
gooeyMenu.ExtraDistance = 40f;
gooeyMenu.MenuCount = 3;
var mainArry = new NSMutableArray();
mainArry.Add(UIImage.FromBundle("home"));
mainArry.Add(UIImage.FromBundle("settings"));
mainArry.Add(UIImage.FromBundle("mail"));
gooeyMenu.MenuImagesArray = mainArry;

Menu menu = new Menu();
menu.Frame = new CGRect(this.View.Center.X - 50, this.View.Frame.Size.Height - 200, 50, 50);
menu.BackgroundColor = UIColor.Clear;
this.View.AddSubview(menu);

public class MenuDelegate : menuDidSelectedDelegate
{
	public override void MenuDidSelected(int index)
	{

	}
}
```

###Output 

![](https://github.com/guntidheerajkumar/CustomGooeyMenu/blob/master/CustomGooeyMenuOutput.gif)
