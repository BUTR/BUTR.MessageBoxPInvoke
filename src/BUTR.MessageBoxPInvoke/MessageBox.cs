﻿// <auto-generated>
//   This code file has automatically been added by the "BUTR.MessageBoxPInvoke" NuGet package (https://www.nuget.org/packages/BUTR.MessageBoxPInvoke).
//   Please see https://github.com/BUTR/BUTR.MessageBoxPInvoke for more information.
//
//   IMPORTANT:
//   DO NOT DELETE THIS FILE if you are using a "packages.config" file to manage your NuGet references.
//   Consider migrating to PackageReferences instead:
//   https://docs.microsoft.com/en-us/nuget/consume-packages/migrate-packages-config-to-package-reference
//   Migrating brings the following benefits:
//   * The "BUTR.MessageBoxPInvoke/Helpers" folder and the "MessageBox.cs" file don't appear in your project.
//   * The added file is immutable and can therefore not be modified by coincidence.
//   * Updating/Uninstalling the package will work flawlessly.
// </auto-generated>

#region License
// MIT License
//
// Copyright (c) Bannerlord's Unofficial Tools & Resources
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

#if !BUTRMESSAGEBOXPINVOKE_DISABLE
#nullable enable
#if !BUTRMESSAGEBOXPINVOKE_ENABLE_WARNINGS
#pragma warning disable
#endif

