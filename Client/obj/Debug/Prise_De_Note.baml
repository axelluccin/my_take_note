   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClientClient  5   	       Client.Prise_De_Note   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Client     5   	     � Title$  Prise De Note��5   	   $��325.368��6   $��410.294��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��120 �6   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��Creer Une Note��60   $
��Left=�6I   $��	38,22,0,0q�6d   $	��Top=�6w   $	��125��6�   $��22��6�   ��6   �� *	CreatNote+6�   �� 5   
   $��
10,0,10,14q�65   $��0��6I   $��2��6Y   ��6   �� *
listNote+ � ContextMenu 5      �� 5      .@�5      m� $��Modification��6    m� CommandParameter 65   ��  �� RelativeSource ��  �� AncestorType$ ContextMenuL� �� Path$" PlacementTarget.SelectedItem� m� Command 6�   �� *
modif_note+m� 5      $��	Supprimer��6    62   ��  �� $ ContextMenuL�$" PlacementTarget.SelectedItem� 6�   �� *
sup_note+5      	 �� View	 5      �� 5      .P�5      �� $��Titre��6%   
 �� Width$
 50��6[    �� DisplayMemberBinding 64   �� *Titre+6[   �� 5      $��Modification��6%   $
 85��6i    6;   �� *Modification+6i   �� 5       $��Texte��6%   $	
 200��6[    64   �� *Texte+6[   5!      5#      �� 5$   
   $��Déconnexion��6*   $
��Left=�6@   $��	38,70,0,0q�6[   $	��Top=�6n   $	��125��6�   ��6   �� *Deco+6�   5&      5'      