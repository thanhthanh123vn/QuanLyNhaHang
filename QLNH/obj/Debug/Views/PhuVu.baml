   M S B A M L   `   `   `  ����?  ;QLNH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QLNH.Views
QLNH.Views  5   	       QLNH.Views.PhuVu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QLNH.Views     5   	     � Title$  PhucVu��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5   
   ]� $	��Top=�6   $��Right=�6,   ��.  $��10, 30, 10, 20q�6^   .+�5      �� $��/img/account.png��6   $��27��6.   $��43��69   $��0,0,10,0q�6E   �� 5      $��Nguyễn Minh��6   $��Center=�5      $
��Bold"�5      $��13(�5      
���   �$��5,0,0,0q�5      5      �� 5   
   .+�5      o� $	��Top=�6   ���#A0522D.@�5      m� $��Danh sách bàn��6   $��34��6X   $
��Bold"�6d    m� Command 62   �� *ShowTablesCommand+��5      �� 5       �� 
TargetType" m�6     �� Triggers 5       P� 5"   "    P� Property �@J�IsMouseOver P� Value . . �5#   &   ��  �� Property �@�ToolTip �� Value 5$   *   �� 5%   .   ���#FFEBCD$	��300��6O   .+�5&   2   �� $"��Các bàn đang phục vụ:��6<   $
��Bold"�6Y   $��0,0,0,5q�6k   �� 5'   2   ��6?   �� *Tables.Serving+��5(   6   �� 5)   :   .R�5*   >   �� ���#8B4513��6H   �� 6Y   5+   ;   5-   3   �� 5.   2   $��Các bàn trống:��6<   $
��Bold"�6R   $��	10,10,0,5q�6d   �� 5/   2   ��6?   �� *Tables.Empty+��50   6   �� 51   :   .R�52   >   �� 
��� � ���6H   �� 6Y   53   ;   55   3   �� 56   2   $��Bàn đặt trước:��6<   $
��Bold"�6R   $��	10,10,0,5q�6d   �� 57   2   ��6?   �� *Tables.Reserved+��58   6   �� 59   :   .R�5:   >   �� 
����  ���6H   �� 6Y   5;   ;   5=   3   5>   /   5@   '   5A   #   5C      5E      m� 5F      $��Yêu cầu thanh toán��6   $
��Bold"�6f    67   �� *ShowPaymentRequestsCommand+��5G      �� 5H      " m�6     5I      P� 5J   "    �@J�IsMouseOver . . �5K   &   ��  � �� �#8B45136C   �� 5L   &    � ��
 �����6C   5M   #   5O      5Q      5R      5U      5V      5W      