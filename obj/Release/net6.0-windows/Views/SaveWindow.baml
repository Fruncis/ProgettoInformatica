   M S B A M L   `   `   `  ���� N  JProgettoInformatica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ProgettoInformatica.ViewsProgettoInformatica.Views  O,clr-namespace:ProgettoInformatica.ViewModelsProgettoInformatica.ViewModels  *    $ProgettoInformatica.Views.SaveWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:ProgettoInformatica.Views     C
viewmodels,clr-namespace:ProgettoInformatica.ViewModels     .��� .+��� $��Center=�$��Center=�$	��500��  � 	Resources   �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color   Opacity   
BlurRadius �� 
TargetType	 ��Name
 �� CornerRadius �� 	Resources �� Triggers P� Property P� Value N� EnterActions �� TargetProperty g� Duration O� KeyTime O� Value N� ExitActions��%  '��       '�� v     �� " ��.���  � ��
 �������  � ��$ Times New Roman)���  � ��$
 Bold"���  � ��$ 15(��� " ��.���  � �� �#5875d1��  � ��$ 0q���  � ��$ 0 25 0 0q���  � ��$ 80����  � ��$	 460����  �@J�Effect   $ 0Q�$
 Gray��$ .6Q�$ 10Q���  � �� �� " ��.R��� $	 ButtonBorder��
������ $��3q�$
 10��#��z��._��� $��Center=�$��Center=� ���� '��       " ��.���  �@��CornerRadius$ 15�� P�  �@J�IsMouseOver$
 True��. ���  �@�ForceCursor$
 True����  �@�Cursor$
 Hand�� �� .���� .��U� $ Width�$ 0:0:.1D�.\��� $ 0:0:.1�� 480 �� .���� .��U� $ Width�$ 0:0:.1D�.\��� $ 0:0:.1�� 460.+��� ���#6579e2$
 15��$��75��$��40 15q�._��� $"��Seleziona il tuo salvataggio��$��Center=�
�������$��Center=�$��DemiBold"�$��Segoe UI)��� $��Times New Roman)����� *
LoadSave+.����  �� Orientation$ 
Horizontal=�.+��� $%��Continua da dove avevi lasciato���� ���� *ButtonSaveCommand+.���� $��Ricomincia daccapo���  � ColumnDefinitions �� ��    �� Binding �� Value��%  '��       '� �    �� " ��.���  � �� �#5875d1��  � ��$ 0q���  � ��$ 0 25 0 0q���  � ��$ 80����  � ��$	 460����  �@J�Effect   $ 0Q�$
 Gray��$ .6Q�$ 10Q���  � �� �� " ��.R��� $	 ButtonBorder��
������ $��3q�$
 10��#��z��._��� $��Center=�$��Center=� ���� '��       " ��.���  �@��CornerRadius$ 15���� " �.���  � y�$ 	Collapsed=� ��  �� *IsLoadSavePressed+ true.a���  � y�$ Visible=�.+��� $	��150������ *ButtonSaveCommand+.���� $��No���� $��1��$	��150������ *	NewSave+.���� $��Si��