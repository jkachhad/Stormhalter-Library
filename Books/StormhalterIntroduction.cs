using System.Collections.Generic;
using System.Drawing;
using Kesmai.Server.Engines.Gumps;
using Kesmai.Server.Engines.Library;
using Image = Kesmai.Server.Engines.Gumps.Image;

namespace Kesmai.Publications;

public class StormhalterIntroduction() : PublishedBook(
	/* every book must have a unique id to persistence clashing. */
	uniqueId: "stormhalter-introduction",
	
	title: "Stormhalter",
	author: "Luxx",
	
	/* a composite page allows ui elements to be laid out in any manner. */
	new CompositePage(() =>
	{
	    var list = new List<GumpControl>()
	    {
		    /* show a centered image. */
		    new Image()
		    {
			    Texture = @"UI/Textures/Books/Image-Round-Dragon",
			    Width = 450, Height = 450,
			    HorizontalAlignment = HorizontalAlignment.Center,
		    },
		    
		    /* display the tile and author under. */
		    new TextBlock()
		    {
			    Text = "Stormhalter",
			    HorizontalAlignment = HorizontalAlignment.Center,
				
			    FontSize = 72, Font = "King",
			    
			    Margin = new Rectangle(0, 30, 0, 0)
			},
		    new TextBlock()
		    {
			    Text = "Written by Luxx",
			    HorizontalAlignment = HorizontalAlignment.Center,
				
			    FontSize = 32, Font = "RobotoBold",
			    Stroke = Color.White, 
			    
			    Margin = new Rectangle(0, 20, 0, 0)
		    },
	    };

	    return list;
	}),
	
	/* a new page with more structured elements. */
	new Page(
		/* paragraphs are laid out and wrapped. */
		new ParagraphPageElement("Stormhalter isn't just a game project; it's a passion project by a group of people. It began as a remake of Legends of Kesmai, with the goal of building a welcoming community. "),
		new ParagraphPageElement("The aim is to welcome new players, especially those who have never experienced Island of Kesmai, Legends of Kesmai, or Lands of Kes.")
	));