   M S B A M L   `   `   `  ���� N  JProgettoInformatica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProgettoInformatica.ViewsProgettoInformatica.Views  O,clr-namespace:ProgettoInformatica.ViewModelsProgettoInformatica.ViewModels  *    $ProgettoInformatica.Views.GameWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:ProgettoInformatica.Views     C
viewmodels,clr-namespace:ProgettoInformatica.ViewModels     .��� -     �Name$  BaseGrid������ -   Gradient�� �� 
StartPoint$	 1,1&� �� EndPoint$	 0,0&�.��� -   GradientStop1�� � Color$ #3194F4�� � Offset$	 0.7Q�� -   GradientStop2��$ #5571EC��$	 0.1Q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .����  �� 
TargetName$ GradientStop1�� �� TargetProperty$ Color�		 �� To	 #5571EC
 g� Duration$
 0:0:10D� g� RepeatBehavior$ Forever�� g� AutoReverse$
 True���� $ GradientStop2��$ Color�	 #3194F4$
 0:0:10D�$ Forever��$
 True�� � 	Resources  �� 
TargetType   UIButtonStyle �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  ScoreViewShowUp �� Binding �� Path �� Value  RobotAnimation N� EnterActions O� KeyTime O� Value  QuestionAnimation �� 	KeySpline��%N  &	        &	 �     &	 A    &	 _    �� " ��.���  � �� �� " ��.R��� #��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  �@�ForceCursor$
 True����  �@�Cursor$
 Hand���� " ��.���  � y�$ 	Collapsed=� ��  �� $ IsGameTerminated� true.a���  � y�$ Visible=��� " ��.���  � y�$ 	Collapsed=� ��  �� $ 
IsAnswered� true.a���  � y�$ Visible=� �� .���� .��U� $8 2(UIElement.RenderTransform).(TranslateTransform.X)�$
 0:0:4D�.\��� $ 0:0:1�� 200�� $ 0:0:3�� 200�� $ 0:0:4�� 0�� " � :� $ Loaded��.[��� .���� .��U� $8 2(UIElement.RenderTransform).(TranslateTransform.X)�$
 0:0:2D�.\��� $ 0:0:0�� 1080�� $ 0:0:1.5��$ 0.0,1.0 0.8,1�� 0 � RowDefinitions �� �� �� .+��� #��[  K� ZIndex$ 3��z�T�  T� X$ 0Q� T� Y$ 0Q�.+��   �� Left$
  -181��
! �� Top$	! 278��$��Center=�$	��Top=� �� $��* ��� $��20 �.+��� 
�������
������ " �� RadiusX$" 8��# �� RadiusY$# 10��F� 
�������$ �� Stretch$
$ Fill=�
������ $
��Left=�$��8.3,-1.597,0,0q�$��25��$��1��"����    2�� �    .�/��N� 	�� 
�������$" 10��$# 10��$��1q��� ���#5D70D1$��Center=�$��Center=�$��25(�$
��Wrap=�% �� Padding$% 5q����� *RispostaRobot+�� -   & ��Name$& robot��$	��Top=�$��./Img/default-robot.png��$
  -252��$	��110��$	��130��$��Center=�$	! 332���� -   ' ��Name$' volumePopUp��$ 3�� ��%  '��       '�� �     �� " ��.���  � �� �#5D70D1��  � ��$ Roboto)���  � ��$
 Bold"���  � ��$ Center=���  � ��$ Center=��� " ��.���  � y�$ Hidden=� ��  �� *IsVolumePressed+ true.a���  � y�$ Visible=�.+��� 
�������( �� CornerRadius$( 20��$
  1047��$! 50��) J� Effect) 3  -System.Windows.Media.Effects.DropShadowEffect  *   Color$
* Gray��+   Opacity$	+ 0.4Q�,   	Direction$	, 230Q�-   
BlurRadius$- 20Q�._�+   %ProgettoInformatica.Views.SoundWindow  $	��200��$	��200���� -   $' 	ScoreView��$��1��$	 100��$��Center=�#��[ .+��� 
�������$
��1280��$	��720��$��1q�$��Center=�$
! -122��$	��Top=�$
}�True��
���   �. J� Opacity$	. 0.1Q��� -   / ��Name$/ myButton��
������ $
��1280��$	��720��$��Center=�$
! -122��$	��Top=�#��[  $
}�True������ *GameTerminatedCommand+.��+   %ProgettoInformatica.Views.ScoreWindow  $	��900��$	��500���  ��%�   '��       '�� G     �� " ��.���  �@��CornerRadius$ 5����  � ��
 ������� " ��.���  � �� �#5D70D1��  � ��$ Roboto)���  � ��$
 Bold"���  � ��$ Center=���  � ��$ Center=� �� $��50 ��� 0 � ColumnDefinitions0 �� $	��.2* ��� $��2* ��� $	��.2* �.+��� $��30(�
�������$��1��$��0:0:40���� 1 �� Orientation$1 
Horizontal=�.+��� 
������ $��0q�#��[  ���� *NavigateMenuCommand+.���� $��./Img/left-arrow.png��$	��0 5q��� $
��Quiz��$��Center=�$��25(�
�������$��
Dilo World)�%   ProgettoInformatica.Views.UIBar  $��1��$��2���� $��2��
������ $��60 0 0 0q�#��[  ���� *VolumePopUp+���� 2 �� RelativeSource2 �� *Self+.���� $��Right=�$"��.\Img\options-icon-white.png��$��40��� $��1��$��200 0q�#��[ z�T� $ 0Q�$ 0Q� �� $��* ��� $��50 �.+�F� 
�������$
$ Fill=�
������ $��Right=�$��8.3,-1.7,18,0q�$��50��$��1��"����    �N� � ��.�/���� 	�� 
�������$" 20��$# 20��$��1q��� ���#5D70D1$��SemiBold"�$��Roboto)�$��Center=�$��Center=�$��30(����� *CartaCorrente.Quesito+� $��2��$��0 75 0 0q� 3   ShadowDepth4 ��Name5 �� 	Resources6 N� ExitActions��%�  '��       �� " ��.���  � ��$ 10q���  � ��$
 0 10q���  � ��$	 440����  � ��$
 Bold"���  � ��
 �������  � ��$ 20(���  � �� �#5D70D1��  � ��$ Roboto)���  �@J�Effect   $3 5Q�$	, 300Q�$
* Gray��$	+ 0.5Q�$- 10Q���  � �� �� " ��.R��� $4 ButtonBorder��
������ $��3q�$( 10��#��z��._��� $��Center=�$��Center=�5 ���� '��       " ��.���  �@��CornerRadius$ 15�� P�  �@J�IsMouseOver$
 True��. ���  �@�ForceCursor$
 True����  �@�Cursor$
 Hand�� �� .���� .��U� $ Width�$
 0:0:.1D�.\��� $ 0:0:.1�� 4606 �� .���� .��U� $ Width�$
 0:0:.1D�.\��� $ 0:0:.1�� 4400 �� ��  �� �� .+��� $��0������ *CartaCorrente.Risposte[0]+���� *ChangeButtonColor+���� 2 �� *Self+�� $��0��$��1������ *CartaCorrente.Risposte[1]+���� *ChangeButtonColor+���� 2 �� *Self+�� $��1������ *CartaCorrente.Risposte[2]+���� *ChangeButtonColor+���� 2 �� *Self+�� $��1��$��1������ *CartaCorrente.Risposte[3]+���� *ChangeButtonColor+���� 2 �� *Self+