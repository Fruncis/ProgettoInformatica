   M S B A M L   `   `   `  ���� N  JProgettoInformatica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProgettoInformatica.ViewsProgettoInformatica.Views  O,clr-namespace:ProgettoInformatica.ViewModelsProgettoInformatica.ViewModels  E'clr-namespace:ProgettoInformatica.ModelProgettoInformatica.Model  +    %ProgettoInformatica.Views.ScoreWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:ProgettoInformatica.Views     C
viewmodels,clr-namespace:ProgettoInformatica.ViewModels     9model'clr-namespace:ProgettoInformatica.Model       � 	Resources   �� 
TargetType   shadowBorder �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   	Direction   Color   Opacity   
BlurRadius��%�   &	        �� " ��.���  � ��
 �������  �@J�Opacity$ 1Q���  �@��CornerRadius$ 40����  �@J�Effect   $ 10Q�$	 270Q�$
 Gray��$	 0.3Q�$ 80Q�.���   	 �� 
TargetType
 ��Name �� CornerRadius �� 	Resources �� Triggers P� Property P� Value��%n  '��       '�� �    �� " ��.���  � ��$ 10q���  � ��$ 100 10q���  � ��$
 Bold"���  � ��
 �������  � ��$ 20(���  � �� �#5D70D1��  � ��$ Roboto)���  � �� �� "	 ��.R��� $
 ButtonBorder��
������ $��3q�$ 10��#��z��._��� $��Center=�$��Center=� ���� '��       " ��.���  �@��CornerRadius$ 15�� P�  �@J�IsMouseOver$
 True��. ���  �@�ForceCursor$
 True����  �@�Cursor$
 Hand���� " ��.���  � �� �#5D70D1��  � ��$ Roboto)���  � ��$
 Bold"���  � ��$ Center=� � ColumnDefinitions �� �� $��4* ���  � RowDefinitions �� $��* ��� $��3* �.+��� $��2��$��3��#��[  �� $��1��$��50(�$��Center=����� *	Punteggio+ �� StringFormat$ Punteggio Totale {0}/10��� $��2��$��1�� �� �� �� $��80 �.+���  �� Orientation$ 
Horizontal=�.+��� $��Esperienza:��$��30(��� $��30(�$��20 0 0 0q����� *Giocatore.Esperienza+�� $ 
Horizontal=�$��1��.+��� $��Gettoni:��$��30(��� $��30(�$��20 0 0 0q����� *Giocatore.Gettoni+$
  {0}��