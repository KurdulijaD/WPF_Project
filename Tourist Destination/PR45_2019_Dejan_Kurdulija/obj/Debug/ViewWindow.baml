   M S B A M L   `   `   `  ????T  PPR45_2019_Dejan_Kurdulija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PR45_2019_Dejan_KurdulijaPR45_2019_Dejan_Kurdulija  5   	   *    $PR45_2019_Dejan_Kurdulija.ViewWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PR45_2019_Dejan_Kurdulija     5   	   -   5          ? Title$  
ViewWindow??5   	    ? SizeToContent$ WidthAndHeight=?6    ? WindowStyle$
 None=?6;    ? AllowsTransparency . 
?????? .??5	      ?? $	??750??6   $	??450??6    ? 	Resources 5   
   3  -System.Windows.Media.Effects.DropShadowEffect   dropMouseOverShadowRed   Color   	Direction   Opacity??%C   &	          5      $	 Red??6>   $ 90Q?6J   $ 80Q?6Y   5      .+?5   
   F? -   5        $??projPath??5   7   
???????$??3??6#   ??5      ?? 5       ?? ImageSource$ view_image.jpg??6   ??5      B? 5      .??5      E? 	 E? 
StartPoint$	 100, 0&?6!   .??5      ?? 
 ?? Point$
 650,0&?6&   ?? 5       ?? Size$ 150, 150??6%    ?? RotationAngle$ 90Q?65    ?? 
IsLargeArc .   ?? SweepDirection$ 	Clockwise=?6[    ?? Point$ 750, 100&?6v   ?? 5      $
 750, 350&?6&   ?? 5      $ 150, 150??6%   $ 90Q?65    .  $ 	Clockwise=?6[   $ 650, 450&?6v   ?? 5      $
 100, 450&?6&   ?? 5      $ 150, 150??6%   $ 90Q?65    .  $ 	Clockwise=?6[   $ 0, 350&?6v   ?? 5      $
 0, 100&?6&   ?? 5      $ 150, 150??6%   $ 90Q?65    .  $ 	Clockwise=?6[   $ 100, 0&?6v   5      5      5!      ?? 5#   
   -   5         ??Name$ viewLabelAgencija??5#      $??
 Agencija:??6+   
???????$
??Left=?6X   $??28??6s   $	??Top=?6   $??65??6?   
???   ? ?? Left$ 95??6?   
 ?? Top$ 88??6?   ?? 5$   
   -   5        $ viewLabelCena??5$      $??Cena ( € ) :??6'   
???????$
??Left=?6V   $??28??6q   $	??Top=?6}   $??65??6?   
???   ?$	 533??6?   $ 88??6?   ?? 5%   
   -   5        $ viewLabelDatum??5%      $??Datum polaska:??6(   
???????$
??Left=?6Y   $??28??6t   $	??Top=?6?   $??95??6?   
???   ?$	 324??6?   $ 88??6?   ?? 5&   
   -   5        $ viewLabelNaslov??5&      $?? ??6)   
???????
???   ?$
??Left=?6`   $	??Top=?6{   $	??320??6?   $??Center=?6?   $??Center=?6?   $??	Agency FB)?6?   $??35(?6?   $	 211??6
  $ 20??6  ?? 5'   
   -   5        $ viewAgencija??5'      
???   ?$ 70??69   $	 120??6J   $	??165??6[   $??40??6g   $??20(?6s   ?? 5(   
   -   5        $ 	viewDatum??5(      
???   ?$	 253??66   $	 120??6H   $	??240??6Y   $??35??6e   $??20(?6q   ?? 5)   
   -	   5        $ viewCena??5)      
???   ?$	 535??65   $	 120??6G   $??65??6X   $??35??6c   $??20(?6o   ?? 5*   
   -
   5        $??viewImgPhoto??5*      $
??Fill=?6$   $	??185??63   $	??245??6@   $ 40??6L   $	 165??6]   ?? 5+   
   -   5         ??Name$ viewRtbOpis??5+      
???   ?$
??Left=?6>   $	??185??6Y   $	??Top=?6f   $	??245??6~   $	 455??6?   $	 165??6?    ?? 
IsReadOnly .  J? Opacity$
 0.85Q?6?   ?? 5-   
   -   5         ??Name$ viewButtonIzadji??5-      $??Izadji??6+   $
??Left=?6=   $??40??6X   $	??Top=?6d   $	??155??6|   
???   ?
???????$	 280??6?   $	 395??6?   ??5.      ?? 5/       ?? 
TargetType" ??6    ?? Triggers 50      P? 51       P? Property ?@J?IsMouseOver P? Value . . ?52      ??  ?? Property ?@J?Effect ?? Value# [  67   53      55      57      59      5:      