   M S B A M L   `   `   `  ����L  HBodyBuilder.WinUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BodyBuilder.WinUIBodyBuilder.WinUI  5   	   "    BodyBuilder.WinUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BodyBuilder.WinUI     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $
��1100��6)    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � AllowsTransparency . ���#FFFFFF.��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $	��100 �6    � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5        $��0��5      $��2��6!   ���#E3E5E8._�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� $��Body Builder Demo��6   $��Center=�64   $��23(�5      
���   �$��Microsoft JhengHei Light)�5       $��	0,0,750,0q�5!      6.   �� 5"      -   5         ��Name$ btnHide��5"      $��40��6*   $��40��65   $��	10,0,10,0q�5#         CustomWindowButton#��[  6,   $	��─��5$      
������ $��0q�5%      
���   �5&      �� 5(      -   5        $ btnClose��5(      $��40��6,   $��40��67   $��0,0,10,0q�5)      #��[  6+   $	��✕��5*      $��0q�5+      
���   �6-   5-      5.      �� 5/   
   $��1��6   $��1��6   $��0,50,0,0q�6.   ._�50      &   System.Windows.Controls.DataGrid  -   5          Name$ dgwCustomers��53   ,   $��
0,10,35,10q�50        
CustomGrid#��[ 51        CustomGridHeader	   ColumnHeaderStyle#	 [ 52      ���#F2F3F556      57      �� 58   
   $��2��6   $��1��6   $��0,0,30,0q�6.   ._�59      ]� .+�5:      �� -   5        $ BtnDynamicActionLeft��5<        CustomButton#��[ 5:      $	��150��5;      $��55��6%   $	��Sil��61   
���   �
������ 5=   2   �� 5>      -   5        $ BtnDynamicActionRight��5A      #��[ 5>      $	��150��5?      $��55��6%   $
��Ekle��61   $��Right=�5@      
���   �
������ 5B   2   5C      5D      5G      5H      