   M S B A M L   `   `   `  ����R  N227974-MARS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6505eeda710e1f37M+clr-namespace:HMI.Resources.UserControls.MOHMI.Resources.UserControls.MO  5   
   )    #HMI.MainRegion.MO.Views.MO_MainView   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   Z VVisiWin7.System.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241cX TVisiWin7.View.WPF, Version=7.2.0.0, Culture=neutral, PublicKeyToken=3d70d0e64510241c&vwhttp://inosoft.com/visiwin7   5   
   6UC+clr-namespace:HMI.Resources.UserControls.MO   5   
   $
��1832��5   
   $
��1000��6      FP_Black_Gradient#��[  6%   .��5      � .+�5	   
   �� -   5          ��Name$	  Mod��5	      $	��Top=�6   $��5q�66    �� CornerRadius$ 0,0,200,200��6J     FP_Red_Gradient#���  6e   $��Center=�6�   $��80��6�   $
��1000��6�    J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ White��6#      	Direction$	 270Q�61      Opacity$	 0.7Q�6A   ._�5         VisiWin.Controls.TextBlock  -   5          Name$	 txt��5      $��Center=�6(   $��Center=�6C   
�������$
��Bold"�6s   $��24(�6�   5      !  VisiWin.Controls.PictureBox  5   
      SymbolResourceKey$ 
MV_MCPZWZ2��6   $	��946��67   $	��746��6C   $��
645,97,0,0q�6P   $
��Left=�6d   $	��Top=�6    5        5      $ Orange��6#      
BlurRadius$ 20Q�62   $ 90Q�6C   $	 0.5Q�6S   5        5   
   $
 Mars��6   $��3q�61   $	��503��6F   $	��503��6R   $��762,223,0,0q�6_   $
��Left=�6t   $	��Top=�6�   � 5   
   -   5        	 �Name$	 
LayoutRoot��5      $��0,30,0,0q�6$   6Q   ,   &HMI.Resources.UserControls.MO.MVBasket  5   
   $��677,341,0,0q�6   $
��Left=�6,   $	��Top=�6G   
   IsBasket$Q
 KCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Baskets.isBaskets��5         
IsMaterial$Q KCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Charge.isMaterial��5         SetLayer$Q KCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Charge.Layers.Set��5         ActualLayer$T NCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Charge.Layers.Actual��5      
   CPU$
 CPU1��5      	   AS$	 Set��6&     5   
   $��677,382,0,0q�6   $
��Left=�6+   $	��Top=�6F   $Q
 KCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Baskets.isBaskets��5      $Q KCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Charge.isMaterial��5       $Q KCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Charge.Layers.Set��5!      $T NCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Charge.Layers.Actual��5"         IsDischarge$[ UCPU1.PLC.Blocks.02 Basket handling.03 BT.00 Main.DB BT PD.Baskets.Functions.Discharge��5#      $
 CPU1��5$         Station$ 4��6%   $ Actual��61     VisiWin.Controls.Button  5&   
   -   5        $y�	Collapsed=�5&      $
��Left=�6+   $	��Top=�6F   $	��150��6^   $	��105��6j     
B_Material#���  6w   $��640,366,0,0q�6�   6�     5'   
   -   5        $
��Left=�5'      $	��Top=�6/   $��70��6G   $	��125��6R   #���  6_   $��672,336,0,0q�6�   6�   0   *HMI.Resources.UserControls.MO.M_WorkMode_R  5*   
   $
��Left=�6   $	��Top=�65   $��	20,10,0,0q�6M      Header$ @MachineOverview.Text8��5+         	Automatic$e _CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.from.Operating Mode.Automatic��5,         Manual$b \CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.from.Operating Mode.Manual��5-         SetUp$a [CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.from.Operating Mode.Setup��5.         Start$\ VCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.from.Automatic.Start��5/         Stop$[ UCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.from.Automatic.Stop��50         StartStatus$Z TCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.to.Automatic.State��51         WorkingModeStatus$_ YCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket feeding.to.Operating Mode.State��52      0   *HMI.Resources.UserControls.MO.M_WorkMode_L  55   
   $��Right=�6   $	��Top=�66   $��	0,10,10,0q�6N      Header$ @MachineOverview.Text17��56         	Automatic$f `CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.from.Operating Mode.Automatic��57         Manual$c ]CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.from.Operating Mode.Manual��58         SetUp$b \CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.from.Operating Mode.Setup��59         Start$] WCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.from.Automatic.Start��5:         Stop$\ VCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.from.Automatic.Stop��5;          StartStatus$[  UCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.to.Automatic.State��5<      !   WorkingModeStatus$`! ZCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket handling.to.Operating Mode.State��5=        5?   
   $
��Left=�6   $��Bottom=�65   $��	20,0,0,10q�6P   $ @MachineOverview.Text18��5@      $e _CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.from.Operating Mode.Automatic��5A      $b \CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.from.Operating Mode.Manual��5B      $a [CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.from.Operating Mode.Setup��5C      $\ VCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.from.Automatic.Start��5D      $[ UCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.from.Automatic.Stop��5E      $Z TCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.to.Automatic.State��5F      $_ YCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Basket coating.to.Operating Mode.State��5G      � 5J   
   -   5        $	 powerOFF��5J        DialogSurroundBrush#���  6!   $y�Hidden=�6T   .+�5K        VisiWin.Controls.Border  
�������" J� Opacity$	" 0.7Q�6,   $
��1010��6:   $	��410��6G   $��Center=�6T   $��Center=�6q    5L      -	  'System.Windows.Media.Effects.BlurEffect	  5M      # 	  Radius$# 10Q�6!   5O      �� 5P      $
��1000��6   $	��400��6"     FP_Yellow_Gradient#���  6/   $��5q�6a   #���  6u     5Q      $��24(�6   $
��Bold"�6)   $��	0,340,0,0q�6;   $ �� TextAlignment$$ Center=�6O   $��Center=�6f   $	��Top=�6�   $��65��6�   %   LocalizableText$% @MachineOverview.Text48��6�     5R      $��65��6   $��24(�6'   $
��Bold"�65   $��	0,0,0,340q�6G   $$ Center=�6Z   $��Center=�6q   $��Bottom=�6�   $% @MachineOverview.Text49��6�   � 5S      $��Center=�6   $	��100��67   $��0q�6D   $��Center=�6O   $	��950��6j     
PB_Loading#���  6v    
 FP_Red#���  6�   
���   �$��3q�6�   & � Minimum$& 0Q�6�   ' � Maximum$	' 500Q�6�   ( � Value( 6  1
  +VisiWin.Extensions.VariableBindingExtension
  ) 
  VariableName$^) XCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Gerneral.to.Control voltage.Countdown��5T      � 5U   
   $��Center=�6   $��Bottom=�6,   $	��270��6G   $	��130��6S   $��
0,0,600,20q�6`   .+�5V        
�������$	" 0.7Q�6,   $��-5q�6:    5W      	  5X      $# 10Q�6!   5Z        5[      #���  6   #���  6K   $��5q�6{   *   Child.* 5]      � .+�5^        VisiWin.Controls.Key  -   5        +  Name$+ ON��5^      $	��100��6)   $��80��65   $
��Left=�6A   $��20,0,0,0q�6]   $��Center=�6o   ,   LocalizableText$, @Buttons.Text19��6�     	B_Gray_ns#���  6�   -   KeyMode$- KeyMode=�6�   $��20(�6�   $
��Bold"�6�   .   VariableName$Y. SCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Gerneral.from.Control voltage.On��6  /   AuthorizationRight$/ MachineOnOff��6e    5_      -   5        $	+ OFF��5_      $	��100��6*   $��80��66   $��Right=�6B   $��0,0,20,0q�6^   $��Center=�6p   $, @Buttons.Text17��6�     B_Red_ns#���  6�   $- KeyMode=�6�   $��20(�6�   $
��Bold"�6�   $Z. TCPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Gerneral.from.Control voltage.Off��6  $/ MachineOnOff��6g  5`      5b      5c      5g      5i      