   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.Prise_Note   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  Prise de Note��5   	   $	��350��6   $	��550��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ Creation��5
      $��Créer une Note��6#   $
��Left=�6<   $��	58,67,0,0q�6W   $	��Top=�6j   $	��125��6�   $��13.333(�6�   �� 5   
   -   5         ��Name$ 	Recherche��5      $
��Left=�6'   $��23��6B   $��
253,66,0,0q�6N   $
��Wrap=�6b   $��	Recherche��6v    �� TextAlignment$ Center=�6�   $	��Top=�6�   $	��105��6�   $��13.333(�6�   �� 5   
   -   5         ��Name$ Search��5      $
��Left=�6"   $��23��6=   $��
363,66,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5         ��Name$ list_View_Note��5      $
��Left=�6+   $	��100��6F   $��
58,142,0,0q�6S   $	��Top=�6g   $	��425��6    � ContextMenu 5      �� 5      .@�5      m� -   5        $��Modifier��5      61   m� 5      -   5        $��	Supprimer��5      62   5       �� View 5      �� 5      .P�5      �� $��Titre��6%   	 �� Width$		 100��6[   
 �� DisplayMemberBinding
 64   �� *Titre+6[   �� 5      $��Modification��6%   $	 75��6i   
 6;   �� *Modification+6i   �� 5      $��Contenu��6%   $		 250��6]   
 66   �� *Texte+6]   5      5      �� 5   
   -   5        $
 Deco��5      $��Se Déconnecter��6   $
��Left=�68   $��363,276,0,0q�6S   $	��Top=�6h   $	��125��6�   5      5       