   M S B A M L   `   `   `  ����G  CKidsMathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KidsMathGameKidsMathGame  5   	       KidsMathGame.Game   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:KidsMathGame     5   	   -   5          � Title$
  Game��5   	   $��381.333��6   $	��620��6'    � WindowStartupLocation$ CenterScreen=�5	   	   ��5      �� 5   
    �� ImageSource$  Images/kidsnumbersWall.png��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��1��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ White��6#    � Offset$ 0.448Q�61   � 5      $ 1Q�6#   5      .+�5!      �� -   5         ��Name$ QuitBtn��5!      $��Quit to Menu��6&   $��-443,10,0,10q�6>   $��96��6T   $��35��6_   $��Verdana)�6k   $
��Bold"�6�   ���	#FFF4062F	 J� Effect	 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#      5%      �� 5&      -   5        $ StartBtn��5&      $��Start��6'   $��	0,10,0,10q�67   $��35��6K   $��Verdana)�6W   $��14(�6l   $
��Bold"�6z   $��96��6�   ���	#FF0396F5	 5'        5(      5*      5+      � 5.   
   $��1��6   $��1��6   $��0q�6-   .+�5/      �� -   5        
 ��Name$
 
outcomeLbl��5/      $�� ��6(   $��
0,10,0,120q�63   $��59��6G   $	��290��6S   $��Source Code Pro)�6_   $��36(�6|   ���	#FFF10F0F$
��Bold"�6�   	 50        51      53      �� 54       �� Orientation$ 
Horizontal=�6   $��75��63   $��140,78,130,35q�6?   
�������	 55        56      .+�58      �� -   5        $
 num1Lbl��58      $��10��6)   $��54��66   $��85��6B   $��Verdana)�6M   $��36(�6b   $
��Bold"�6p   $��	15,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�   �� 59      -   5        $
 operatorLbl��59      $��+��6-   $��54��69   $��46��6E   $��Verdana)�6P   $��36(�6e   $
��Bold"�6s   $��0,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�   �� 5:      -   5        $
 num2Lbl��5:      $��10��6)   $��54��66   $��68��6B   $��Verdana)�6M   $��36(�6b   $
��Bold"�6p   $��0,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�   �� 5;      -   5        $
 	equalsLbl��5;      $��=��6+   $��54��67   $��47��6C   $��Verdana)�6N   $��36(�6c   $
��Bold"�6q   $��0,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�   �� 5<      -	   5         ��Name$ 	userTxtBx��5<      $��54��6-    �� TextWrapping$
 Wrap=�6:   $�� ��6N   $��61��6V   $��Verdana)�6a   $��36(�6v   $
��Bold"�6�   $��0,10,0,0q�6�   $
��Left=�6�   $	��Top=�6�   6�   5=      5>      � 5G   
   $��2��6   ��5H      �� 5I      $ 0.5,1&�6&   $ 0.5,0&�67   .��5J      � $ White��6#   $	 0.5Q�61   � 5K      5L      .+�5N      �� -
   5        $ 	SubmitBtn��5N      $��Submit��6(   $��40��69   $	��134��6E   $��228,28,230,28q�6Q   $��Verdana)�6h   $
��Bold"�6}   $��20(�6�   ���	#FF87C502	 5O        5P      5R      5S      �� 5T   
   
���   �$��1q�6%   $��35��69   $	��130��6E   $��435,10,28,10q�6Q   
�������	 5U        5V      ._�5X      �� -   5        $
 TimerLbl��5X      $�� ��6&   $��Verdana)�61   $��20(�6F   $��9,-1,9,3q�6T   5Y      5Z      5[      