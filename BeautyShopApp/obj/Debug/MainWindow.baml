   M S B A M L   `   `   `  ����H  DBeautyShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BeautyShopAppBeautyShopApp  5   	       BeautyShopApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BeautyShopApp     5   	   -   5          � Title$7  1Админ-панель Салон Красоты��5   	   $	��700��6,   $	��900��69    � 
ResizeMode$ NoResize=�6E   
������� � Icon$ Resources/bs.ico��6n    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �  � RowDefinitions 5   
   �� 5      $	��23* �6   �� 5      $
��200* �6   .+�5   
   �� $��0��6   ���	#FF9EB7EE �� Orientation$ 
Horizontal=�69   .+�5      �� $��Resources/bs.png��6   $��55��6.   $
��Left=�5      $��10 0 0 0q�6/   �� 5      -   5         ��Name$ btnExit��5      $	��150��5      $��30��6!   $��17(�6-   
���   �
�������$��	5,20,0,19q�5      $��Tahoma)�6(   $��
Выход��6<   $y�Hidden=�5      �� 5      -   5         ��Name$ lblUser��5      $�� ��6%   $��30��60   $��17(�5      
���   �
�������$��Tahoma)�5      $	��Top=�5      $	��461��6,   $��
20,20,20,0q�68   $y�Hidden=�5       �� 5"      -   5        $ btnBack��5"      $	��150��5#      $��30��6!   $��17(�6-   
���   �
�������$��0 0 0 0q�5%      $��Tahoma)�6&   $��
Назад��6:   $y�Hidden=�5&      5(      �� 5*   
   $��1��6   $��Center=�6"   .+�5,      �� $��Resources/bs.png��6   $	��358��5-       J� Opacity$	 0.1Q�5.      5/       � 50   
   -   5        	  �Name$	 frame��50      $��Center=�6   
  � NavigationUIVisibility$
 Hidden=�6:   $��2��6Z    � 51   
   -   5        $	 FrmMain��51      $��1��6!   $
 Hidden=�6.   52      53      