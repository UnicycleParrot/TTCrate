﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrawlLib.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<BrawlLib.SSBB.ResourceNodes.CodeStorage> Codes {
            get {
                return ((global::System.Collections.Generic.List<BrawlLib.SSBB.ResourceNodes.CodeStorage>)(this["Codes"]));
            }
            set {
                this["Codes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveGCTWithInfo {
            get {
                return ((bool)(this["SaveGCTWithInfo"]));
            }
            set {
                this["SaveGCTWithInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Modeling.Collada.Collada.ImportOptions ColladaImportOptions {
            get {
                return ((global::BrawlLib.Modeling.Collada.Collada.ImportOptions)(this["ColladaImportOptions"]));
            }
            set {
                this["ColladaImportOptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CompatibilityMode {
            get {
                return ((bool)(this["CompatibilityMode"]));
            }
            set {
                this["CompatibilityMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideMDL0Errors {
            get {
                return ((bool)(this["HideMDL0Errors"]));
            }
            set {
                this["HideMDL0Errors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public global::System.Nullable<System.Double> AudioVolumePercent {
            get {
                return ((global::System.Nullable<System.Double>)(this["AudioVolumePercent"]));
            }
            set {
                this["AudioVolumePercent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoDecompressFighterPAC {
            get {
                return ((bool)(this["AutoDecompressFighterPAC"]));
            }
            set {
                this["AutoDecompressFighterPAC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoCompressFighterPCS {
            get {
                return ((bool)(this["AutoCompressFighterPCS"]));
            }
            set {
                this["AutoCompressFighterPCS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoCompressStages {
            get {
                return ((bool)(this["AutoCompressStages"]));
            }
            set {
                this["AutoCompressStages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoCompressModules {
            get {
                return ((bool)(this["AutoCompressModules"]));
            }
            set {
                this["AutoCompressModules"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoPlayAudio {
            get {
                return ((bool)(this["AutoPlayAudio"]));
            }
            set {
                this["AutoPlayAudio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ContextualLoopAudio {
            get {
                return ((bool)(this["ContextualLoopAudio"]));
            }
            set {
                this["ContextualLoopAudio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ContextualLoopAnimation {
            get {
                return ((bool)(this["ContextualLoopAnimation"]));
            }
            set {
                this["ContextualLoopAnimation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ParseMoveDef {
            get {
                return ((bool)(this["ParseMoveDef"]));
            }
            set {
                this["ParseMoveDef"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraControlMode CameraControlMode {
            get {
                return ((global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraControlMode)(this["CameraControlMode"]));
            }
            set {
                this["CameraControlMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction CameraRightMouse {
            get {
                return ((global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction)(this["CameraRightMouse"]));
            }
            set {
                this["CameraRightMouse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction CameraMiddleMouse {
            get {
                return ((global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction)(this["CameraMiddleMouse"]));
            }
            set {
                this["CameraMiddleMouse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction CameraCtrlRMB {
            get {
                return ((global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction)(this["CameraCtrlRMB"]));
            }
            set {
                this["CameraCtrlRMB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction CameraCtrlAltRMB {
            get {
                return ((global::BrawlLib.Internal.Windows.Controls.Model_Panel.ModelPanelViewport.CameraDragAction)(this["CameraCtrlAltRMB"]));
            }
            set {
                this["CameraCtrlAltRMB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CameraPanInvertX {
            get {
                return ((bool)(this["CameraPanInvertX"]));
            }
            set {
                this["CameraPanInvertX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CameraPanInvertY {
            get {
                return ((bool)(this["CameraPanInvertY"]));
            }
            set {
                this["CameraPanInvertY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CameraRotateInvertX {
            get {
                return ((bool)(this["CameraRotateInvertX"]));
            }
            set {
                this["CameraRotateInvertX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CameraRotateInvertY {
            get {
                return ((bool)(this["CameraRotateInvertY"]));
            }
            set {
                this["CameraRotateInvertY"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowProgressBars {
            get {
                return ((bool)(this["ShowProgressBars"]));
            }
        }
    }
}
