   M S B A M L   `   `   `  ����I  EMultifenetrage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Multifenetrage.ViewMultifenetrage.View  5      #    Multifenetrage.View.UserAdmin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Multifenetrage.View     5        N� Title$  	UserAdmin��5	      $	��339��6   $	��562��6&    N� 
Background
 �����.��5      � .+�5   
   �� $��Login��6   $
��Left=�6    $��	37,28,0,0q�6;   $	��Top=�6N   $��16(�6f   �� 5   
   $
��Left=�6n   $��31��6�   $��
121,28,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��122��6�   $��16(�6�   ��6   ��  �� Path$ UtilisateurVM.Login� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   $	��Nom��6   $
��Left=�6   $��	41,71,0,0q�69   $	��Top=�6L   $��16(�6d   �� 5   
   $
��Left=�6m   $��31��6�   $��
121,71,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��122��6�   $��16(�6�   ��6   �� $ UtilisateurVM.Nom�$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $��Email��6   $
��Left=�6    $��
290,28,0,0q�6;   $	��Top=�6O   $��16(�6g   �� 5   
   $
��Left=�6n   $��31��6�   $��
370,28,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��122��6�   $��16(�6�   ��6   �� $ UtilisateurVM.Email�$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $��Prenom��6   $
��Left=�6!   $��
290,71,0,0q�6<   $	��Top=�6P   $��16(�6h   �� 5   
   $
��Left=�6p   $��31��6�   $��
370,71,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��122��6�   $��16(�6�   ��6   �� $ UtilisateurVM.Prenom�$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $��Password��6   $
��Left=�6#   $��
37,118,0,0q�6>   $	��Top=�6R   $��16(�6j   G� 5   
   -   5         G�Name$ pwdPass1��5      $
��Left=�6(   $��122,118,0,0q�6C   $	��Top=�6X   $	��121��6p   $��31��6|   $��16(�6�   6�   �� 5   
   $��Password��6   $
��Left=�6#   $��289,118,0,0q�6>   $	��Top=�6S   $��16(�6k   G� 5   
   -   5        $ pwdPass2��5      $
��Left=�6(   $��370,118,0,0q�6C   $	��Top=�6X   $	��121��6p   $��31��6|   $��16(�6�   6�   �� 5   
   -   5         ��Name$ btnAjoutUtilisateur��5      $��Ajouter��6.   $
��Left=�5      $��
37,154,0,0q�6,   $	��Top=�5       $	��100��6)   $��22��65   ��5      �� *AjoutUtilisateurVM+��5      �� *UtilisateurVM+5    5   9� 5!   
   $��Expander��6   $
��Left=�6%   $	��136��5"      $��
10,193,0,0q�6    $	��Top=�64   $	��542��5#       9� 
IsExpanded . .��5$      �� $
��Left=�6F   $	��106��6a   $	��542��6n   $��0,0,-2,0q�6z   ��6   �� $ ListUtilisateurVM�	 �� View	 5%      �� 5&      .P�5'      �� $��Numéro��6)   
 �� DisplayMemberBinding
 69   �� *Id+�� 5(      $��Login��6)   
 68   �� *Login+�� 5)      $	��Nom��6)   
 66   �� *Nom+�� 5*      $��Prenom��6)   
 69   �� *Prenom+�� 5+      $��Email��6)   
 68   �� *Email+5,      5.      5/      54      55      