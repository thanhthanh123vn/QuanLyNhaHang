   M S B A M L   `   `   `  ����   QLNH    QLNH.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$
  Menu��$	��622��$	��850��.��� ���#FFC0CB � ColumnDefinitions �� $
��146* ��� $
��699* ��� $��3* �.+�� ���#8B4513$��80��$	��Top=�$��3��.+���  �� Orientation$ 
Horizontal=�$��Center=�$
��Left=�$��10,0,0,0q�$��80��$	��838��.+��� $��80��
������ $��16(�
�������.���� $	��☰��$��Center=��� -    ��Name$ thucDon��$	��130��
������ $��16(�
�������.���� $ 
Horizontal=�.+��� $��img/ThucDon.png��$��24��$��0,0,5,0q��� $��Thực đơn��$��Center=��� $	��130��
������ $��16(�
�������.���� $ 
Horizontal=�.+��� $��img/NhanVien.png��$��24��$��0,0,5,0q��� $��Nhân Viên��$��Center=��� $	��130��
������ $��16(�
�������.���� $ 
Horizontal=�.+��� $��img/BaoCao.png��$��24��$��0,0,5,0q��� $��Báo cáo ▼��$��Center=��� $	��130��
������ $��16(�
�������.���� $ 
Horizontal=�.+��� $��img/Qua.png��$��24��$��0,0,5,0q��� $��Khuyến mãi��$��Center=��� $��img/icon wifi.png��$��40��$��	20,0,20,0q��� $��img/help.png��$��40��$��	20,0,20,0q��� 
������ .���� $��img/power.png��$��40��$��	20,0,20,0q�� ���#D2B48C$��70��$	��Top=�$��0,80,0,0q�$��3��.+��� $ 
Horizontal=�$
��Left=�$��Center=�$��20,0,0,0q�.+��� -   $��Thêm��$��40��$	��140���� -   $ 	buttonSua��$��Sửa��$��40��$	��140��$��20,0,0,0q��� $
��Xóa��$��40��$	��140��$��	20,0,20,0q��� $ 
Horizontal=�$��Right=�$��Center=�$��0,0,20,0q�.+��� $!��(Admin) Võ Thị Thùy Hoa��$��20(�
���   �$��0,0,10,0q��� .���� $��img/account.png��$��40��&   System.Windows.Controls.DataGrid  -     Name$ MenuDataGrid��   AutoGenerateColumns .  $��0,150,0,101q�   HeadersVisibility$ Column=�   CanUserAddRows .  $��3��$��16(����#F5F5F5���#CCCCCC$��1q�   RowBackground �#FFFFFF	   AlternatingRowBackground	 �#EAEAEA
   HorizontalGridLinesBrush
 �#D3D3D3   VerticalGridLinesBrush �#D3D3D3   GridLinesVisibility$	 All=�   ColumnHeaderHeight$ 40Q�   
IsReadOnly .    ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value �#FFC0CB��  � �� �#333333��  � ��$
 Bold"���  � ��$ Center=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã món��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *MaMon+   ElementStyle �� " ��.���  �@��TextAlignment$ Center=�  $ 	Tên món��$ 3*  �� *TenMon+ �� " ��.���  �@��TextAlignment$ Center=�  $ 
Nhóm món��$ 2*  �� *NhomThucDon+ �� " ��.���  �@��TextAlignment$ Center=�  $ 
Đơn giá��$ 2*  �� *Gia+ �� StringFormat$ 
{0:N0} VND�� �� " ��.���  �@��TextAlignment$ Center=�  $ Đơn vị tính��$ 2*  �� *	DonViTinh+ �� " ��.���  �@��TextAlignment$ Center=��� -    ��Name$ ActionPanel�����#ccc$ 
Horizontal=�$��Center=�$	��Top=�$��	0,505,0,0q�$	��101��$	��846��$��2��.+��� -   $ buttonUpdateSua��$��Cập Nhập ��$	��100��$��40��$��	10 0 20 0q��� -   $ ButtonHuySua��$��Hủy ��$	��100��$��40���� $ 
Horizontal=�$
��Left=�$	��Top=�$��200,557,0,0q�$��22��$	��239��$��1��.+��� $	��⏪��$��20��$��20��$
��Left=��� $��Trang��$��Center=�$	��5,0q��� $��20��$��1��$��20��$��Center=��� $��trên 7 trang��$��Center=�$	��5,0q��� $	��⏩��$��20��$��20��