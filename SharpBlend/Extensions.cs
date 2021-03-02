using System.Drawing;

namespace SharpBlend
{
	internal struct Functions
	{
		public static Color BlendWith(Color originalColor, Color otherColor, double amount)
		{
			byte r = (byte)((originalColor.R * amount) + otherColor.R * (1 - amount));
			byte g = (byte)((originalColor.G * amount) + otherColor.G * (1 - amount));
			byte b = (byte)((originalColor.B * amount) + otherColor.B * (1 - amount));
			return Color.FromArgb(r, g, b);
		}
		public static Color BlendWith(Color originalColor, Color otherColor, byte opacity, double amount)
		{
			byte r = (byte)((originalColor.R * amount) + otherColor.R * (1 - amount));
			byte g = (byte)((originalColor.G * amount) + otherColor.G * (1 - amount));
			byte b = (byte)((originalColor.B * amount) + otherColor.B * (1 - amount));
			return Color.FromArgb(r, g, b, opacity);
		}
	}
}
