   M S B A M L   `   `   `  ����L  HBodyBuilder.WinUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:BodyBuilder.WinUI.MVVM.ViewBodyBuilder.WinUI.MVVM.View  5      .    (BodyBuilder.WinUI.MVVM.View.RegisterView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:BodyBuilder.WinUI.MVVM.View     5      -   5        .��5
      �   � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10,0,0,0q�6.   .+�5      �� -   5         ��Name$ btnBack��5      $��40��5      $��30��6    
���   �$	��↩��5         CustomButton#��[  6!   
������ 5      5      �� 5   
   -   5         ��Name$ pnlForm��5   C   $��1��6   $��0,60,0,0q�6"    J� Opacity$
 0.20Q�64   .+�5      �� -   5         ��Name$ lblRegister��5   "   $��KAYIT OL��5      $��Center=�6'   $��25,0,0,0q�6B   
���   �$��Microsoft JhengHei Light)�5   '   $��30(�5      6"   �� 5      -   5         ��Name$ brdForm��5   '    �� Padding$ 20,0,0,0q�5      $��0,50,0,0q�5      ._�5      �� $ Vertical=�6   .+�5      �� $��Kullanıcı Adı : ��6   
���   �$��Microsoft JhengHei Light)�5      $��Center=�6B   $��18(�5       $��5,0,0,0q�6*   �� 5!      -   5         ��Name$ tbxUserName��5!   Q     CustomTextBox#��[ 6   $	��250��6E   $
��Left=�6f   $��10,0,0,0q�5"      �� 5#      $��	Şifre : ��6   
���   �$��Microsoft JhengHei Light)�5$      $��Center=�6B   $��18(�5%      $��5,0,0,0q�6*   G� 5&      -   5        	 G�Name$	 pbxUserPassword��5'   "     CustomPasswordBox#��[ 5&   "   $	��250��6M   $
��Left=�6Y   $��10,0,0,0q�5'   ;   �� 5(      $��Şifre Tekrar : ��6   
���   �$��Microsoft JhengHei Light)�5)      $��Center=�6B   $��18(�5*      $��5,0,0,0q�6*   G� 5+      -   5        $	 pbxReUserPassword��5,   "   #��[ 5+   "   $	��250��6M   $
��Left=�6Y   $��10,0,0,0q�5,   =   �� 5-      $��Ad : ��6   
���   �$��Microsoft JhengHei Light)�5.      $��Center=�6B   $��18(�5/      $��5,0,0,0q�6*   �� 50      -	   5        $ tbxName��50   Q   #��[ 6   $	��250��6E   $
��Left=�6b   $��10,0,0,0q�51      �� 52      $��Soyad : ��6   
���   �$��Microsoft JhengHei Light)�53      $��Center=�6B   $��18(�54      $��5,0,0,0q�6*   �� 55      -
   5        $ 
tbxSurname��55   Q   #��[ 6   $	��250��6E   $
��Left=�6e   $��10,0,0,0q�56      �� 57      -   5        $ 	btnSubmit��57      #��[  60   $	��120��58      $��40��6)   $��0,30,0,0q�65   
���   �$��	Kayıt Ol��59      
������ 6H   5:      5;      5=      5?      5@      