   M S B A M L   `   `   `  ����U  QStudentGroup_BangLuongCong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:StudentGroup_BangLuongCongStudentGroup_BangLuongCong  5   	   4    .StudentGroup_BangLuongCong.StudentDetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:StudentGroup_BangLuongCong     5   	   -   5          �Name$  StudentDetail��5   	    � Title$ Student Detail Window��5   	   $	��500��6'   $	��800��64   ���	#FFD4F7F2 � WindowStartupLocation$ CenterScreen=�6W    � 
ResizeMode$ NoResize=�6|   .��5	      � .+�5
   
   �� -   5         ��Name$ rtgStudentDetail��5
      $
��Left=�6.   $	��323��6I   $��
43,108,0,0q�6V   
���   �$	��Top=�6y   $	��551��6�   ���	#FFF3E4E46�   �� 5   
   -   5         ��Name$ 	lblHeader��5      $��Add | Update a Student��6#   $
��Left=�6D   $��	28,25,0,0q�6_   $	��Top=�6r   $��59��6�   $	��420��6�   $��36(�6�   $
��Bold"�6�   �� 5   
   -   5        $ lblStudentInfo��5      $��Student Info��6(   $
��Left=�6?   $��
61,133,0,0q�6Z   $	��Top=�6n   $��20(�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��
85,188,0,0q�6/   
���   �$	��466��6R   ���	#FFD4F7F2$	��215��6o   $	��Top=�6|   �� 5   
   -   5        $ lblStudentId��5      $��
Student ID��6&   $
��Left=�6;   $��123,210,0,0q�6V   $	��Top=�6k   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ lblEmail��5      $��Email��6"   $
��Left=�62   $��123,247,0,0q�6M   $	��Top=�6b   $��16(�6z   $
��Bold"�6�    J� RenderTransformOrigin$ 0.574,0.199&�6�   �� 5   
   -   5        $ lblFullname��5      $��Fullname��6%   $
��Left=�68   $��123,284,0,0q�6S   $	��Top=�6h   $��16(�6�   $
��Bold"�6�   $ 0.521,0.404&�6�   �� 5   
   -   5        $ lblDateOfBirth��5      $��Date of birth��6(   $
��Left=�6@   $��123,320,0,0q�6[   $	��Top=�6p   $��16(�6�   $
��Bold"�6�   $ 0.535,0.244&�6�   �� 5   
   -	   5        $ 
lblGroupId��5      $��Group ID��6$   $
��Left=�67   $��123,356,0,0q�6R   $	��Top=�6g   $��16(�6   $
��Bold"�6�   �� 5   
   -
   5         ��Name$ txtId��5      $
��Left=�6!   $��269,214,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��234��6}   $��16(�6�   ${�False��6�   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��269,251,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��234��6�   $��16(�6�   �� 5   
   -   5        $ txtFullname��5      $
��Left=�6'   $��269,288,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��234��6�   $��16(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 dtpDateOfBirth��5      $
��Left=�6-   $��266,321,0,0q�6H   $	��Top=�6]   $��16(�6u   �� 5   
   -   5        
 ��Name$
 
cbbGroupId��5      $
��Left=�6'   $��266,360,0,0q�6B   $	��Top=�6W   $	��120��6o   $��16(�6{   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��631,144,0,0q�6L   $	��Top=�6a   $��16(�6y   $
��Bold"�6�   $	��130��6�   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6$   $
��Left=�65   $��631,201,0,0q�6P   $	��Top=�6e   $��16(�6}   $
��Bold"�6�   $	��130��6�   6�   5      5      