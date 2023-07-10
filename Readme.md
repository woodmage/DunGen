DUNgeon GENerator  v.1.0.0

by John Worthington (woodmage@gmail.com)

This is a fairly simple program, really.  When you start it up, you see several NumericUpDown controls.  They are for the parameters of the dungeon map you will generate.  # rooms is pretty obvious; it is the number of rooms that will be in the map.  Minimum and maximum width, minimum and maximum height are also quite obvious.  Bits per unit is how many pixels each "map square" will use.  And % random is the percentage chance (per room) of a random connection to another room.  This can be anywhere from 0 (no random paths whatsoever) to 100 (one random path per room).  Anyway, when you are satisfied with the options, you may press the Generate button.

When you press Generate, first the program will calculate an actual map size.  It does this by multiplying maximum width by count and maximum height by count.  Note that this gives us our maximum units, and is further affected by bits per pixel.  At any rate, once it calculates that, it will generate rooms first, then passages including doors and display all of this in the picturebox to the right.  That picturebox will be resized and scrollbars will be provided if needed.

The algorithm for passages is a simple one, basically moving toward the target room either horizontally or vertically, with a slight chance of "going the wrong way" every now and then.  This provides a somewhat meandering path to be generated.  Anyway, I hope you like this program!

Planned features include being able to save your map in an image format as well as a simple text listing, perhaps also an ascii map.  If you have any suggestions or (GASP!) bug reports, please send them to me at woodmage@gmail.com with DUNGEN in the title!  Thanks!

