﻿using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;

namespace SixLaborsCaptcha.Core
{
	public class SixLaborsCaptchaOptions
	{
		/// <summary>
		/// Default fonts are  "Arial", "Verdana", "Times New Roman"
		/// </summary>
		public string[] FontFamilies { get; set; } = new string[] { "Arial", "Verdana", "Times New Roman" };
		public Color[] TextColor { get; set; } = new Color[] { Color.Blue, Color.Black, Color.Black, Color.Brown, Color.Gray, Color.Green };
		public Color[] DrawLinesColor { get; set; } = new Color[] { Color.Blue, Color.Black, Color.Black, Color.Brown, Color.Gray, Color.Green };
		public ushort Width { get; set; } = 180;
		public ushort Height { get; set; } = 50;
		public byte FontSize { get; set; } = 29;
		public FontStyle FontStyle { get; set; } = FontStyle.Regular;
		public EncoderTypes EncoderType { get; set; } = EncoderTypes.Png;
		public IImageEncoder Encoder => Core.Extentions.GetEncoder(EncoderType);
		public byte DrawLines { get; set; } = 5;

		public byte MaxRotationDegrees { get; set; } = 5;
	}

}
