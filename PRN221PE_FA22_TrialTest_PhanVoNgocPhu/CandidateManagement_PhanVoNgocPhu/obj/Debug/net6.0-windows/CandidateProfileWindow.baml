   M S B A M L   `   `   `  ����\  XCandidateManagement_PhanVoNgocPhu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:CandidateManagement_PhanVoNgocPhu!CandidateManagement_PhanVoNgocPhu  5   	   >    8CandidateManagement_PhanVoNgocPhu.CandidateProfileWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:CandidateManagement_PhanVoNgocPhu     5   	   -   5          � Title$  CandidateProfileWindow��5   	   $	��522��6(   $	��800��65   .��5	      � $��0,0,0,17q�6   .+�5
   
   �� $"��Candidate Profile Management��6   $��Center=�67   $��57��6T   $��0,10,0,0q�6`   $	��Top=�6r   $	��361��6�   $��24(�6�   $
��Bold"�6�   �� 5   
   $��Candidate ID��6   $
��Left=�6'   $��	41,70,0,0q�6B   $	��Top=�6U   $��89��6m   �� 5   
   $��FullName��6   $
��Left=�6#   $��
41,101,0,0q�6>   $	��Top=�6R   �� 5   
   $��ImageURL��6   $
��Left=�6#   $��
41,132,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ 0.562,-1.053&�6j   �� 5   
   $��Birthday��6   $
��Left=�6#   $��
41,163,0,0q�6>   $	��Top=�6R   $��89��6j   �� 5   
   -   5         ��Name$ txtCandidateId��5      $
��Left=�6*   $��
135,74,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6n   $	��254��6�   6�   �� 5   
   -   5        $ txtFullname��5      $
��Left=�6'   $��135,105,0,0q�6B   $
 Wrap=�6W   $	��Top=�6l   $	��254��6�   �� 5   
   -   5        $ txtImageURL��5      $
��Left=�6'   $��135,136,0,0q�6B   $
 Wrap=�6W   $	��Top=�6l   $	��254��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dpBirthday��5      $
��Left=�6)   $��135,164,0,0q�6D   $	��Top=�6Y   $	��254��6q   �� 5   
   $��
JobPosting��6   $
��Left=�6%   $��
445,70,0,0q�6@   $	��Top=�6T   $��87��6l   �� 5   
   $��Description��6   $
��Left=�6&   $��445,101,0,0q�6A   $	��Top=�6V   $	��110��6n   �� 5   
   -   5         ��Name$ cbbJobPosting��5      $
��Left=�6*   $��
532,72,0,0q�6E   $	��Top=�6Y   $	��233��6q   �� 5   
   -   5        $ txtCandidateDescription��5      $
��Left=�63   $��445,136,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��320��6�   $��52��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCandidateProfile��5      $��41,207,35,107q�6Z   6�   �� 5   
   -	   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
41,441,0,0q�6J   $	��Top=�6^   $��39��6v   $	��150��6�   ���	#FF8DFF126�   �� 5   
   -
   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��229,441,0,0q�6P   $	��Top=�6e   $��39��6}   $	��150��6�   ���	#FF00BCFC6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��425,441,0,0q�6P   $	��Top=�6e   $��39��6}   $	��150��6�   ���	#FFFF93006�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��615,441,0,0q�6N   $	��Top=�6c   $��39��6{   $	��150��6�   6�   5      5      