   M S B A M L   `   `   `  ����I  EMultifenetrage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Multifenetrage.ViewMultifenetrage.View  5          Multifenetrage.View.Film   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Multifenetrage.View     5        N� Title$
  Film��5	       N� 
Background �	#FFCBE9F0$	��339��6+   $	��562��68   .��5
      � .+�5   
   �� $��Titre��6   $
��Left=�6    $��10,7,0,0q�6;   $	��Top=�6M   �� 5   
   $��Synopsis��6   $
��Left=�6#   $��	10,55,0,0q�6>   $	��Top=�6Q   �� 5   
   $��Durée��6   $
��Left=�6    $��
10,106,0,0q�6;   $	��Top=�6O   �� 5   
   $��Acteur Principal��6   $
��Left=�6+   $��180,106,0,0q�6F   $	��Top=�6[   �� 5   
   $��Autres acteurs��6   $
��Left=�6)   $��	180,7,0,0q�6D   $	��Top=�6W   �� 5   
   $��Affiche��6   $
��Left=�6"   $��
199,55,0,0q�6=   $	��Top=�6Q   �� 5   
   $
��Left=�6`   $��22��6{   $��	58,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��95��6�   ��6   �� *
Film.Titre+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   $
��Left=�6b   $��22��6}   $��	71,59,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   ��6   �� *Film.Summary+$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $
��Left=�6`   $��22��6{   $��
58,110,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�    J� RenderTransformOrigin$ 	0.611,0.5&�6�   ��6   �� *
Film.Duree+$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $
��Left=�6b   $��22��6}   $��280,110,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   ��6   �� *Film.ActeurP+$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $
��Left=�6h   $��22��6�   $��
280,10,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   ��6   �� *Film.AutresActeurs+$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $
��Left=�6b   $��22��6}   $��
260,59,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��95��6�   ��6   �� *Film.affiche+$ PropertyChanged=�$ TwoWay=�6�   �� 5   
   $��Ajouter��6S   $
��Left=�6e   $��
20,154,0,0q�6�   $	��Top=�6�   $��75��6�   ��6   �� *AjoutFilmVM+��61   �� *Film+6�   �� 5   
   $
��Left=�6<   $��81��6W   $��
10,251,0,0q�6c   $	��Top=�6w   $	��542��6�   ��6   ��  �� Path$ 
ListeFilms� �� View 5      �� 5      .P�5       �� $��Numéro��6%    �� Width$ 70��65   	 �� DisplayMemberBinding	 6@   �� *Id+�� 5!      $��Titre��6%   $ 70��65   	 6@   �� *Titre+�� 5"      $��Synopsis��6%   $ 70��68   	 6C   �� *	Summary+�� 5#      $��Durée��6%   $ 70��65   	 6@   �� *Duree+�� 5$      $��Acteur��6%   $ 70��66   	 6A   �� *	ActeurP+�� 5%      $��Autres��6%   $ 70��66   	 6A   �� *AutresActeurs+�� 5&      $��Affiche��6%   $	 110��67   
 �� CellTemplate
 5'      �� 5(      .R�5)   "   �� ��6(   �� *	affiche+5*      5,      5-      5/      �� 53   
   $��Genre��6   $
��Left=�6    $��	465,3,0,0q�6;   $	��Top=�6N   �� 54   
    �� DisplayMemberPath$ Libelle��6e   $
��Left=�6�   $	��Top=�6�   $	��120��6�   $��
420,29,0,0q�6�   ��6   �� *ListeGenreVM+ �� SelectedValue 68   �� *GenreSelectionneVM+6�   �� 56   
   $
��Left=�6l   $��54��6�   $��127,171,0,0q�6�   $	��Top=�6�   $	��184��6�    6   �� *GenreARetirerVM+��6<   �� *ListeGenresSelectionnes+��57      �� 58      .R�59      ��  �� Orientation$ 
Horizontal=�6!   .+�5:      �� ��6    �� $ Libelle�5;      5<      ��5>      �� 5?      .R�5@      $�  $� Orientation$ 
Horizontal=�6-   5A      5C      �� 5E   
   $
��Pays��6   $
��Left=�6   $��
465,73,0,0q�6:   $	��Top=�6N   �� 5F   
   $ Libelle��67   $
��Left=�6�   $	��Top=�6�   $	��120��6�   $��
420,99,0,0q�6�   ��6   �� *ListePaysVM+ 6S   �� *PaysSelectionneVM+6�   �� 5H   
   $
��Left=�6i   $��54��6�   $��356,171,0,0q�6�   $	��Top=�6�   $	��184��6�   ��6   �� *ListePaysSelectionnes+ 6@   �� *PaysARetirerVM+��5I      �� 5J      .R�5K      �� $ 
Horizontal=�6!   .+�5L      �� ��6    �� $ photo�5M      5N      ��5R      �� 5S      .R�5T      $� $ 
Horizontal=�6-   5U      5W      5X      5Y      