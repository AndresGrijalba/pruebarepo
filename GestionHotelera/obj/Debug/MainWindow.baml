   M S B A M L   `   `   `  ����J  FGestionHotelera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GestionHoteleraGestionHotelera  5   	        GestionHotelera.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:GestionHotelera     5   	   -   5          �Name$
  home��5       � Title$ 
MainWindow��5   	   $	��720��6   $
��1080��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      ��  �� CornerRadius$ 10��6      PrimaryColor#���   6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      �� $ 	10 0 0 10��6   	 �� Padding$	 10q�5        SecundaryColor#���  5      ._�5      � -   5        
 �Name$
 gridMenu��5       � RowDefinitions 5      �� 5      $��60 �6(   �� 5      $��* �6(   �� 5      $��60 �6(   .+�5       �� $��0��6!    �� Orientation$ 
Horizontal=�6.   .+�5!      �� $��/Images/logo.png��6    $
��Fill=�6:   $��36��6I   $��36��6U   $��Center=�6`   $��10 0 0 0q�6{   �� 5"      $��Hotel Berlin��6    #���   67   $
��Bold"�6c   $��24(�6u   $��Center=�6�   $
��Left=�6�   $
��Left=�6�   $��5 0 0 0q�6�   5#      �� 5%      $��1��6!   $��Center=�6.   .+�5&      	� -   5         	�Name$ rdRegistrarReserva��5&   &   $��Registrar Reserva��6B    ! MenuRadioButtonStyleRReservas#���  6^   $��0 30 0 0q�6�   6�   	� 5'      -   5        $ 
rdReservas��5'   &   $��Reservas��6:      MenuRadioButtonStyleReservas#���  6M   $��0 1 0 1q�6�   6�   	� 5(      -   5        $ rdHabitaciones��5(   &   $��Habitaciones��6>    $  MenuRadioButtonStyleHabitaciones#���  6U   $��0 1 0 1q�6�   6�   	� 5)      -   5        $ 
rdUsuarios��5)   &   $��Usuarios��6:      MenuRadioButtonStyleUsuarios#���  6M   $��0 1 0 1q�6�   6�   51      �� 53      $��2��6!   $��Bottom=�6.   .+�54      �� $��Administrador��6    $��25(�68   $
��Bold"�6F   #���   6X   $��10 0 0 0q�6�   �� 55      $��hotelberlinva@gmail.com��6    #���   6B   $��
10 -10 0 0q�6n   56      59      5:      � 5<      $��1��6    5=      �� 5>      $��60 �6$   �� 5?      .+�5B      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $ 
Horizontal=�6�   $��RightToLeft=�6�   .+�5C      �� -   5         ��Name$ btnClose��5C      $��X��6/   $��Center=�6R   $��Center=�6m   $��SemiBold"�6�   ��5D      �� 5E       �� 
TargetType" ��6$   .�5F   "   ��  �� Property � �� �� Value# �   6?    �� Triggers 5G   "   P� 5H   &    P� Property �@J�IsMouseOver P� Value . . �5I   *   ��  � ��
 �  ��6G   �� 5J   *    � ��# �   6G   �� 5K   *    � ��$
 Bold"�6G   5L   '   5N      ��5Q      �� 5R       �� 
TargetType" ��6.   .R�5S   "   �� $��20��6)   $��20��64   $ 5��5T   )   #��z��5U   )   ._�5V   &   �� $��Center=�67   $��Center=�5W   7   5X   #   5Y      5[      �� 5]      -   5        $ btnMinimize��5]      $��-��62   $��15(�6X   $��SemiBold"�6f   ��5^      �� 5_      " ��6$   .�5`   "   ��  � ��# �   6?    5a   "   P� 5b   &    �@J�IsMouseOver . . �5c   *   ��  � ��  TertiaryColor# �  6G   �� 5d   *    � ��$
 Bold"�6G   5e   '   5g      ��5j      �� 5k      " ��6.   .R�5l   "   �� $��20��6)   $��20��64   $ 5��5m   )   #��z��5n   )   ._�5o   &   �� $��Center=�67   $��Center=�5p   7   5q   #   5r      5t      5u      �� 5w      $��1��6   $ 0 0 5 0��6&   
������ ._�5x       � -	   5          �Name$ frameContent��5x        � NavigationUIVisibility$ Hidden=�62   $��10q�6R   5y      5{      5|      5}      5~      