﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.235.
// 
#pragma warning disable 1591

namespace GetData.AtlasWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AllRsrOperationCompleted;
        
        private System.Threading.SendOrPostCallback RsrByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback PrjByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback PrjOfRsrOperationCompleted;
        
        private System.Threading.SendOrPostCallback CollaborationOfRsrOnPrjOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateIndexOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::GetData.Properties.Settings.Default.GetData_AtlasWebService_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AllRsrCompletedEventHandler AllRsrCompleted;
        
        /// <remarks/>
        public event RsrByNameCompletedEventHandler RsrByNameCompleted;
        
        /// <remarks/>
        public event PrjByNameCompletedEventHandler PrjByNameCompleted;
        
        /// <remarks/>
        public event PrjOfRsrCompletedEventHandler PrjOfRsrCompleted;
        
        /// <remarks/>
        public event CollaborationOfRsrOnPrjCompletedEventHandler CollaborationOfRsrOnPrjCompleted;
        
        /// <remarks/>
        public event CreateIndexCompletedEventHandler CreateIndexCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AllRsr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode AllRsr() {
            object[] results = this.Invoke("AllRsr", new object[0]);
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void AllRsrAsync() {
            this.AllRsrAsync(null);
        }
        
        /// <remarks/>
        public void AllRsrAsync(object userState) {
            if ((this.AllRsrOperationCompleted == null)) {
                this.AllRsrOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllRsrOperationCompleted);
            }
            this.InvokeAsync("AllRsr", new object[0], this.AllRsrOperationCompleted, userState);
        }
        
        private void OnAllRsrOperationCompleted(object arg) {
            if ((this.AllRsrCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AllRsrCompleted(this, new AllRsrCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RsrByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode RsrByName(string fname, string lname) {
            object[] results = this.Invoke("RsrByName", new object[] {
                        fname,
                        lname});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void RsrByNameAsync(string fname, string lname) {
            this.RsrByNameAsync(fname, lname, null);
        }
        
        /// <remarks/>
        public void RsrByNameAsync(string fname, string lname, object userState) {
            if ((this.RsrByNameOperationCompleted == null)) {
                this.RsrByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRsrByNameOperationCompleted);
            }
            this.InvokeAsync("RsrByName", new object[] {
                        fname,
                        lname}, this.RsrByNameOperationCompleted, userState);
        }
        
        private void OnRsrByNameOperationCompleted(object arg) {
            if ((this.RsrByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RsrByNameCompleted(this, new RsrByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PrjByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode PrjByName(string name, string id, string mstid) {
            object[] results = this.Invoke("PrjByName", new object[] {
                        name,
                        id,
                        mstid});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void PrjByNameAsync(string name, string id, string mstid) {
            this.PrjByNameAsync(name, id, mstid, null);
        }
        
        /// <remarks/>
        public void PrjByNameAsync(string name, string id, string mstid, object userState) {
            if ((this.PrjByNameOperationCompleted == null)) {
                this.PrjByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPrjByNameOperationCompleted);
            }
            this.InvokeAsync("PrjByName", new object[] {
                        name,
                        id,
                        mstid}, this.PrjByNameOperationCompleted, userState);
        }
        
        private void OnPrjByNameOperationCompleted(object arg) {
            if ((this.PrjByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PrjByNameCompleted(this, new PrjByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PrjOfRsr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode PrjOfRsr(string name, string id, string mstid) {
            object[] results = this.Invoke("PrjOfRsr", new object[] {
                        name,
                        id,
                        mstid});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void PrjOfRsrAsync(string name, string id, string mstid) {
            this.PrjOfRsrAsync(name, id, mstid, null);
        }
        
        /// <remarks/>
        public void PrjOfRsrAsync(string name, string id, string mstid, object userState) {
            if ((this.PrjOfRsrOperationCompleted == null)) {
                this.PrjOfRsrOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPrjOfRsrOperationCompleted);
            }
            this.InvokeAsync("PrjOfRsr", new object[] {
                        name,
                        id,
                        mstid}, this.PrjOfRsrOperationCompleted, userState);
        }
        
        private void OnPrjOfRsrOperationCompleted(object arg) {
            if ((this.PrjOfRsrCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PrjOfRsrCompleted(this, new PrjOfRsrCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CollaborationOfRsrOnPrj", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode CollaborationOfRsrOnPrj(string id) {
            object[] results = this.Invoke("CollaborationOfRsrOnPrj", new object[] {
                        id});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void CollaborationOfRsrOnPrjAsync(string id) {
            this.CollaborationOfRsrOnPrjAsync(id, null);
        }
        
        /// <remarks/>
        public void CollaborationOfRsrOnPrjAsync(string id, object userState) {
            if ((this.CollaborationOfRsrOnPrjOperationCompleted == null)) {
                this.CollaborationOfRsrOnPrjOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCollaborationOfRsrOnPrjOperationCompleted);
            }
            this.InvokeAsync("CollaborationOfRsrOnPrj", new object[] {
                        id}, this.CollaborationOfRsrOnPrjOperationCompleted, userState);
        }
        
        private void OnCollaborationOfRsrOnPrjOperationCompleted(object arg) {
            if ((this.CollaborationOfRsrOnPrjCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CollaborationOfRsrOnPrjCompleted(this, new CollaborationOfRsrOnPrjCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateIndex", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateIndex(string indName) {
            this.Invoke("CreateIndex", new object[] {
                        indName});
        }
        
        /// <remarks/>
        public void CreateIndexAsync(string indName) {
            this.CreateIndexAsync(indName, null);
        }
        
        /// <remarks/>
        public void CreateIndexAsync(string indName, object userState) {
            if ((this.CreateIndexOperationCompleted == null)) {
                this.CreateIndexOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateIndexOperationCompleted);
            }
            this.InvokeAsync("CreateIndex", new object[] {
                        indName}, this.CreateIndexOperationCompleted, userState);
        }
        
        private void OnCreateIndexOperationCompleted(object arg) {
            if ((this.CreateIndexCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateIndexCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AllRsrCompletedEventHandler(object sender, AllRsrCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AllRsrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AllRsrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void RsrByNameCompletedEventHandler(object sender, RsrByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RsrByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RsrByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void PrjByNameCompletedEventHandler(object sender, PrjByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PrjByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PrjByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void PrjOfRsrCompletedEventHandler(object sender, PrjOfRsrCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PrjOfRsrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PrjOfRsrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CollaborationOfRsrOnPrjCompletedEventHandler(object sender, CollaborationOfRsrOnPrjCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CollaborationOfRsrOnPrjCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CollaborationOfRsrOnPrjCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CreateIndexCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591