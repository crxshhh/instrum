   M S B A M L   `   `   `  ����B  >Lesson2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lesson2Lesson2  5   	       Lesson2.InkCanvass   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Lesson2     5   	   -   5          � Title$  Работа InkCanvas��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $��22 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   .+�5      �� $��5q�6   $/��)Режим редактирования: ��6#   �� 5      -   5         ��Name$ IstEditingMode��5      $��Center=�6,   $��0,0,10,0q�6G   5      �� 5   
   -   5         ��Name$ inkCanvasPanel��5      $��1��6,    �� 
Background �	#FF8ADCCD �� EditingMode 6P   �� *SelectedItem+ �� ElementName$ IstEditingMode��.H�5      �� $��Кнопка��6    �� Left$ 10��6&   
	 �� Top$	 10��6:   �� 5      $	 100��6   $	 30��6+   $��
Текст��6>   5      �� 5   
   -   5        
 ��Name$
 gestureName��5      $��Bottom=�6'   $��2��6B   5      5      