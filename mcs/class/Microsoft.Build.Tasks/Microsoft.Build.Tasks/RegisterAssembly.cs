//
// RegisterAssembly.cs: Register an assembly into GAC.
//
// Author:
//   Marek Sieradzki (marek.sieradzki@gmail.com)
//
// (C) 2005 Marek Sieradzki
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#if NET_2_0

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Build.Framework;

namespace Microsoft.Build.Tasks {
	public class RegisterAssembly : AppDomainIsolatedTaskExtension, ITypeLibExporterNotifySink {
	
		ITaskItem[]	assemblies;
		bool		createCodeBase;
		ITaskItem 	stateFile;
		ITaskItem[]	typeLibFiles;
	
		public RegisterAssembly ()
		{
		}

		public override bool Execute ()
		{
			return true;
		}

		public void ReportEvent (ExporterEventKind kind, int code,
					 string msg)
		{
			throw new NotImplementedException ();
		}

		public object ResolveRef (Assembly assemblyToResolve)
		{
			throw new NotImplementedException ();
		}

		[Required]
		public ITaskItem[] Assemblies {
			get {
				return assemblies;
			}
			set {
				assemblies = value;
			}
		}

		public bool CreateCodeBase  {
			get {
				return createCodeBase;
			}
			set {
				createCodeBase = value;
			}
		}

		public ITaskItem StateFile {
			get {
				return stateFile;
			}
			set {
				stateFile = value;
			}
		}

		public ITaskItem[] TypeLibFiles {
			get {
				return typeLibFiles;
			}
			set {
				typeLibFiles = value;
			}
		}
	}
}

#endif