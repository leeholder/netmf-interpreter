//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
namespace XsdScatterfileSchemaObject {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd", IsNullable=false)]
    public partial class ScatterFile {
        
        private System.Collections.Generic.List<Set> setField;
        
        private System.Collections.Generic.List<If> ifField;
        
        private System.Collections.Generic.List<IfDefined> ifDefinedField;
        
        private System.Collections.Generic.List<IfNotDefined> ifNotDefinedField;
        
        private System.Collections.Generic.List<LoadRegion> loadRegionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Set")]
        public System.Collections.Generic.List<Set> Set {
            get {
                return this.setField;
            }
            set {
                this.setField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If")]
        public System.Collections.Generic.List<If> If {
            get {
                return this.ifField;
            }
            set {
                this.ifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfDefined")]
        public System.Collections.Generic.List<IfDefined> IfDefined {
            get {
                return this.ifDefinedField;
            }
            set {
                this.ifDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfNotDefined")]
        public System.Collections.Generic.List<IfNotDefined> IfNotDefined {
            get {
                return this.ifNotDefinedField;
            }
            set {
                this.ifNotDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadRegion")]
        public System.Collections.Generic.List<LoadRegion> LoadRegion {
            get {
                return this.loadRegionField;
            }
            set {
                this.loadRegionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class Set {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class Error {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class IfNotDefined {
        
        private System.Collections.Generic.List<FileMapping> fileMappingField;
        
        private System.Collections.Generic.List<LoadRegion> loadRegionField;
        
        private System.Collections.Generic.List<ExecRegion> execRegionField;
        
        private System.Collections.Generic.List<IfDefined> ifDefinedField;
        
        private System.Collections.Generic.List<IfNotDefined> ifNotDefined1Field;
        
        private System.Collections.Generic.List<If> ifField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileMapping")]
        public System.Collections.Generic.List<FileMapping> FileMapping {
            get {
                return this.fileMappingField;
            }
            set {
                this.fileMappingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadRegion")]
        public System.Collections.Generic.List<LoadRegion> LoadRegion {
            get {
                return this.loadRegionField;
            }
            set {
                this.loadRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExecRegion")]
        public System.Collections.Generic.List<ExecRegion> ExecRegion {
            get {
                return this.execRegionField;
            }
            set {
                this.execRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfDefined")]
        public System.Collections.Generic.List<IfDefined> IfDefined {
            get {
                return this.ifDefinedField;
            }
            set {
                this.ifDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfNotDefined")]
        public System.Collections.Generic.List<IfNotDefined> IfNotDefined1 {
            get {
                return this.ifNotDefined1Field;
            }
            set {
                this.ifNotDefined1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If")]
        public System.Collections.Generic.List<If> If {
            get {
                return this.ifField;
            }
            set {
                this.ifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class FileMapping {
        
        private string nameField;
        
        private string optionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class LoadRegion {
        
        private System.Collections.Generic.List<ExecRegion> execRegionField;
        
        private System.Collections.Generic.List<If> ifField;
        
        private System.Collections.Generic.List<IfDefined> ifDefinedField;
        
        private System.Collections.Generic.List<IfNotDefined> ifNotDefinedField;
        
        private string nameField;
        
        private string baseField;
        
        private string optionsField;
        
        private string sizeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExecRegion")]
        public System.Collections.Generic.List<ExecRegion> ExecRegion {
            get {
                return this.execRegionField;
            }
            set {
                this.execRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If")]
        public System.Collections.Generic.List<If> If {
            get {
                return this.ifField;
            }
            set {
                this.ifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfDefined")]
        public System.Collections.Generic.List<IfDefined> IfDefined {
            get {
                return this.ifDefinedField;
            }
            set {
                this.ifDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfNotDefined")]
        public System.Collections.Generic.List<IfNotDefined> IfNotDefined {
            get {
                return this.ifNotDefinedField;
            }
            set {
                this.ifNotDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class ExecRegion {
        
        private System.Collections.Generic.List<FileMapping> fileMappingField;
        
        private System.Collections.Generic.List<If> ifField;
        
        private System.Collections.Generic.List<IfDefined> ifDefinedField;
        
        private System.Collections.Generic.List<IfNotDefined> ifNotDefinedField;
        
        private string nameField;
        
        private string baseField;
        
        private string optionsField;
        
        private string sizeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileMapping")]
        public System.Collections.Generic.List<FileMapping> FileMapping {
            get {
                return this.fileMappingField;
            }
            set {
                this.fileMappingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If")]
        public System.Collections.Generic.List<If> If {
            get {
                return this.ifField;
            }
            set {
                this.ifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfDefined")]
        public System.Collections.Generic.List<IfDefined> IfDefined {
            get {
                return this.ifDefinedField;
            }
            set {
                this.ifDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfNotDefined")]
        public System.Collections.Generic.List<IfNotDefined> IfNotDefined {
            get {
                return this.ifNotDefinedField;
            }
            set {
                this.ifNotDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class If {
        
        private System.Collections.Generic.List<Set> setField;
        
        private System.Collections.Generic.List<If> if1Field;
        
        private System.Collections.Generic.List<IfDefined> ifDefinedField;
        
        private System.Collections.Generic.List<IfNotDefined> ifNotDefinedField;
        
        private Error errorField;
        
        private System.Collections.Generic.List<FileMapping> fileMappingField;
        
        private System.Collections.Generic.List<LoadRegion> loadRegionField;
        
        private System.Collections.Generic.List<ExecRegion> execRegionField;
        
        private string nameField;
        
        private string valueField;
        
        private string inField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Set")]
        public System.Collections.Generic.List<Set> Set {
            get {
                return this.setField;
            }
            set {
                this.setField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If")]
        public System.Collections.Generic.List<If> If1 {
            get {
                return this.if1Field;
            }
            set {
                this.if1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfDefined")]
        public System.Collections.Generic.List<IfDefined> IfDefined {
            get {
                return this.ifDefinedField;
            }
            set {
                this.ifDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfNotDefined")]
        public System.Collections.Generic.List<IfNotDefined> IfNotDefined {
            get {
                return this.ifNotDefinedField;
            }
            set {
                this.ifNotDefinedField = value;
            }
        }
        
        /// <remarks/>
        public Error Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileMapping")]
        public System.Collections.Generic.List<FileMapping> FileMapping {
            get {
                return this.fileMappingField;
            }
            set {
                this.fileMappingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadRegion")]
        public System.Collections.Generic.List<LoadRegion> LoadRegion {
            get {
                return this.loadRegionField;
            }
            set {
                this.loadRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExecRegion")]
        public System.Collections.Generic.List<ExecRegion> ExecRegion {
            get {
                return this.execRegionField;
            }
            set {
                this.execRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string In {
            get {
                return this.inField;
            }
            set {
                this.inField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/netmf/ScatterfileSchema.xsd")]
    public partial class IfDefined {
        
        private System.Collections.Generic.List<FileMapping> fileMappingField;
        
        private System.Collections.Generic.List<LoadRegion> loadRegionField;
        
        private System.Collections.Generic.List<ExecRegion> execRegionField;
        
        private System.Collections.Generic.List<IfDefined> ifDefined1Field;
        
        private System.Collections.Generic.List<IfNotDefined> ifNotDefinedField;
        
        private System.Collections.Generic.List<If> ifField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileMapping")]
        public System.Collections.Generic.List<FileMapping> FileMapping {
            get {
                return this.fileMappingField;
            }
            set {
                this.fileMappingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadRegion")]
        public System.Collections.Generic.List<LoadRegion> LoadRegion {
            get {
                return this.loadRegionField;
            }
            set {
                this.loadRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExecRegion")]
        public System.Collections.Generic.List<ExecRegion> ExecRegion {
            get {
                return this.execRegionField;
            }
            set {
                this.execRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfDefined")]
        public System.Collections.Generic.List<IfDefined> IfDefined1 {
            get {
                return this.ifDefined1Field;
            }
            set {
                this.ifDefined1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfNotDefined")]
        public System.Collections.Generic.List<IfNotDefined> IfNotDefined {
            get {
                return this.ifNotDefinedField;
            }
            set {
                this.ifNotDefinedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If")]
        public System.Collections.Generic.List<If> If {
            get {
                return this.ifField;
            }
            set {
                this.ifField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}