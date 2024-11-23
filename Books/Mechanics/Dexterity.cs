using Kesmai.Server;
using Kesmai.Server.Engines.Library;

namespace Kesmai.Publications;

public class BrawlingWithScience() : PublishedScroll(
	id : 10002,
	
	new Page(
		new CompositePageElement(new BodyPageElement(32), new TerrainPageElement(114), new BodyPageElement(49)),
		new ParagraphPageElement("It began when one of them, Varek, a wiry fighter, found something glinting in the sand—— a platinum ring, etched with faintly shimmering runes. He shared a look with his opponent, Tak, a martial-artist with heavy fists. Neither knew what the ring did, but they decided to test it out."),
		new ParagraphPageElement("They each took turns slipping the ring onto their fingers, finally agreeing that Varek would wear it for the match. It didnt take long to reveal its magic."),
		new CompositePageElement(new ItemPageElement(19)),
		new ParagraphPageElement("As Varek wore the ring, his movements grew more precise. He dodged Tak's attacks with ease, and Tak, despite his usual strength, struggled to even graze him. The ring must have been enchanted to enhance combat. It didn't make Varek invincible; Tak landed a few hits, but they were fewer and farther between."),
		new ParagraphPageElement("Varek seemed to notice, too, his confidence building as he found openings he hadn't seen before. Tak was visibly frustrated, fighting a shadow that danced just out of reach."),
		new ParagraphPageElement("At the end of the match, Varek slipped the ring off, handing it to Tak, and the two exchanged respectful nods, bound by the thrill of head kicks for science.")
	));