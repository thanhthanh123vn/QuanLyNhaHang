   M S B A M L   `   `   `  ����   QLNH    QLNH.AddFood   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
Thêm món��$	��420��$	��600�����#7B3F32 � WindowStartupLocation$ CenterScreen=�.��� $��
10,10,10,2q�.+��� $��
Thêm món��$��18(�$
��Bold"�
�������$
��Left=�$��5,0,0,10q���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�$��0,30,0,0q�.+�	� -    	�Name$ rdDoUong��$��Đồ uống�� 	� 	GroupName$
 Loai��$��0,0,10,0q�$��12(�
�������	� -   $ rdMonAn��$��Món ăn��$
 Loai��$��12(�
�������� $��
0,70,0,186q� � ColumnDefinitions �� $��2* ��� $��* �.+��� $��Tên món (*)��$��0��$	��Top=�$��12(�
�������$��	0,0,302,0q��� -    ��Name$ tbTenMon�����#ccc$
��Left=�$��	93,-6,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��260��$��30���� -   $ tbMaMon�����#ccc$
��Left=�$��	93,32,0,0q�$
 Wrap=�$�� ��$	��Top=�$��92��$��30��� $��	0,110,0,0q� �� $��2* ��� $��* �.+��� $��Mã món (*)��$��0��$	��Top=�$��12(�
�������$��
0,-4,279,0q��� -   $ tbGia�����#ccc$
��Left=�$��
257,-8,0,0q�$
 Wrap=�$�� ��$	��Top=�$��95��$��30��� $��	0,150,0,0q� �� $
��387* ��� $
��193* �.+��� $��Giá bán (*)��$	��Top=�$��12(�
�������$��189,-48,102,0q�� $��	0,190,0,0q� �� $	��64* ��� $
��322* ��� $
��193* �.+��� $��Nhóm thực đơn��$��0��$	��Top=�$��12(�
�������$��0,-49,257,0q�$��2���� $��Đơn Vị Tính��$��1��$	��Top=�$��12(�
�������$��123,-47,126,0q�� $��	0,220,0,0q� �� $	��64* ��� $
��322* ��� $
��193* �.+��� $��Chế biến tại (*)��$��0��$	��Top=�$��12(�
�������$��0,-46,257,0q�$��2���� $/��)Định lượng nguyên vật liệu (*)��$��14(�$
��Bold"�
�������$��1,230,-1,71q�&   System.Windows.Controls.DataGrid  -     Name$ MenuDataGrid��$��1,257,214,0q�	   AutoGenerateColumns	 .  $��12(�
   HeadersVisibility$
 Column=�   GridLinesVisibility$	 All=����#ccc���#CCCCCC$��1q�   RowBackground �#FFFFFF   AlternatingRowBackground �#EAEAEA   HorizontalGridLinesBrush �#D3D3D3   VerticalGridLinesBrush �#D3D3D3   ColumnHeaderHeight$ 40Q�   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value �#FFC0CB��  � �� �#333333��  � ��$
 Bold"���  � ��$ Center=���  � ��$ 14(�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NVL��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *MaNVL+   ElementStyle �� " ��.���  �@��TextAlignment$ Center=�  $ Nguyên vật liệu��$ 2*  �� *TenNVL+ �� " ��.���  �@��TextAlignment$ Center=�  $ Số lượng��$ *  �� *	SoLuong+ �� " ��.���  �@��TextAlignment$ Center=�  $ Đơn vị tính��$ 2*  �� *	DonViTinh+ �� " ��.���  �@��TextAlignment$ Center=��� 
���   �$��2q� �� CornerRadius$ 10��$	��Top=�$��Right=�$	��200��$��	0,30,10,0q�._��� $	��Top=�$��Center=�$	��200��$��	0,30,10,0q�$	��200��.+��� $��Ảnh đại diện��$
��Bold"�$��12(�
�������$��Center=��� $��1q�
�������$	��100��$	��100��$��	0,10,0,10q�._��� -    ��Name$ 
pictureBox��$
��Fill=�$��1,0,-1,0q��� $ 
Horizontal=�$��Center=�.+��� -   $	��...��$��20��$��2q��� $��X��$��20��$��2q��� $+��%Chọn các ảnh có định dạng �� �� TextAlignment$ Center=�
�������$��10(�$��16��$	��211���� $��(.jpg,.jpeg,.png,.gif)��$ Center=�
�������$��10(�$��17��$	��211���� $ 
Horizontal=�$
��Left=�$	��Top=�$��371,321,0,0q�$��43��.+��� -	    ��Name$ 	buttonLuu�����#ccc$
��Lưu��$��60��$��25��$��5q��� ���#ccc$��
Hủy bỏ��$��60��$��25��$��5q��� ���#ccc$��Giúp��$��60��$��25��$��5q��� -
   $ 	tbThucDon�����#ccc$
��Left=�$��
93,140,0,0q�$
 Wrap=�$�� ��$	��Top=�$��88��$��30���� -   $ tbDVT�����#ccc$
��Left=�$��257,140,0,0q�$
 Wrap=�$�� ��$	��Top=�$��95��$��30���� -   $ tbCBT�����#ccc$
��Left=�$��
93,176,0,0q�$
 Wrap=�$�� ��$	��Top=�$��88��$��30��