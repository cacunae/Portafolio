   M S B A M L   `   `   `  ����G  CEvaluacion01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Evaluacion01Evaluacion01  5   	   "    Evaluacion01.listadoContrato   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Evaluacion01     5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  	Contratos��5	   	   $	��450��6   $	��800��6(   .��5
      � ��5   
   �� 5       �� ImageSource$ Imagenes/fondo frutas.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridcontrato��5      $
��Left=�6)   $	��190��6D   $��
80,200,0,0q�6Q   $	��Top=�6e   $	��673��6}   ���	#FFEADD5D6�   �� 5   
   -   5        $
��Left=�5      $��	80,82,0,0q�6-   $	��Top=�6@   $��75��6X   $��79��6c   ��5      �� 5      $ Imagenes/relog.png��6   5      �� 5   
   -   5         ��Name$ 
btnFiltrar��5      $��Filtrar��6%   $
��Left=�67   $��175,132,0,0q�6R   $	��Top=�6g   $��75��6   $��0q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFECC9C9��6#      ShadowDepth$ 3Q�65   5      �� 5   
   -   5         ��Name$ cbEstado��5      $
��Left=�6&   $��175,101,0,0q�6A   $	��Top=�6V   $	��120��6n   !  MahApps.Metro.Controls.Tile  5   
   -   5          Name$ Salir1��5      $��596,82,10,258q�6#   $
��Auto��6:   $
��Auto��6G   	   Title$	  ��6U   ��5      �� 5      .��5      �� -   5        
 ��Name$
 Salir��5      $��Imagenes/salir.png��6#    J� RenderTransformOrigin$ 
0.55,0.483&�6?   $��70��6b   $��60��6m   4  .System.Windows.Automation.AutomationProperties   Name$ salir��6y      IsOffscreenBehavior$ FromClip=�6�   z�5      V� 5       .~�5!      �� �� 5"       �� AngleY$ -0.76Q�6(   �� 5#       �� Angle$ 1.186Q�6*   T� 5$       T� X$ -0.03Q�6-    T� Y$ -1.502Q�67   5%      5'      5(      5*      5+      