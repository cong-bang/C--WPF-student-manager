   M S B A M L   `   `   `  ����U  QStudentGroup_BangLuongCong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:StudentGroup_BangLuongCongStudentGroup_BangLuongCong  5   	   +    %StudentGroup_BangLuongCong.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:StudentGroup_BangLuongCong     5   	   -   5          �Name$  StudentManagerWindow��5   	    � Title$ Main Student Group Window��5   	   $	��500��6+   $	��800��68   ���	#FFD4F7F2 � WindowStartupLocation$ CenterScreen=�6[    � 
ResizeMode$ NoResize=�6�   .��5	      � -   5         �Name$ StudentGroupManager��5	      .+�5
   
   �� -   5         ��Name$ lblStudentGroup��5
      $��Student Group��6)   $
��Left=�6A   $��	28,25,0,0q�6\   $	��Top=�6o   $��59��6�   $	��259��6�   $��36(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ rtgSearchInfo��5      $��Center=�6+   $��83��6H   $��	0,102,0,0q�6T   
���   �$	��Top=�6v   $	��652��6�   �� 5   
   -   5        $ lblFromYear��5      $��	From Year��6%   $
��Left=�69   $��104,129,0,0q�6T   $	��Top=�6i   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 	lblToYear��5      $��To Year��6#   $
��Left=�65   $��354,128,0,0q�6P   $	��Top=�6e   $��16(�6}   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��27��6P   $��599,128,0,0q�6\   $	��Top=�6q   $��99��6�   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ txtFromYear��5      $
��Left=�6'   $��194,132,0,0q�6B   	 �� TextWrapping$
	 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��16(�6�   �� 5   
   -	   5        $ 	txtToYear��5      $
��Left=�6%   $��423,131,0,0q�6@   $
	 Wrap=�6U   $	��Top=�6i   $	��120��6�   $��16(�6�   �� 5   
   -
   5        $ lblStudentList��5      $��Student List��6(   $
��Left=�6?   $��
28,211,0,0q�6Z   $	��Top=�6n   $��16(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 dtgStudentList��5      $
��Left=�6+   $	��199��6F   $��
28,247,0,0q�6S   $	��Top=�6g   $	��554��6      AutoGenerateColumns$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $ Email��6%   $	 150 6N    64   �� *Email+6N     5      $ Fullname��6%   $	 120 6T    67   �� *
FullName+6T     5      $ DateOfBirth��6%   $	 150 6Z    6:   �� *DateOfBirth+6Z     5      $ GroupID��6%   $ 60 6R    66   �� *	GroupId+6R     5      $ 	GroupName��6%   $ 70 6\    68   �� *Group.GroupName+6\   5      �� 5   
   -   5        $ btnAddStudent��5      $��Add Student��6(   $
��Left=�6>   $��27��6Y   $��619,247,0,0q�6e   $	��Top=�6z   $	��141��6�   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ btnUpdateStudent��5      $��Update Student��6+   $
��Left=�6D   $��27��6_   $��619,304,0,0q�6k   $	��Top=�6�   $	��141��6�   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ btnDeleteStudent��5      $��Delete Student��6+   $
��Left=�6D   $��28��6_   $��619,364,0,0q�6k   $	��Top=�6�   $	��141��6�   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ btnQuit��5      $
��Quit��6"   $
��Left=�61   $��27��6L   $��619,419,0,0q�6X   $	��Top=�6m   $	��141��6�   $��16(�6�   $
��Bold"�6�   6�   5!      5"      