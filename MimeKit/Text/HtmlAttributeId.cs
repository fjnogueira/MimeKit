//
// HtmlAttributeId.cs
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
	public enum HtmlAttributeId {
		Unknown,
		Abbr,
		Accept,
		AcceptCharset,
		AccessKey,
		Action,
		Align,
		Alink,
		Alt,
		Archive,
		Axis,
		Background,
		BGColor,
		Border,
		CellPadding,
		CellSpacing,
		Char,
		CharOff,
		Charset,
		Checked,
		Cite,
		Class,
		ClassId,
		Clear,
		Code,
		CodeBase,
		CodeType,
		Color,
		Cols,
		ColSpan,
		Compact,
		Content,
		Coords,
		Data,
		DateTime,
		Declare,
		Defer,
		Dir,
		Disabled,
		DynSrc,
		EncType,
		Face,
		For,
		Frame,
		FrameBorder,
		Headers,
		Height,
		Href,
		HrefLang,
		Hspace,
		HttpEquiv,
		Id,
		IsMap,
		Label,
		Lang,
		Language,
		LeftMargin,
		Link,
		LongDesc,
		LowSrc,
		MarginHeight,
		MarginWidth,
		MaxLength,
		Media,
		Method,
		Multiple,
		Name,
		NoHref,
		NoResize,
		NoShade,
		NoWrap,
		Object,
		Profile,
		Prompt,
		ReadOnly,
		Rel,
		Rev,
		Rows,
		RowSpan,
		Rules,
		Scheme,
		Scope,
		Scrolling,
		Selected,
		Shape,
		Size,
		Span,
		Src,
		StandBy,
		Start,
		Style,
		Summary,
		TabIndex,
		Target,
		Text,
		Title,
		TopMargin,
		Type,
		UseMap,
		Valign,
		Value,
		ValueType,
		Version,
		Vlink,
		Vspace,
		Width,
	}

	/// <summary>
	/// <see cref="HtmlAttributeId"/> extension methods.
	/// </summary>
	/// <remarks>
	/// <see cref="HtmlAttributeId"/> extension methods.
	/// </remarks>
	static class HtmlAttributeIdExtensions
	{
		static readonly Dictionary<string, HtmlAttributeId> dict;

		static HtmlAttributeIdExtensions ()
		{
			var values = (HtmlAttributeId[]) Enum.GetValues (typeof (HtmlAttributeId));

			dict = new Dictionary<string, HtmlAttributeId> (values.Length - 1, StringComparer.OrdinalIgnoreCase);

			for (int i = 0; i < values.Length - 1; i++)
				dict.Add (values[i].ToAttributeName (), values[i]);
		}

		/// <summary>
		/// Converts the enum value into the equivalent attribute name.
		/// </summary>
		/// <remarks>
		/// Converts the enum value into the equivalent attribute name.
		/// </remarks>
		/// <returns>The attribute name.</returns>
		/// <param name="value">The enum value.</param>
		public static string ToAttributeName (this HtmlAttributeId value)
		{
			return value.ToString ().ToLowerInvariant ();
		}

		/// <summary>
		/// Converts the attribute name into the equivalent attribute id.
		/// </summary>
		/// <remarks>
		/// Converts the attribute name into the equivalent attribute id.
		/// </remarks>
		/// <returns>The attribute id.</returns>
		/// <param name="name">The attribute name.</param>
		public static HtmlAttributeId ToHtmlAttributeId (this string name)
		{
			HtmlAttributeId value;

			if (!dict.TryGetValue (name, out value))
				return HtmlAttributeId.Unknown;

			return value;
		}
	}
}
