   M S B A M L   `   `   `  ����G  CKidsMathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KidsMathGameKidsMathGame  5   	       KidsMathGame.Main   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KidsMathGame     5   	     � Title$
  Main��5   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�5	   	   ��5      �� 5   
    �� ImageSource$  Images/kidsnumbersWall.png��6    j� TileMode$
 Tile=�6>   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��1��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ White��6#    � Offset$ 0.448Q�61   � 5      $ 1Q�6#   5      5       � 5#   
   $��1��6   $��1��6   $��0q�6-   � 5,   
   $��3��6   ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $ White��6#   $ 0.838Q�61   � 50      51      .+�53      �� -   5        	 ��Name$	 FinalScrBtn��53      $��Final Scores��6+   $��40��6B   $	��146��6N   $��228,28,230,28q�6Z   $��Verdana)�6q   $
��Bold"�6�   $��20(�6�   ���	#FF0396F5
 J� Effect
 54      3  -System.Windows.Media.Effects.DropShadowEffect  55      57      �� 58      -   5        $	 	PlayGmBtn��58      $��	Play Game��6(   $	��146��6<   $��40��6H   $��-360,28,0,28q�6T   $��Verdana)�6j   $
��Bold"�6   $��20(�6�   ���	#FF87C502
 59        5:      5<      �� 5=      -   5        $	 
UserDtaBtn��5=      $��	User Data��6)   $��40��6=   $	��146��6I   $��0,28,-360,28q�6U   $��Verdana)�6k   $
��Bold"�6�   $��20(�6�   ���	#FFF1DC04
 5>        5?      5A      �� 5B      $��Kid's Math Game��6   $��-10,0,0,200q�6.   $��Center=�6C   $��Center=�6^   $��72(�6�   $��MV Boli)�6�   $
��Bold"�6�   ��6{   Z� 
 5C        5D      ��5F      �� 5G      $> 8Images/gradient-mesh-blurred-background-soft-rainbow.jpg��6!   5I      �� 5J      -   5         ��Name$ ChooseBtnLbl��5J      $�� ��6*   $��	0,200,0,0q�65   $��59��6H   $	��400��6T   $��Center=�6`   $��Source Code Pro)�6}   $��36(�6�   ���	#FFE7F10F$
��Bold"�6�   
 5K        5L      5N      5O      5P      5Q      