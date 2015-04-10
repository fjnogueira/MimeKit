//
// HtmlWriter.cs
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
using System.IO;

#if PORTABLE
using Encoding = Portable.Text.Encoding;
#else
using Encoding = System.Text.Encoding;
#endif

namespace MimeKit.Text {
	public class HtmlWriter : IDisposable
	{
		TextWriter writer;

		public HtmlWriter (Stream stream, Encoding encoding)
		{
			writer = new StreamWriter (stream, encoding, 4096);
		}

		public HtmlWriter (TextWriter output)
		{
			writer = output;
		}

		~HtmlWriter ()
		{
			Dispose (false);
		}

		void CheckDisposed ()
		{
			if (writer == null)
				throw new ObjectDisposedException ("HtmlWriter");
		}

		public HtmlWriterState WriterState {
			get; private set;
		}

		public void WriteAttribute (HtmlAttributeId id, char[] buffer, int index, int count)
		{
		}

		public void WriteAttribute (string name, char[] buffer, int index, int count)
		{
		}

		public void WriteAttribute (HtmlAttributeReader attributeReader)
		{
		}

		public void WriteAttribute (HtmlAttributeId id, string value)
		{
		}

		public void WriteAttribute (string name, string value)
		{
			// FIXME: implemement this
		}



		public void Flush ()
		{
			CheckDisposed ();

			writer.Flush ();
		}

		public void Close ()
		{
			CheckDisposed ();

			writer = null;
		}

		/// <summary>
		/// Releases the unmanaged resources used by the <see cref="HtmlWriter"/> and
		/// optionally releases the managed resources.
		/// </summary>
		/// <remarks>
		/// Releases any unmanaged resources used by the <see cref="HtmlWriter"/> and
		/// optionally releases the managed resources.
		/// </remarks>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
		/// <c>false</c> to release only the unmanaged resources.</param>
		protected virtual void Dispose (bool disposing)
		{
			if (disposing)
				Close ();
		}

		/// <summary>
		/// Releases all resource used by the <see cref="MimeKit.Text.HtmlWriter"/> object.
		/// </summary>
		/// <remarks>Call <see cref="Dispose"/> when you are finished using the <see cref="MimeKit.Text.HtmlWriter"/>. The
		/// <see cref="Dispose"/> method leaves the <see cref="MimeKit.Text.HtmlWriter"/> in an unusable state. After calling
		/// <see cref="Dispose"/>, you must release all references to the <see cref="MimeKit.Text.HtmlWriter"/> so the garbage
		/// collector can reclaim the memory that the <see cref="MimeKit.Text.HtmlWriter"/> was occupying.</remarks>
		public void Dispose ()
		{
			Dispose (true);

			GC.SuppressFinalize (this);
		}
	}
}
