using System.Drawing;

namespace SharpBlend
{
	public struct BlendedColor
	{
		private byte red, green, blue, alpha;
		private Color resultColor;

		public byte Red => red;
		public byte Green => green;
		public byte Blue => blue;
		public byte Alpha => alpha;
		public Color ResultColor => resultColor;

		public BlendedColor(Color color1, Color color2, double amount)
		{
			resultColor = Functions.BlendWith(color1, color2, amount);
			red = resultColor.R;
			green = resultColor.G;
			blue = resultColor.B;
			alpha = resultColor.A;
		}
		public BlendedColor(Color color1, Color color2, byte opacity, double amount)
		{
			resultColor = Functions.BlendWith(color1, color2, opacity, amount);
			red = resultColor.R;
			green = resultColor.G;
			blue = resultColor.B;
			alpha = resultColor.A;
		}
		public BlendedColor(double amount, params Color[] colors)
		{
			resultColor = Color.Empty;
			red = 0;
			green = 0;
			blue = 0;
			alpha = 0;

			for (int i = 0; i < colors.Length - 2; i++)
			{
				for (int ii = 1; i < colors.Length - 1; ii++)
				{
					Color clr1 = colors[i];
					Color clr2 = colors[ii];
					resultColor = Functions.BlendWith(clr1, clr2, amount);
					red = resultColor.R;
					green = resultColor.G;
					blue = resultColor.B;
					alpha = resultColor.A;
				}
			}
		}
		public BlendedColor(byte opacity, double amount, params Color[] colors)
		{
			resultColor = Color.Empty;
			red = 0;
			green = 0;
			blue = 0;
			alpha = 0;

			for (int i = 0; i < colors.Length - 2; i++)
			{
				for (int ii = 1; ii < colors.Length - 1; ii++)
				{
					Color clr1 = colors[i];
					Color clr2 = colors[ii];
					resultColor = Functions.BlendWith(clr1, clr2, opacity, amount);
					red = resultColor.R;
					green = resultColor.G;
					blue = resultColor.B;
					alpha = resultColor.A;
				}
			}
		}

		public void BlendNew(Color color1, Color color2, double amount)
		{
			resultColor = Functions.BlendWith(color1, color2, amount);
			red = resultColor.R;
			green = resultColor.G;
			blue = resultColor.B;
			alpha = resultColor.A;
		}
		public void BlendNew(Color color1, Color color2, byte opacity, double amount)
		{
			resultColor = Functions.BlendWith(color1, color2, opacity, amount);
			red = resultColor.R;
			green = resultColor.G;
			blue = resultColor.B;
			alpha = resultColor.A;
		}
		public void BlendNew(double amount, params Color[] colors)
		{
			for (int i = 0; i < colors.Length - 2; i++)
			{
				for (int ii = 0; ii < colors.Length - 1; ii++)
				{
					Color clr1 = colors[i];
					Color clr2 = colors[ii];
					resultColor = Functions.BlendWith(clr1, clr2, amount);
					red = resultColor.R;
					green = resultColor.G;
					blue = resultColor.B;
					alpha = resultColor.A;
				}
			}
		}
		public void BlendNew(byte opacity, double amount, params Color[] colors)
		{
			for (int i = 0; i < colors.Length - 2; i++)
			{
				for (int ii = 0; ii < colors.Length - 1; ii++)
				{
					Color clr1 = colors[i];
					Color clr2 = colors[ii];
					resultColor = Functions.BlendWith(clr1, clr2, opacity, amount);
					red = resultColor.R;
					green = resultColor.G;
					blue = resultColor.B;
					alpha = resultColor.A;
				}
			}
		}

		public static BlendedColor Blend(Color color1, Color color2, double amount)
		{
			BlendedColor blendedColor = new BlendedColor(color1, color2, amount);
			return blendedColor;
		}
		public static BlendedColor Blend(Color color1, Color color2, byte opacity, double amount)
		{
			BlendedColor blendedColor = new BlendedColor(color1, color2, opacity, amount);
			return blendedColor;
		}
		public static BlendedColor Blend(double amount, params Color[] colors)
		{
			BlendedColor blendedColor = new BlendedColor(amount, colors);
			return blendedColor;
		}
		public static BlendedColor Blend(byte opacity, double amount, params Color[] colors)
		{
			BlendedColor blendedColor = new BlendedColor(opacity, amount, colors);
			return blendedColor;
		}

		public void ChangeRed(byte newRed) => ChangeColor(newRed, green, blue, alpha);
		public void ChangeGreen(byte newGreen) => ChangeColor(red, newGreen, blue, alpha);
		public void ChangeBlue(byte newBlue) => ChangeColor(red, green, newBlue, alpha);
		public void ChangeAlpha(byte newAlpha) => ChangeColor(red, green, blue, newAlpha);
		public void ChangeColor(byte newRed, byte newGreen, byte newBlue, byte newAlpha)
		{
			resultColor = Color.FromArgb(newRed, newGreen, newBlue, newAlpha);
		}

		public Color ToColor()
		{
			return resultColor;
		}

		public static implicit operator BlendedColor(Color value)
		{
			BlendedColor blendedColor = new BlendedColor();
			blendedColor.ChangeColor(value.R, value.G, value.B, value.A);
			return blendedColor;
		}
		public static explicit operator Color(BlendedColor value)
		{
			return Color.FromArgb(value.Red, value.Green, value.Blue, value.Alpha);
		}
	}

	public static class Blender
    {
		public static BlendedColor Blend(Color color1, Color color2, double amount)
		{
			return new BlendedColor(color1, color2, amount);
		}
		public static BlendedColor Blend(Color color1, Color color2, byte opacity, double amount)
		{
			return new BlendedColor(color1, color2, opacity, amount);
		}
		public static BlendedColor Blend(double amount, params Color[] colors)
		{
			return new BlendedColor(amount, colors);
		}
		public static BlendedColor Blend(byte opacity, double amount, params Color[] colors)
		{
			return new BlendedColor(opacity, amount, colors);
		}

		public static Color BlendColors(Color color1, Color color2, double amount)
		{
			return (Color)new BlendedColor(color1, color2, amount);
		}
		public static Color BlendColors(Color color1, Color color2, byte opacity, double amount)
		{
			return (Color)new BlendedColor(color1, color2, amount);
		}
		public static Color BlendColors(double amount, params Color[] colors)
		{
			return (Color)new BlendedColor(amount, colors);
		}
		public static Color BlendColors(byte opacity, double amount, params Color[] colors)
		{
			return (Color)new BlendedColor(opacity, amount, colors);
		}

		public static BlendedColor ToBlend(this Color color)
		{
			return color;
		}
		public static Color ToColor(this BlendedColor blendedColor)
		{
			return blendedColor.ToColor();
		}
	}
}
