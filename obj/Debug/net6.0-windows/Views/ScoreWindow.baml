   M S B A M L   `   `   `  ����N  JProgettoInformatica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProgettoInformatica.ViewsProgettoInformatica.Views  5      O,clr-namespace:ProgettoInformatica.ViewModelsProgettoInformatica.ViewModels  5      E'clr-namespace:ProgettoInformatica.ModelProgettoInformatica.Model  6N   +    %ProgettoInformatica.Views.ScoreWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ProgettoInformatica.Views     5      C
viewmodels,clr-namespace:ProgettoInformatica.ViewModels     5      9model'clr-namespace:ProgettoInformatica.Model     6N     � 	Resources  5       �� 
TargetType   shadowBorder �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   	Direction   Color   Opacity   
BlurRadius��%O  &	        �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       �@J�Opacity$ 1Q�6(   �� 5       �@��CornerRadius$ 40��6-   �� 5       �@J�Effect 5        5      $ 10Q�5   %   $	 270Q�5   %   $
 Gray��5   %   $	 0.3Q�5   %   $ 80Q�5   %   5      5      5      .��5      �   5   
   	 �� 
TargetType
 ��Name �� CornerRadius �� 	Resources �� Triggers P� Property P� Value��%  '��       '�� E    �� 5      " ��6   .�5       ��  � ��$ 10q�6,   �� 5!       � ��$ 100 10q�6+   �� 5"       � ��$
 Bold"�6/   �� 5#       � ��
 �����6/   �� 5$       � ��$ 20(�6-   �� 5%       � �� �#5D70D16/   �� 5&       � ��$ Roboto)�6/   �� 51       � �� 52      �� 53      "	 ��6*   .R�54      �� $
 ButtonBorder��6%   
������ $��3q�6U   $ 10��6i   #��z��6{   ._�57   "   �� $��Center=�63   $��Center=�6P   59   #   5:      5;      5=       5>      ���� 5?      '��       " ��6   .�5@      ��  �@��CornerRadius$ 15��69   5A      5B       5D      P� 5E       �@J�IsMouseOver$
 True��65   . �5F      ��  �@�ForceCursor$
 True��68   �� 5G       �@�Cursor$
 Hand��63   5P      5S      �� 5T      " ��6   .�5U      ��  � �� �#5D70D16/   �� 5V       � ��$ Roboto)�6/   �� 5W       � ��$
 Bold"�6/   �� 5X       � ��$ Center=�66   5Y      5Z       � ColumnDefinitions 5]   
   �� 5^      �� 5_      $��4* �6   �� 5`       � RowDefinitions 5c   
   �� 5d      $��* �6   �� 5e      $��3* �6   .+�5g   
   �� $��2��6   $��3��6"   #��[  66   �� 5h   
   $��1��6   $��50(�6g   $��Center=�6u   ��6$   �� *	Punteggio+ �� StringFormat$ Punteggio Totale {0}/10��6u   � 5i   
   $��2��6   $��1��6    5j      �� 5k      �� 5l      �� 5m      $��80 �6    .+�5o      ��  �� Orientation$ 
Horizontal=�6   .+�5p      �� $��Esperienza:��6   $��30(�6/   �� 5q      $��30(�6B   $��20 0 0 0q�6Q   ��6   �� *Giocatore.Esperienza+5�      5�      �� 5�      $ 
Horizontal=�6   $��1��62   .+�5�      �� $��Gettoni:��6   $��30(�6-   �� 5�      $��30(�6T   $��20 0 0 0q�6c   ��6   �� *Giocatore.Gettoni+$
  {0}��6c   5�      5�      5�      5�      