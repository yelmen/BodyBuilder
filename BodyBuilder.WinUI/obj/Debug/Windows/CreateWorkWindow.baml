   M S B A M L   `   `   `  ����L  HBodyBuilder.WinUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BodyBuilder.WinUI.WindowsBodyBuilder.WinUI.Windows  5   	   0    *BodyBuilder.WinUI.Windows.CreateWorkWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:BodyBuilder.WinUI.Windows     5   	   -   5          � Title$  CreateWorkWindow��5   	   $	��450��6"   $	��400��6/    � AllowsTransparency .  � WindowStyle$
 None=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   ._�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� $��Hareket Ekleme Penceresi��6   $��Center=�6;   $��16(�5      
���   �$��Microsoft JhengHei Light)�5      $��	0,0,160,0q�6?   �� 5      -   5        $	��✕��5         CustomWindowButton#��[  6%   $��20��5      $��20��6$   $��0,0,10,0q�60   $��0q�5      
������ 
���   �6Y   5      5      �� 5!   
   $��1��6   ._�5"      �� $��Center=�6   $��Center=�66   .+�5#      �� $��Hareket adını girin��6   $��Center=�66   $��16(�5$      
���   �$��Microsoft JhengHei Light)�5%      �� 5&      -   5         ��Name$ TbxMoveName��5'      $	��250��5&        CustomTextBox#��[ 6&   5'      5)      5+      �� 5-   
   $��2��6   ._�5.      �� $��Center=�6   $��Center=�66   .+�5/      �� $��Hareket miktarını girin��6   $��Center=�6:   $��16(�50      
���   �$��Microsoft JhengHei Light)�51      �� 52      -   5        $ TbxMoveAmount��53      $	��250��52      #��[ 6&   53      55      57      �� 59   
   $��3��6   ._�5:      �� $��Center=�6   $	��Top=�66   .+�5;      �� -   5         ��Name$ 	BtnAccept��5=   +   $	��130��5;      $��30��6%     CustomButton#��[ 61   
���   �
������ $��
Onaylayın��5<   E   $��0,20,0,0q�5=      6>   5?      5A      5C      5D      