   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CEvaluacion01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Evaluacion01Evaluacion01 5	   	      Evaluacion01.MainWindow   5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Evaluacion01     5	   	     � Title$  Maipo Grande��5   	   $	��468��6   $
��1038��6+   ��5      �� 5   
    �� ImageSource$ Imagenes/Image2.png��6    j� Stretch$ Uniform=�67   .��5      � $	��422��6   $��Bottom=�6   $��0,0,2,-3q�63   $��Right=�6E   $
��1018��6a   ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $
��179* �6   �� 5      $	��51* �6   �� 5      $	��15* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��65* �6   �� 5      $��5* �6   �� 5      $
��117* �6   �� 5      $	��49* �6   �� 5       $	��93* �6   �� 5!      $	��81* �6   �� 5"      $
��295* �6   �� 5#      $
��111* �6   �� 5$      $
��179* �6   �� 5%      $	��23* �6   .+�5,   
   �� $��64��6   $��
84,68,10,0q�6   $	��Top=�60   $.��(Imagenes/logo_transparent_background.png��6H   $��7��6z   $��4��6�   $��3��6�   #   MahApps.Metro.Controls.Flyout  5.   
   -   5          Name$ AgregarTransportista��5.      $��-10,-12,0,0q�68   $!��Ingresar
Transportista


��6M    J� RenderTransformOrigin$ 0.504,0.789&�6�   $	��202��6�   $��5��6�   $��4��6�   ��5/      �� 50       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��51      � 	 � Color$	 	#FF50DC1B��6#   
 � Offset$

 0.03Q�65   � 52      $	 White��6#   $
 1Q�61   � 53      $	 	#FFDEDE0C��6#   $
 0.567Q�65   � 54      $	 
WhiteSmoke��6#   $
 0.923Q�66   � 55      $	 	#FEEFEFEF��6#   $
 0.913Q�65   � 56      $	 	#FEB8EE00��6#   $	
 0.4Q�65   � 57      $	 	#FEE03610��6#   $

 0.66Q�65   � 58      $	 	#FFDDEAD9��6#   $
 1Q�65   59       J� OpacityMask 5;      �� 5<      $ 0.5,1&�6&   $ 0.5,0&�67   .��5=      � $	 Black��6#   $
 0Q�61   � 5>      $	 White��6#   $
 1Q�61   � 5?      $	 	#FFEE5E5E��6#   $
 0.857Q�65   � 5@      $	 	#FF4E9902��6#   $
 0.433Q�65   5A      .��5C      �� $	��259��6   $��0,0,13,0q�6"   $ 0.5,0.5&�64   z�5D      V� 5E      .~�5F      �� �� 5G       �� AngleX$ 0.107Q�6(   �� 5H      T� 5I       T� X$ 0.331Q�6-   5J      .+�5M      �� -   5         ��Name$ 
txt_nombre��5M       �� Left$ 10��6.   *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton .    	Watermark$ Ingrese su nombre��6m   $	��168��6�   �� 5O      -   5        $ txt_mail��5O      $ 10��6,    . $ Ingrese su mail��6k   $	��168��6�   
 �� Top$ 31��6�   �� 5Q      -   5        $ txt_telefono��5Q      $ 10��60    . $ Ingrese su telefono��6o   $	��168��6�   $ 62��6�   �� 5R      -   5        $ 	txt_razon��5R      $ 10��6-    . $ Años de experiencia��6l   $	��168��6�   $ 93��6�   �� 5S      -   5         ��Name$ cbo_tipoTransporte��5S      $	 155��67   $	��168��6H   $ 10��6T   $ Tipo Transporte��6e   �� 5T      -   5        $ cbo_tipoLicencia��5T      $ 10��65   $	 186��6F   $	��168��6W   $ Tipo Licencia��6c   �� 5U      -   5        $ 
cbo_Origen��5U      $	 124��6/   $	��168��6@   $ 10��6L   $ Origen��6]   �� 5V      $��Agregar��6   $
��Left=�6+   $	��Top=�6F   $��75��6^   $ 61��6i   $	 224��6z   5Y      5[      !   MahApps.Metro.Controls.Tile  5_   
   -	   5          Name$ Salir1��5_      $��6��6(   $��26,32,83,30q�68   $
��Auto��6M   $
��Auto��6Z      Title$  ��6h   $��4��6�   ��5`      �� 5a      .��5c      �� -
   5         ��Name$ Salir��5c      $��Imagenes/salir.png��6#   $ 
0.55,0.483&�6?   $��70��6b   $��60��6m   4  .System.Windows.Automation.AutomationProperties   Name$ salir��6y      IsOffscreenBehavior$ FromClip=�6�   z�5d      V� 5e      .~�5f      �� �� 5g       �� AngleY$ -0.76Q�6(   �� 5h       �� Angle$ 1.186Q�6*   T� 5i      $ -0.03Q�6-    T� Y$ -1.502Q�67   5j      5l      5m      �� 5o   
   -   5         ��Name$ btnContratos��5o      $�� ��6'   $��7��62   $
��Left=�6B   $��	10,32,0,0q�6]   $��4��6p   $	��Top=�6}   $��86��6�   $��65��6�   ��5p      �� 5q      $ Imagenes/imagen 2.png��6   5s      �� 5t   
   -   5        $ btnTransportista��5t      $�� ��6+   $��4��66   $
��Left=�6F   $��	35,32,0,0q�6a   $��4��6t   $	��Top=�6�   $��86��6�   $��65��6�   $��2��6�   ��5u      �� 5v      $ Imagenes/camions.png��6   5x      5�      5�      