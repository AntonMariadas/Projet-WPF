   M S B A M L   `   `   `  ����I  EMultifenetrage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Multifenetrage.ViewMultifenetrage.View  5      !    Multifenetrage.View.Emprunt   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Multifenetrage.View     5        N� Title$  Emprunt��5	       N� 
Background �	#FFB2F7B9$	��339��6.   $	��562��6;   .��5      � .+�5   
   �� $��Utilisateur��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   �� 5   
   $
��Film��6   $
��Left=�6   $��	26,56,0,0q�6:   $	��Top=�6M   �� 5   
    �� DisplayMemberPath$	 Nom��6=   $
��Left=�6�   $��	93,14,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *ListeUtilisateurs+ �� SelectedValue 6U   �� *UtilisateurSelectionne+6�   �� 5   
   $ Titre��66   $
��Left=�6z   $��	93,60,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *
ListeFilms+ 6P   �� *FilmSelectionne+6�   �� 5   
   $
��Left=�6k   $��33��6�   $��
10,106,0,0q�6�   $	��Top=�6�   $	��272��6�   ��6   �� *ListeDesFilmsSelectionnes+ 6D   �� *FilmARetirer+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6    ��  �� Path$ Titre�5      5      ��5      �� 5      .R�5      $�  $� Orientation$ 
Horizontal=�6-   5      5      �� 5    
   $��Emprunt��6   $
��Left=�6"   $��
300,10,0,0q�6=   $	��Top=�6Q   �� 5!   
   $��Retour��6   $
��Left=�6!   $��
310,56,0,0q�6<   $	��Top=�6P   (  "System.Windows.Controls.DatePicker  5"   
   $
��Left=�6B   $��
384,12,0,0q�6]   $	��Top=�6q      SelectedDate 6   �� *Emprunt.DateEmprunt+6q     5#   
   $
��Left=�6A   $��
384,56,0,0q�6\   $	��Top=�6p    6   �� *Emprunt.DateRetour+6p   �� 5%   
   $��Statut��6   $
��Left=�6!   $��310,106,0,0q�6<   $	��Top=�6Q    J� RenderTransformOrigin$ 0.026,0.615&�6i   �� 5&   
   $
��Left=�6>   $��413,110,0,0q�6Y   $	��Top=�6n   $	��120��6�    6   �� *Emprunt.Statut+.@�5'      �� .��6   	Bon état6%   �� 5(      .��6   Moyen6"   �� 5)      .��6   	Mauvais6$   5*      �� 5+   
   $��Enregistrer��6W   $
��Left=�6m   $��
10,153,0,0q�6�   $	��Top=�6�   $��75��6�   ��6   �� *AjoutEmprunt+��62   �� *	Emprunt+6�   �� 5-   
   $
��Left=�69   $	��122��6T   $��
10,207,0,0q�6a   $	��Top=�6u   $	��542��6�   ��6   �� *ListeEmprunts+	 �� View	 5.      �� 5/      .P�50      �� $��Id��6%   
 �� Width$
 50��6U    �� DisplayMemberBinding 61   �� *Id+6U   �� 51      $��IdUtilisateur��6%    6<   �� *IdUtilisateur+�� 52      $��IdFilm��6%    66   �� *IdFilm+�� 53      $��DateEmprunt��6%    6;   �� *DateEmprunt+�� 54      $��
DateRetour��6%    6:   �� *
DateRetour+�� 55      $��Statut��6%   $
 50��6^    66   �� *Statut+6^   56      58      5:      5;      