﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeMove {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FreeMove.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 About FreeMove 的本地化字符串。
        /// </summary>
        internal static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The \&quot;{0}\&quot; directory cannot be moved. 的本地化字符串。
        /// </summary>
        internal static string BlacklistedException {
            get {
                return ResourceManager.GetString("BlacklistedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cancelled 的本地化字符串。
        /// </summary>
        internal static string Cancelled {
            get {
                return ResourceManager.GetString("Cancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Exception encountered while copying directory 的本地化字符串。
        /// </summary>
        internal static string CopyFailedException {
            get {
                return ResourceManager.GetString("CopyFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Exception encountered while removing duplicate files in the old location 的本地化字符串。
        /// </summary>
        internal static string DeleteFailedException {
            get {
                return ResourceManager.GetString("DeleteFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Details: 的本地化字符串。
        /// </summary>
        internal static string Details {
            get {
                return ResourceManager.GetString("Details", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Done! 的本地化字符串。
        /// </summary>
        internal static string Done {
            get {
                return ResourceManager.GetString("Done", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error 的本地化字符串。
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error details 的本地化字符串。
        /// </summary>
        internal static string ErrorDetail {
            get {
                return ResourceManager.GetString("ErrorDetail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid path 的本地化字符串。
        /// </summary>
        internal static string InvPathException {
            get {
                return ResourceManager.GetString("InvPathException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid path format 的本地化字符串。
        /// </summary>
        internal static string InvPathFormatException {
            get {
                return ResourceManager.GetString("InvPathFormatException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to create the destination directory. 的本地化字符串。
        /// </summary>
        internal static string IOException {
            get {
                return ResourceManager.GetString("IOException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Exception encountered while moving on the same drive 的本地化字符串。
        /// </summary>
        internal static string MoveFailedException {
            get {
                return ResourceManager.GetString("MoveFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Destination folder does not exist 的本地化字符串。
        /// </summary>
        internal static string NoDestException {
            get {
                return ResourceManager.GetString("NoDestException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Source folder does not exist 的本地化字符串。
        /// </summary>
        internal static string NoSourceException {
            get {
                return ResourceManager.GetString("NoSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There is not enough free space on the {0} disk. {1}MB required, {2} available. 的本地化字符串。
        /// </summary>
        internal static string NoSpaceException {
            get {
                return ResourceManager.GetString("NoSpaceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There are no updates available. 的本地化字符串。
        /// </summary>
        internal static string NoUpdate {
            get {
                return ResourceManager.GetString("NoUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 You do not have the required privileges to move the directory.\nTry running as administrator 的本地化字符串。
        /// </summary>
        internal static string PrivilegeException {
            get {
                return ResourceManager.GetString("PrivilegeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Moving files... 的本地化字符串。
        /// </summary>
        internal static string ProgressMoving {
            get {
                return ResourceManager.GetString("ProgressMoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Are you sure you want to cancel? 的本地化字符串。
        /// </summary>
        internal static string PromptCancel {
            get {
                return ResourceManager.GetString("PromptCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Finishing... 的本地化字符串。
        /// </summary>
        internal static string PromptDone {
            get {
                return ResourceManager.GetString("PromptDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Do you want to undo the changes? 的本地化字符串。
        /// </summary>
        internal static string PromptUndo {
            get {
                return ResourceManager.GetString("PromptUndo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Could not remove copied contents. Try removing manually. 的本地化字符串。
        /// </summary>
        internal static string RemoveError {
            get {
                return ResourceManager.GetString("RemoveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 It&apos;s recommended not to move the {0} directory, you can disable safe mode in the Settings tab to override this check 的本地化字符串。
        /// </summary>
        internal static string SafeCheckException {
            get {
                return ResourceManager.GetString("SafeCheckException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Destination folder already contains a folder with the same name 的本地化字符串。
        /// </summary>
        internal static string SameNameException {
            get {
                return ResourceManager.GetString("SameNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Could not create a symbolic link.\nTry running as administrator 的本地化字符串。
        /// </summary>
        internal static string SymLinkException {
            get {
                return ResourceManager.GetString("SymLinkException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Select the folder you want to move 的本地化字符串。
        /// </summary>
        internal static string TipFrom {
            get {
                return ResourceManager.GetString("TipFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Select whether you want to hide the shortcut which is created in the old location or not 的本地化字符串。
        /// </summary>
        internal static string TipHidden {
            get {
                return ResourceManager.GetString("TipHidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Select where you want to move the folder 的本地化字符串。
        /// </summary>
        internal static string TipTo {
            get {
                return ResourceManager.GetString("TipTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cancel confirmation 的本地化字符串。
        /// </summary>
        internal static string TitleCancel {
            get {
                return ResourceManager.GetString("TitleCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Lacking required permissions to create the destination directory. Try running as administrator. 的本地化字符串。
        /// </summary>
        internal static string UnauthorizedAccessException {
            get {
                return ResourceManager.GetString("UnauthorizedAccessException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Could not move back contents. Try moving manually. 的本地化字符串。
        /// </summary>
        internal static string UndoError {
            get {
                return ResourceManager.GetString("UndoError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Open the download page? 的本地化字符串。
        /// </summary>
        internal static string UpdateAsk {
            get {
                return ResourceManager.GetString("UpdateAsk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Current version:  的本地化字符串。
        /// </summary>
        internal static string UpdateCurrent {
            get {
                return ResourceManager.GetString("UpdateCurrent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Latest version:  的本地化字符串。
        /// </summary>
        internal static string UpdateLatest {
            get {
                return ResourceManager.GetString("UpdateLatest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 New version available! 的本地化字符串。
        /// </summary>
        internal static string UpdateNew {
            get {
                return ResourceManager.GetString("UpdateNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Warning 的本地化字符串。
        /// </summary>
        internal static string Warning {
            get {
                return ResourceManager.GetString("Warning", resourceCulture);
            }
        }
    }
}
