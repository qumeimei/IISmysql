﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace SQA.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ExecuteScalar", ReplyAction="*")]
        System.IAsyncResult BeginExecuteScalar(SQA.ServiceReference1.ExecuteScalarRequest request, System.AsyncCallback callback, object asyncState);
        
        SQA.ServiceReference1.ExecuteScalarResponse EndExecuteScalar(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ExecuteNonQuery", ReplyAction="*")]
        System.IAsyncResult BeginExecuteNonQuery(SQA.ServiceReference1.ExecuteNonQueryRequest request, System.AsyncCallback callback, object asyncState);
        
        SQA.ServiceReference1.ExecuteNonQueryResponse EndExecuteNonQuery(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteScalarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteScalar", Namespace="http://tempuri.org/", Order=0)]
        public SQA.ServiceReference1.ExecuteScalarRequestBody Body;
        
        public ExecuteScalarRequest() {
        }
        
        public ExecuteScalarRequest(SQA.ServiceReference1.ExecuteScalarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecuteScalarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sql;
        
        public ExecuteScalarRequestBody() {
        }
        
        public ExecuteScalarRequestBody(string sql) {
            this.sql = sql;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteScalarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteScalarResponse", Namespace="http://tempuri.org/", Order=0)]
        public SQA.ServiceReference1.ExecuteScalarResponseBody Body;
        
        public ExecuteScalarResponse() {
        }
        
        public ExecuteScalarResponse(SQA.ServiceReference1.ExecuteScalarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecuteScalarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExecuteScalarResult;
        
        public ExecuteScalarResponseBody() {
        }
        
        public ExecuteScalarResponseBody(string ExecuteScalarResult) {
            this.ExecuteScalarResult = ExecuteScalarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteNonQueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteNonQuery", Namespace="http://tempuri.org/", Order=0)]
        public SQA.ServiceReference1.ExecuteNonQueryRequestBody Body;
        
        public ExecuteNonQueryRequest() {
        }
        
        public ExecuteNonQueryRequest(SQA.ServiceReference1.ExecuteNonQueryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecuteNonQueryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sql;
        
        public ExecuteNonQueryRequestBody() {
        }
        
        public ExecuteNonQueryRequestBody(string sql) {
            this.sql = sql;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteNonQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteNonQueryResponse", Namespace="http://tempuri.org/", Order=0)]
        public SQA.ServiceReference1.ExecuteNonQueryResponseBody Body;
        
        public ExecuteNonQueryResponse() {
        }
        
        public ExecuteNonQueryResponse(SQA.ServiceReference1.ExecuteNonQueryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecuteNonQueryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExecuteNonQueryResult;
        
        public ExecuteNonQueryResponseBody() {
        }
        
        public ExecuteNonQueryResponseBody(string ExecuteNonQueryResult) {
            this.ExecuteNonQueryResult = ExecuteNonQueryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : SQA.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteScalarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteScalarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteNonQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteNonQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<SQA.ServiceReference1.WebService1Soap>, SQA.ServiceReference1.WebService1Soap {
        
        private BeginOperationDelegate onBeginExecuteScalarDelegate;
        
        private EndOperationDelegate onEndExecuteScalarDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteScalarCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteNonQueryDelegate;
        
        private EndOperationDelegate onEndExecuteNonQueryDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteNonQueryCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<ExecuteScalarCompletedEventArgs> ExecuteScalarCompleted;
        
        public event System.EventHandler<ExecuteNonQueryCompletedEventArgs> ExecuteNonQueryCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SQA.ServiceReference1.WebService1Soap.BeginExecuteScalar(SQA.ServiceReference1.ExecuteScalarRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteScalar(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginExecuteScalar(string sql, System.AsyncCallback callback, object asyncState) {
            SQA.ServiceReference1.ExecuteScalarRequest inValue = new SQA.ServiceReference1.ExecuteScalarRequest();
            inValue.Body = new SQA.ServiceReference1.ExecuteScalarRequestBody();
            inValue.Body.sql = sql;
            return ((SQA.ServiceReference1.WebService1Soap)(this)).BeginExecuteScalar(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SQA.ServiceReference1.ExecuteScalarResponse SQA.ServiceReference1.WebService1Soap.EndExecuteScalar(System.IAsyncResult result) {
            return base.Channel.EndExecuteScalar(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private string EndExecuteScalar(System.IAsyncResult result) {
            SQA.ServiceReference1.ExecuteScalarResponse retVal = ((SQA.ServiceReference1.WebService1Soap)(this)).EndExecuteScalar(result);
            return retVal.Body.ExecuteScalarResult;
        }
        
        private System.IAsyncResult OnBeginExecuteScalar(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string sql = ((string)(inValues[0]));
            return this.BeginExecuteScalar(sql, callback, asyncState);
        }
        
        private object[] OnEndExecuteScalar(System.IAsyncResult result) {
            string retVal = this.EndExecuteScalar(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteScalarCompleted(object state) {
            if ((this.ExecuteScalarCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteScalarCompleted(this, new ExecuteScalarCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteScalarAsync(string sql) {
            this.ExecuteScalarAsync(sql, null);
        }
        
        public void ExecuteScalarAsync(string sql, object userState) {
            if ((this.onBeginExecuteScalarDelegate == null)) {
                this.onBeginExecuteScalarDelegate = new BeginOperationDelegate(this.OnBeginExecuteScalar);
            }
            if ((this.onEndExecuteScalarDelegate == null)) {
                this.onEndExecuteScalarDelegate = new EndOperationDelegate(this.OnEndExecuteScalar);
            }
            if ((this.onExecuteScalarCompletedDelegate == null)) {
                this.onExecuteScalarCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteScalarCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteScalarDelegate, new object[] {
                        sql}, this.onEndExecuteScalarDelegate, this.onExecuteScalarCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SQA.ServiceReference1.WebService1Soap.BeginExecuteNonQuery(SQA.ServiceReference1.ExecuteNonQueryRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteNonQuery(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginExecuteNonQuery(string sql, System.AsyncCallback callback, object asyncState) {
            SQA.ServiceReference1.ExecuteNonQueryRequest inValue = new SQA.ServiceReference1.ExecuteNonQueryRequest();
            inValue.Body = new SQA.ServiceReference1.ExecuteNonQueryRequestBody();
            inValue.Body.sql = sql;
            return ((SQA.ServiceReference1.WebService1Soap)(this)).BeginExecuteNonQuery(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SQA.ServiceReference1.ExecuteNonQueryResponse SQA.ServiceReference1.WebService1Soap.EndExecuteNonQuery(System.IAsyncResult result) {
            return base.Channel.EndExecuteNonQuery(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private string EndExecuteNonQuery(System.IAsyncResult result) {
            SQA.ServiceReference1.ExecuteNonQueryResponse retVal = ((SQA.ServiceReference1.WebService1Soap)(this)).EndExecuteNonQuery(result);
            return retVal.Body.ExecuteNonQueryResult;
        }
        
        private System.IAsyncResult OnBeginExecuteNonQuery(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string sql = ((string)(inValues[0]));
            return this.BeginExecuteNonQuery(sql, callback, asyncState);
        }
        
        private object[] OnEndExecuteNonQuery(System.IAsyncResult result) {
            string retVal = this.EndExecuteNonQuery(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteNonQueryCompleted(object state) {
            if ((this.ExecuteNonQueryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteNonQueryCompleted(this, new ExecuteNonQueryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteNonQueryAsync(string sql) {
            this.ExecuteNonQueryAsync(sql, null);
        }
        
        public void ExecuteNonQueryAsync(string sql, object userState) {
            if ((this.onBeginExecuteNonQueryDelegate == null)) {
                this.onBeginExecuteNonQueryDelegate = new BeginOperationDelegate(this.OnBeginExecuteNonQuery);
            }
            if ((this.onEndExecuteNonQueryDelegate == null)) {
                this.onEndExecuteNonQueryDelegate = new EndOperationDelegate(this.OnEndExecuteNonQuery);
            }
            if ((this.onExecuteNonQueryCompletedDelegate == null)) {
                this.onExecuteNonQueryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteNonQueryCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteNonQueryDelegate, new object[] {
                        sql}, this.onEndExecuteNonQueryDelegate, this.onExecuteNonQueryCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SQA.ServiceReference1.WebService1Soap CreateChannel() {
            return new WebService1SoapClientChannel(this);
        }
        
        private class WebService1SoapClientChannel : ChannelBase<SQA.ServiceReference1.WebService1Soap>, SQA.ServiceReference1.WebService1Soap {
            
            public WebService1SoapClientChannel(System.ServiceModel.ClientBase<SQA.ServiceReference1.WebService1Soap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginExecuteScalar(SQA.ServiceReference1.ExecuteScalarRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("ExecuteScalar", _args, callback, asyncState);
                return _result;
            }
            
            public SQA.ServiceReference1.ExecuteScalarResponse EndExecuteScalar(System.IAsyncResult result) {
                object[] _args = new object[0];
                SQA.ServiceReference1.ExecuteScalarResponse _result = ((SQA.ServiceReference1.ExecuteScalarResponse)(base.EndInvoke("ExecuteScalar", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginExecuteNonQuery(SQA.ServiceReference1.ExecuteNonQueryRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("ExecuteNonQuery", _args, callback, asyncState);
                return _result;
            }
            
            public SQA.ServiceReference1.ExecuteNonQueryResponse EndExecuteNonQuery(System.IAsyncResult result) {
                object[] _args = new object[0];
                SQA.ServiceReference1.ExecuteNonQueryResponse _result = ((SQA.ServiceReference1.ExecuteNonQueryResponse)(base.EndInvoke("ExecuteNonQuery", _args, result)));
                return _result;
            }
        }
    }
}
