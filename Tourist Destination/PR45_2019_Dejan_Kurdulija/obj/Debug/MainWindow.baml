   M S B A M L   `   `   `  ????T  PPR45_2019_Dejan_Kurdulija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PR45_2019_Dejan_KurdulijaPR45_2019_Dejan_Kurdulija  5   	   *    $PR45_2019_Dejan_Kurdulija.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PR45_2019_Dejan_Kurdulija     5   	   -   5          ? Title$  
MainWindow??5   	    ? SizeToContent$ WidthAndHeight=?6    ? WindowStyle$
 None=?6;    ? AllowsTransparency . 
?????? .??5      ?? $	??750??6   $	??450??6    ? 	Resources 5   
   3  -System.Windows.Media.Effects.DropShadowEffect   dropMouseOverShadowGreen   Color   	Direction   Opacity  dropMouseOverShadowRed??%?   &	        &	 @       5      $ 
LightGreen??6@   $ 90Q?6S   $ 80Q?6b     5      $	 Red??6>   $ 90Q?6J   $ 80Q?6Y   5      .+?5   
   F? -   5        $??projPath??5   7   
???????$??3??6#   ??5      ?? 5       ?? ImageSource$ add_slika.jpg??6   ??5      B? 5      .??5      E? 	 E? 
StartPoint$	 100, 0&?6!   .??5      ?? 
 ?? Point$
 650,0&?6&   ?? 5       ?? Size$ 150, 150??6%    ?? RotationAngle$ 90Q?65    ?? 
IsLargeArc .   ?? SweepDirection$ 	Clockwise=?6[    ?? Point$ 750, 100&?6v   ?? 5      $
 750, 350&?6&   ?? 5      $ 150, 150??6%   $ 90Q?65    .  $ 	Clockwise=?6[   $ 650, 450&?6v   ?? 5      $
 100, 450&?6&   ?? 5      $ 150, 150??6%   $ 90Q?65    .  $ 	Clockwise=?6[   $ 0, 350&?6v   ?? 5      $
 0, 100&?6&   ?? 5       $ 150, 150??6%   $ 90Q?65    .  $ 	Clockwise=?6[   $ 100, 0&?6v   5!      5"      5$      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ dataGridDestinacije??5&      $	??730??61   $	??280??6=   
 ?? Top$ 85??6J    ?? Left$ 10??6Z    J? Opacity$
 0.75Q?6k      AutoGenerateColumns .     SelectionMode$ Single=?6?      
IsReadOnly .    CanUserResizeColumns .     CanUserResizeRows .  ??6z   ?? *destinacije+   Columns 5'      4  .System.Windows.Controls.DataGridTemplateColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Slika??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68      CanUserSort .     CellTemplate 5*      ?? 5+      .R?5,      ?? $??75??6=   $??75??6I   $??Center=?6T   $
??Fill=?6q   ??6$   ?? *Slika+6q   5-      5/      0  *System.Windows.Controls.DataGridTextColumn  51      $ Naziv??6%   $	 100 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   ?? *Naziv+   HeaderStyle 52      ?? 53        ?? 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"   6    .?54      ?? ! ?? Property! ? ??" ?? Value$" Center=?6D   ?? 55      ! ? ??$" Center=?6B   56      #   ElementStyle# 58      ?? 59      "  ??6    .?5:      ?? ! ? ??$" Center=?6D   ?? 5;      ! ? ??$" Center=?6B   5<      5>        5@      $ Agencija??6%   $	 100 6T    67   ?? *
Agencija+ 5A      ?? 5B      "   6    .?5C      ?? ! ? ??$" Center=?6D   ?? 5D      ! ? ??$" Center=?6B   5E      # 5G      ?? 5H      "  ??6    .?5I      ?? ! ? ??$" Center=?6D   ?? 5J      ! ? ??$" Center=?6B   5K      5M        5O      $ 
Cena (€)??6%   $ 70 6P    67   ?? *Cena+ 5P      ?? 5Q      "   6    .?5R      ?? ! ? ??$" Center=?6D   ?? 5S      ! ? ??$" Center=?6B   5T      # 5V      ?? 5W      "  ??6    .?5X      ?? ! ? ??$" Center=?6D   ?? 5Y      ! ? ??$" Center=?6B   5Z      5\        5^      $ Datum polaska??6%   $	 150 6]    6<   ?? *DatumPolaska+ 5_      ?? 5`      "   6    .?5a      ?? ! ? ??$" Center=?6D   ?? 5b      ! ? ??$" Center=?6B   5c      # 5e      ?? 5f      "  ??6    .?5g      ?? ! ? ??$" Center=?6D   ?? 5h      ! ? ??$" Center=?6B   5i      5k        5m      $ * 6)    .   5n      ?? 5o      .R?5p      ?? $ ?? Orientation$$ Vertical=?6)   $??Center=?6@   $??Center=?6]   .+?5q   "   ?? $??buttonProcitaj??6)   -   5        $??Procitaj??5q   ?   $??80??6R   $??28??6]   
???????
???   ?6?   ?? 5r   "   $??buttonIzmeni??6)   -   5        $??Izmeni??5r   =   $??80??6N   $??28??6Y   
???????
???   ?6?   ?? 5s   "   $??buttonObrisi??6)   -   5        $??Obrisi??5s   =   $??80??6N   $??28??6Y   
???????
???   ?6?   5t      5u      5w      5z      ?? 5|   
   -   5        % ??Name$% labelNaslov??5|      $??Tropske Destinacije??6&   
???????
???   ?$
??Left=?6o   $	??Top=?6?   $	??230??6?   $??Center=?6?   $??Center=?6?   $??	Agency FB)?6?   $??35(?6  $	 256??6  $ 20??6+  ?? 5~   
   -   5        & ??Name$& 	buttonAdd??5~      $??Dodaj destinaciju??6$   $	 100??6@   $	 390??6R   $??50??6c   $	??150??6o   ??5      ?? 5?      "  ??6   ' ?? Triggers' 5?      P? 5?      ( P? Property( ?@J?IsMouseOver) P? Value) . . ?5?      ?? ! ?@J?Effect#" [  67   5?      5?      5?      ?? 5?   
   -	   5        $& buttonClose??5?      $??Izadji??6&   $	 501??67   $	 390??6I   $??50??6Z   $	??150??6f   ??5?      ?? 5?      "  ??6   ' 5?      P? 5?      ( ?@J?IsMouseOver) . . ?5?      ?? ! ?@J?Effect#" [ 67   5?      5?      5?      5?      5?      