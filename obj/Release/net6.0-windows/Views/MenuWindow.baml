   M S B A M L   `   `   `  ���� N  JProgettoInformatica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ProgettoInformatica.ViewModelsProgettoInformatica.ViewModels  E'clr-namespace:ProgettoInformatica.ViewsProgettoInformatica.Views  *    $ProgettoInformatica.Views.MenuWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     C
viewmodels,clr-namespace:ProgettoInformatica.ViewModels     9local'clr-namespace:ProgettoInformatica.Views       � 	Resources   �� 
TargetType 
  Option �� Property �� Value �� Triggers P� Property P� Value �� 
TargetType  TriggerCanvasBase �� Binding	 �� Value��%�  &	        '�� �     &	      �� " ��.���  � ��$ 5,0,5,0q���  � ��$	 100����  � ��$	 100����  � ��$ Center=� P�  �@J�IsMouseOver$
 true��. ���  �@�ForceCursor$
 True����  �@�Cursor$
 Hand���� " ��.���  � �� �� " ��.R��� #��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �#FFA500P�  �@J�IsMouseOver$
 True��. ���  � ��
 ���� ��  �@�ForceCursor$
 True����  �@�Cursor$
 Hand���� " ��.���  � y�$ Visible=� ��  �� *IsNewSavePressed+	 true.a���  � y�$ 	Collapsed=�.���� ���#0C6EC4._�� 
 � RowDefinitions
 �� $��50 ���  � ColumnDefinitions �� $��50 ��� �� $��50 �����  �� ImageSource$# ./Img/backgroundefinitivo.png�� j� Stretch$
 Fill=� j� TileMode$
 Tile=� j� ViewportUnits$ Absolute=� j� Viewport$ 0,0,1280,720� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .���  �� TargetProperty$ Background.Viewport�	 � To 1280,0,1280,720 g� Duration$ 0:1:15D� g� RepeatBehavior$ Forever�� g� AutoReverse$
 True��.+���  K� ZIndex$	 100��$��3��$��2��#��[ .+��� 
�������$
��1280��$	��720��$��1q�$��Center=�$	��Top=�$
}�True��
���   � J� Opacity$
 0.15Q�*   $ProgettoInformatica.Views.SaveWindow  $
��1280��$	��720����   ��%  '��       '�� �     �� " ��.���  � ��
 �������  � ��$ Roboto)���  � ��$ DemiBold"���  � ��$ Center=���  � ��$ Center=��� " ��.���  � y�$ Hidden=� ��  �� *IsVolumePressed+	 true.a���  � y�$ Visible=�.+��� ���#1988CF �� CornerRadius$ 20�� �� Left$
 1047��
 �� Top$ 50�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$
 Gray��   Opacity$	 0.4Q�    	Direction$	  230Q�!   
BlurRadius$! 20Q�._�� $	��200��$	��200��
 �� �� $��* � �� $��* ��� $��4* ��� $��* �.+��� $��1��$��1��$��Bottom=�$��0 0 0 30q�.+��� $��Regola il Volume:��$��0 0 0 10q�$
��Left=��� " � Maximum$	" 100Q��� $��2��
������ ���� *VolumePopUp+���� # �� RelativeSource# �� *Self+.���� $!��./Img/options-icon-blue.png��#��[  $
��Left=�$��5,0,0,0q�$��40���� $��2��$��2��$��Center=�$��Center=�.+��� $	��100(�$��Center=�
������ $��0q�$��Samurai Blast)����� *NavigateGameCommand+���� $ �� Orientation$$ 
Horizontal=�.+��� $��Gioca��$��Samurai Blast)����� % �� 
StartPoint$	% 1,1&�& �� EndPoint$	& 0,0&�.��� � ' � Color$' #2A9DFF��( � Offset$( 1Q�� $' #4AD6FF��$	( 0.2Q�   )   ShadowDepth$) 5Q�$	  300Q�$
 Gray��$	 0.6Q�$! 10Q��� $��Center=�$��./Img/playIcon.png��$	��120��$��80��   $) 6Q�$	  -30Q�$
 Gray��$	 0.6Q�$! 15Q��� $��1��$��2��
������ $��0q����� *NavigateShopCommand+.���� $"��./Img/shopping-cart-blue.png��$��40��$��40��