   M S B A M L   `   `   `  ����D  @Drug_Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Drug_Shop	Drug_Shop  5   	       Drug_Shop.Sell   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Drug_Shop     5   	     � Title$
  Sell��5   	   $
��1080��6   $
��1920��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��5 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ReceiptsItemList��5      $��10,10,10,10q�6b    �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$	 150��61    �� DisplayMemberBinding 6=   �� *Id+�� 5      $��DateTime��6%   $	 150��67    6C   �� *
DateTime+�� 5      $��Amount��6%   $	 150��65    6A   �� *Amount+5      5      �� 5   
   $��1��6   $��1��6#    5      �� 5      .P�5      �� 5      5!      �� 5"   
   -   5        $ ReceiptProductsItemList��5"      $��1��64   $��10,10,10,10q�6A    5#      �� 5$      .P�5%      �� $��Name of Product��6%   $	 150��6>    6J   �� *Product.Name+�� 5&      $��Price��6%   $	 150��64    6@   �� *Product.Price+�� 5'      $��Quantity��6%   $	 150��67    6C   �� *
Quantity+�� 5(      $��Amount��6%   $	 150��65    6A   �� *Amount+5)      5+      �� 5,   
   -   5        $��New purchase��5,      $��1��6(   $��1��68   $��50��6E   $��Center=�6Q   ���	#FF66BD6A$��	30,0,31,0q�6�   6�   �� 5-   
   -   5        $��Delete purchase��5-      $��1��6+   $��50��6;   $��Center=�6G   ���	#FFE66A46$��	30,0,30,0q�6y   6�   5.      5/      