namespace BUTR.MessageBoxPInvoke.Helpers
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Runtime.InteropServices;
    
    [Flags]
    internal enum MESSAGEBOX_STYLE : uint
    {
        MB_ABORTRETRYIGNORE = 0x00000002,
        MB_CANCELTRYCONTINUE = 0x00000006,
        MB_HELP = 0x00004000,
        MB_OK = 0x00000000,
        MB_OKCANCEL = 0x00000001,
        MB_RETRYCANCEL = 0x00000005,
        MB_YESNO = 0x00000004,
        MB_YESNOCANCEL = 0x00000003,
        MB_ICONHAND = 0x00000010,
        MB_ICONQUESTION = 0x00000020,
        MB_ICONEXCLAMATION = 0x00000030,
        MB_ICONASTERISK = 0x00000040,
        MB_USERICON = 0x00000080,
        MB_ICONWARNING = 0x00000030,
        MB_ICONERROR = 0x00000010,
        MB_ICONINFORMATION = 0x00000040,
        MB_ICONSTOP = 0x00000010,
        MB_DEFBUTTON1 = 0x00000000,
        MB_DEFBUTTON2 = 0x00000100,
        MB_DEFBUTTON3 = 0x00000200,
        MB_DEFBUTTON4 = 0x00000300,
        MB_APPLMODAL = 0x00000000,
        MB_SYSTEMMODAL = 0x00001000,
        MB_TASKMODAL = 0x00002000,
        MB_NOFOCUS = 0x00008000,
        MB_SETFOREGROUND = 0x00010000,
        MB_DEFAULT_DESKTOP_ONLY = 0x00020000,
        MB_TOPMOST = 0x00040000,
        MB_RIGHT = 0x00080000,
        MB_RTLREADING = 0x00100000,
        MB_SERVICE_NOTIFICATION = 0x00200000,
        MB_SERVICE_NOTIFICATION_NT3X = 0x00040000,
        MB_TYPEMASK = 0x0000000F,
        MB_ICONMASK = 0x000000F0,
        MB_DEFMASK = 0x00000F00,
        MB_MODEMASK = 0x00003000,
        MB_MISCMASK = 0x0000C000,
    }

    internal enum MESSAGEBOX_RESULT
    {
        IDOK = 1,
        IDCANCEL = 2,
        IDABORT = 3,
        IDRETRY = 4,
        IDIGNORE = 5,
        IDYES = 6,
        IDNO = 7,
        IDCLOSE = 8,
        IDHELP = 9,
        IDTRYAGAIN = 10,
        IDCONTINUE = 11,
        IDASYNC = 32001,
        IDTIMEOUT = 32000,
    }
    
    internal enum MessageBoxButtons
    {
        /// <summary>
        /// The message box contains three push buttons: Abort, Retry, and Ignore.
        /// </summary>
        AbortRetryIgnore = 0x00000002,

        /// <summary>
        /// The message box contains three push buttons: Cancel, Try Again, Continue.
        /// </summary>
        CancelTryIgnore = 0x00000006,

        /// <summary>
        /// Adds a Help button to the message box.
        /// </summary>
        Help = 0x00004000,

        /// <summary>
        /// The message box contains one push button: OK. This is the default.
        /// </summary>
        Ok = 0x00000000,

        /// <summary>
        /// The message box contains two push buttons: OK and Cancel.
        /// </summary>
        OkCancel = 0x00000001,

        /// <summary>
        /// The message box contains two push buttons: Retry and Cancel.
        /// </summary>
        RetryCancel = 0x00000005,

        /// <summary>
        /// The message box contains two push buttons: Yes and No.
        /// </summary>
        YesNo = 0x00000004,

        /// <summary>
        /// The message box contains three push buttons: Yes, No, and Cancel.
        /// </summary>
        YesNoCancel = 0x00000003
    }

    /// <summary>
    /// The message box returns an integer value that indicates which button the user clicked.
    /// </summary>
    internal enum MessageBoxResult
    {
        /// <summary>
        /// The 'Abort' button was selected.
        /// </summary>
        Abort = 3,

        /// <summary>
        /// The 'Cancel' button was selected.
        /// </summary>
        Cancel = 2,

        /// <summary>
        /// The 'Continue' button was selected.
        /// </summary>
        Continue = 11,

        /// <summary>
        /// The 'Ignore' button was selected.
        /// </summary>
        Ignore = 5,

        /// <summary>
        /// The 'No' button was selected.
        /// </summary>
        No = 7,

        /// <summary>
        /// The 'OK' button was selected.
        /// </summary>
        Ok = 1,

        /// <summary>
        /// The 'Retry' button was selected.
        /// </summary>
        Retry = 10,

        /// <summary>
        /// The 'Yes' button was selected.
        /// </summary>
        Yes = 6
    }

    /// <summary>
    /// To indicate the default button, specify one of the following values.
    /// </summary>
    internal enum MessageBoxDefaultButton : uint
    {
        /// <summary>
        /// The first button is the default button.
        /// </summary>
        Button1 = 0x00000000,

        /// <summary>
        /// The second button is the default button.
        /// </summary>
        Button2 = 0x00000100,

        /// <summary>
        /// The third button is the default button.
        /// </summary>
        Button3 = 0x00000200,

        /// <summary>
        /// The fourth button is the default button.
        /// </summary>
        Button4 = 0x00000300,
    }

    /// <summary>
    /// To indicate the modality of the dialog box, specify one of the following values.
    /// </summary>
    internal enum MessageBoxModal : uint
    {
        /// <summary>
        /// The user must respond to the message box before continuing work in the window identified by the hWnd parameter. However, the user can move to the windows of other threads and work in those windows. Depending on the hierarchy of windows in the application, the user may be able to move to other windows within the thread. All child windows of the parent of the message box are automatically disabled, but pop-up windows are not.
        /// </summary>
        Application = 0x00000000,

        /// <summary>
        /// Same as <see cref="Application"/> except that the message box has the Top Most style. Use system-modal message boxes to notify the user of serious, potentially damaging errors that require immediate attention (for example, running out of memory).
        /// </summary>
        System = 0x00001000,

        /// <summary>
        /// Same as <see cref="Application"/> except that all the top-level windows belonging to the current thread are disabled if the hWnd parameter is NULL. Use this flag when the calling application or library does not have a window handle available but still needs to prevent input to other windows in the calling thread without suspending other threads.
        /// </summary>
        Task = 0x00002000
    }

    /// <summary>
    /// To display an icon in the message box, specify one of the following values.
    /// </summary>
    internal enum MessageBoxIcon : uint
    {
        /// <summary>
        /// An exclamation-point icon appears in the message box.
        /// </summary>
        Warning = 0x00000030,

        /// <summary>
        /// An icon consisting of a lowercase letter `i` in a circle appears in the message box.
        /// </summary>
        Information = 0x00000040,

        /// <summary>
        /// A question-mark icon appears in the message box.
        /// </summary>
        /// <remarks>
        /// The question-mark message icon is no longer recommended because it does not clearly represent a specific type of message and because the phrasing of a message as a question could apply to any message type. In addition, users can confuse the message symbol question mark with Help information. Therefore, do not use this question mark message symbol in your message boxes. The system continues to support its inclusion only for backward compatibility.
        /// </remarks>
        Question = 0x00000020,

        /// <summary>
        /// A stop-sign icon appears in the message box.
        /// </summary>
        Error = 0x00000010
    }
    
