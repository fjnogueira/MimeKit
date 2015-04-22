//
// HtmlTagId.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2013-2015 Xamarin Inc. (www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Collections.Generic;

namespace MimeKit.Text {
	public enum HtmlTagId {
		Unknown,
		A,
		Abbr,
		Acronym,
		Address,
		Applet,
		Area,
		B,
		Base,
		BaseFont,
		Bdo,
		BGSound,
		Big,
		Blink,
		BlockQuote,
		Body,
		Br,
		Button,
		Caption,
		Center,
		Cite,
		Code,
		Col,
		ColGroup,
		Comment,
		DD,
		Del,
		Dfn,
		Dir,
		Div,
		DL,
		DT,
		EM,
		Embed,
		FieldSet,
		Font,
		Form,
		Frame,
		FrameSet,
		H1,
		H2,
		H3,
		H4,
		H5,
		H6,
		Head,
		HR,
		Html,
		I,
		Iframe,
		Image,
		Input,
		Ins,
		IsIndex,
		Kbd,
		Label,
		Legend,
		LI,
		Link,
		Listing,
		Map,
		Marquee,
		Menu,
		Meta,
		NextId,
		NoBR,
		NoEmbed,
		NoFrames,
		NoScript,
		Object,
		OL,
		OptGroup,
		Option,
		P,
		Param,
		PlainText,
		Pre,
		Q,
		RP,
		RT,
		Ruby,
		S,
		Samp,
		Script,
		Select,
		Small,
		Span,
		Strike,
		Strong,
		Style,
		Sub,
		Sup,
		Table,
		Ybody,
		TD,
		TextArea,
		Tfoot,
		TH,
		Thread,
		Title,
		TR,
		TT,
		U,
		UL,
		Var,
		Wbr,
		Xml,
		Xmp,
	}

	/// <summary>
	/// <see cref="HtmlTagId"/> extension methods.
	/// </summary>
	/// <remarks>
	/// <see cref="HtmlTagId"/> extension methods.
	/// </remarks>
	static class HtmlTagIdExtensions
	{
		static readonly Dictionary<string, HtmlTagId> dict;

		static HtmlTagIdExtensions ()
		{
			var values = (HtmlTagId[]) Enum.GetValues (typeof (HtmlTagId));

			dict = new Dictionary<string, HtmlTagId> (values.Length - 1, StringComparer.OrdinalIgnoreCase);

			for (int i = 0; i < values.Length - 1; i++)
				dict.Add (values[i].ToHtmlTagName (), values[i]);
		}

		/// <summary>
		/// Converts the enum value into the equivalent tag name.
		/// </summary>
		/// <remarks>
		/// Converts the enum value into the equivalent tag name.
		/// </remarks>
		/// <returns>The tag name.</returns>
		/// <param name="value">The enum value.</param>
		public static string ToHtmlTagName (this HtmlTagId value)
		{
			return value.ToString ().ToLowerInvariant ();
		}

		/// <summary>
		/// Converts the tag name into the equivalent tag id.
		/// </summary>
		/// <remarks>
		/// Converts the tag name into the equivalent tag id.
		/// </remarks>
		/// <returns>The tag id.</returns>
		/// <param name="name">The tag name.</param>
		public static HtmlTagId ToHtmlTagId (this string name)
		{
			HtmlTagId value;

			if (!dict.TryGetValue (name, out value))
				return HtmlTagId.Unknown;

			return value;
		}
	}
}
