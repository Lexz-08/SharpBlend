## SharpBlend
### Description
Can blend either 2 colors or more than 2 together with a certain amount of each first one left over.

### How To Use
```csharp
// Assuming you have the System.Drawing namespace referenced.
// Change the colors passed into the function's parameters to whatever colors you'd like, unless you want those.
Color BlendedColor = Blender.BlendColors(Color.Orange, Color.Magenta, 0.5);

// For Console Application users...
IntPtr DesktopHandle = IntPtr.Zero;
using (Graphics GFX = Graphics.FromHwnd(DesktopHandle)
{
    GFX.FillRectangle(new SolidBrush(BlendedColor), new Rectangle(10, 10, 10, 10));
}

// For Windows Forms Application users...
// The BackColor represents the BackColor property of the Form window.
BackColor = BlendedColor;
```

### Download
[SharpBlend.dll](https://github.com/Lexz-08/SharpBlend/releases/download/sharpblend/SharpBlend.dll)