#if !BUTRMESSAGEBOXPINVOKE_INCLUDE_IN_CODE_COVERAGE
    [ExcludeFromCodeCoverage, DebuggerNonUserCode]
#endif
    internal static class MessageBoxDialog
    {
#if BUTRMESSAGEBOXPINVOKE_UNSAFE
        [DllImport("USER32.dll", ExactSpelling = true, EntryPoint = "MessageBoxW", SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern unsafe MESSAGEBOX_RESULT MessageBox(IntPtr hWnd, char* lpText, char* lpCaption, MESSAGEBOX_STYLE uType);
        internal static unsafe MESSAGEBOX_RESULT MessageBox(IntPtr hWnd, string lpText, string lpCaption, MESSAGEBOX_STYLE uType)
        {
            fixed (char* lpCaptionLocal = lpCaption)
            fixed (char* lpTextLocal = lpText)
            {
                return MessageBox(hWnd, lpTextLocal, lpCaptionLocal, uType);
            }
        }
#else
        [DllImport("USER32.dll", ExactSpelling = true, EntryPoint = "MessageBoxW", SetLastError = true)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        internal static extern MESSAGEBOX_RESULT MessageBox(IntPtr hWnd, IntPtr lpText, IntPtr lpCaption, MESSAGEBOX_STYLE uType);
        internal static MESSAGEBOX_RESULT MessageBox(IntPtr hWnd, string lpText, string lpCaption, MESSAGEBOX_STYLE uType)
        {
            var lpTextLocal = Marshal.StringToHGlobalUni(lpText);
            var lpCaptionLocal = Marshal.StringToHGlobalUni(lpCaption);
            return MessageBox(hWnd, lpTextLocal, lpCaptionLocal, uType);
        }
#endif

        public static MessageBoxResult Show(string text) =>
            (MessageBoxResult) MessageBox(IntPtr.Zero, text, "\0", (MESSAGEBOX_STYLE) MessageBoxButtons.Ok);

        public static MessageBoxResult Show(string text, string caption) =>
            (MessageBoxResult) MessageBox(IntPtr.Zero, text, caption, (MESSAGEBOX_STYLE) MessageBoxButtons.Ok);

        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons) =>
            (MessageBoxResult) MessageBox(IntPtr.Zero, text, caption, (MESSAGEBOX_STYLE) buttons);

        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) =>
            (MessageBoxResult) MessageBox(IntPtr.Zero, text, caption, ((MESSAGEBOX_STYLE) buttons) | ((MESSAGEBOX_STYLE) icon));

        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton button) =>
            (MessageBoxResult) MessageBox(IntPtr.Zero, text, caption, ((MESSAGEBOX_STYLE) buttons) | ((MESSAGEBOX_STYLE) icon) | ((MESSAGEBOX_STYLE) button));

        public static MessageBoxResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton button, MessageBoxModal modal) =>
            (MessageBoxResult) MessageBox(IntPtr.Zero, text, caption, ((MESSAGEBOX_STYLE) buttons) | ((MESSAGEBOX_STYLE) icon) | ((MESSAGEBOX_STYLE) button) | ((MESSAGEBOX_STYLE) modal));
    }
}

#if !BUTRMESSAGEBOXPINVOKE_ENABLE_WARNINGS
#pragma warning restore
#endif
#nullable restore
#endif // BUTRMESSAGEBOXPINVOKE_DISABLE