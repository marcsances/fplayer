urMusik
=======

MSS fPlayer's official GitHub repository

You need to either add libAP project or binary to your solution for fPlayer to work.

You need NuGet and Microsoft.WindowsApiCodePack-Core, Microsoft.WindowsApiCodePack-Shell packages installed in this solution for it to work. Shouldn't you be able to use NuGet, get a copy of Windows API Code Pack and imitate this tree:
packages/Microsoft.WindowsAPICodePack-Core.1.1.0.2/lib/Microsoft.WindowsAPICodePack.dll
packages/Microsoft.WindowsAPICodePack-Shell.1.1.0.0/lib/Microsoft.WindowsAPICodePack.Shell.dll
packages/Microsoft.WindowsAPICodePack-Shell.1.1.0.0/lib/Microsoft.WindowsAPICodePack.ShellExtensions.dll

Remember urMusik is under the GNU GPL v3, libAP is under the GNU LGPL v3 and Windows API Code Pack is from Microsoft Corporation and under the Microsoft Public License.