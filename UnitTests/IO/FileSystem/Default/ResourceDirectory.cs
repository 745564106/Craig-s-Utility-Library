﻿/*
Copyright (c) 2014 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

using System.Linq;
using UnitTests.Fixtures;
using Utilities.IO.FileSystem.Interfaces;
using Xunit;

namespace UnitTests.IO.FileSystem.Default
{
    public class ResourceDirectory : TestingDirectoryFixture
    {
        [Fact]
        public void Clone()
        {
            Utilities.IO.FileSystem.Default.ResourceDirectory Temp = new Utilities.IO.FileSystem.Default.ResourceDirectory("resource://UnitTests/");
            Utilities.IO.FileSystem.Default.ResourceDirectory Temp2 = (Utilities.IO.FileSystem.Default.ResourceDirectory)Temp.Clone();
            Assert.True(Temp == Temp2);
            Assert.True(Temp.Equals(Temp2));
            Assert.Equal(0, Temp.CompareTo(Temp2));
            Assert.False(Temp < Temp2);
            Assert.False(Temp > Temp2);
            Assert.True(Temp <= Temp2);
            Assert.True(Temp >= Temp2);
            Assert.False(Temp != Temp2);
        }

        [Fact]
        public void Creation()
        {
            Utilities.IO.FileSystem.Default.ResourceDirectory Temp = new Utilities.IO.FileSystem.Default.ResourceDirectory("resource://UnitTests/");
            Assert.NotNull(Temp);
            Assert.True(Temp.Exists);
            Assert.Equal("resource://UnitTests/", Temp.FullName);
            Assert.Equal("resource://UnitTests/", Temp.Name);
            Assert.Null(Temp.Parent);
        }

        [Fact]
        public void Enumeration()
        {
            Utilities.IO.FileSystem.Default.ResourceDirectory Temp = new Utilities.IO.FileSystem.Default.ResourceDirectory("resource://UnitTests/");
            foreach (IFile File in Temp) { }
            Assert.Equal(1, Temp.EnumerateFiles().Count());
        }

        [Fact]
        public void Equality()
        {
            Utilities.IO.FileSystem.Default.ResourceDirectory Temp = new Utilities.IO.FileSystem.Default.ResourceDirectory("resource://UnitTests/");
            Utilities.IO.FileSystem.Default.ResourceDirectory Temp2 = new Utilities.IO.FileSystem.Default.ResourceDirectory("resource://UnitTests/");
            Assert.True(Temp == Temp2);
            Assert.True(Temp.Equals(Temp2));
            Assert.Equal(0, Temp.CompareTo(Temp2));
            Assert.False(Temp < Temp2);
            Assert.False(Temp > Temp2);
            Assert.True(Temp <= Temp2);
            Assert.True(Temp >= Temp2);
            Assert.False(Temp != Temp2);
        }
    }
}