   M S B A M L   `   `   `  ����L  HBodyBuilder.WinUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BodyBuilder.WinUI.WindowsBodyBuilder.WinUI.Windows  5   	   +    %BodyBuilder.WinUI.Windows.AddWorkPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:BodyBuilder.WinUI.Windows     5   	   -   5          � Title$  AddWorkPage��5   	   $	��550��6   $	��650��6*    � WindowStyle$
 None=�5	   	    � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��55 �6   �� 5      �� 5      $��40 �6   .+�5   
   �� ���#E3E5E8._�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ BtnClose��5   +   $��20��5      $��20��6$   $��0,0,10,0q�60      CustomWindowButton#��[  5      $��0q�5      $	��✕��6-   $��18(�69   
�������5   =   5      5      �� 5   
   $��1��6   $��1,0,1,0q�6   ���#E3E5E8._�5       �� $ 
Horizontal=�6   $��80,0,0,0q�62   .+�5!      �� $ Vertical=�6   .+�5"      �� $��10(�6   $��Microsoft JhengHei Light)�6*   $��Hareket Adı Girin��6P   �� 5#      -   5         ��Name$ TbxSearchBar��5$   E   $	��300��5#      $��30��6*   $��5,0,0,0q�66     CustomTextBox#��[ 5$      5%      5'      �� 5(      -   5        $ 
BtnAddWork��5*   C   $	��110��5(      $��30��6%   $��Bottom=�61   $��	105,0,0,2q�6L     CustomButton#��[ 5)      
������ 
���   �$��Hareket ekle��5*   ,   6W   5+      5,      �� 50   
   $��2��6   $��1,0,1,0q�6   ���#E3E5E8._�51      �� $	��550��6   $	��350��6!   $��Center=�6.   $��1q�52      
�������._�53      �� -   5         ��Name$ Control��53   !   64   54      55      �� 58   
   $��3��6   $��1,0,1,1q�6   ���#E3E5E8._�59      �� $ 
Horizontal=�6   $��Right=�62   .+�5:      �� -   5        $ 	BtnAccept��5=   *   $	��120��5:      $��30��6%   $��0,0,45,0q�61   
������ 
���   �#��[ 5<      $��Onayla��5=      6=   5>      5?      5B      5C      