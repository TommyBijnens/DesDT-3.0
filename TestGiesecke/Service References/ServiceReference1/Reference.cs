﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestGiesecke.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="ServiceReference1.CreoWebServiceDef")]
    public interface CreoWebServiceDef {
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/CreoWebServiceDef/getParametersRequest", ReplyAction="http://WebService/CreoWebServiceDef/getParametersResponse")]
        TestGiesecke.ServiceReference1.getParametersResponse getParameters(TestGiesecke.ServiceReference1.getParametersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/CreoWebServiceDef/getParametersRequest", ReplyAction="http://WebService/CreoWebServiceDef/getParametersResponse")]
        System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.getParametersResponse> getParametersAsync(TestGiesecke.ServiceReference1.getParametersRequest request);
        
        // CODEGEN: Generating message contract since element name arg0 from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/CreoWebServiceDef/displayMessageRequest", ReplyAction="http://WebService/CreoWebServiceDef/displayMessageResponse")]
        TestGiesecke.ServiceReference1.displayMessageResponse displayMessage(TestGiesecke.ServiceReference1.displayMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/CreoWebServiceDef/displayMessageRequest", ReplyAction="http://WebService/CreoWebServiceDef/displayMessageResponse")]
        System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.displayMessageResponse> displayMessageAsync(TestGiesecke.ServiceReference1.displayMessageRequest request);
        
        // CODEGEN: Generating message contract since element name arg0 from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/CreoWebServiceDef/displayWarningRequest", ReplyAction="http://WebService/CreoWebServiceDef/displayWarningResponse")]
        TestGiesecke.ServiceReference1.displayWarningResponse displayWarning(TestGiesecke.ServiceReference1.displayWarningRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/CreoWebServiceDef/displayWarningRequest", ReplyAction="http://WebService/CreoWebServiceDef/displayWarningResponse")]
        System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.displayWarningResponse> displayWarningAsync(TestGiesecke.ServiceReference1.displayWarningRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getParametersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getParameters", Namespace="http://WebService/", Order=0)]
        public TestGiesecke.ServiceReference1.getParametersRequestBody Body;
        
        public getParametersRequest() {
        }
        
        public getParametersRequest(TestGiesecke.ServiceReference1.getParametersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getParametersRequestBody {
        
        public getParametersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getParametersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getParametersResponse", Namespace="http://WebService/", Order=0)]
        public TestGiesecke.ServiceReference1.getParametersResponseBody Body;
        
        public getParametersResponse() {
        }
        
        public getParametersResponse(TestGiesecke.ServiceReference1.getParametersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getParametersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public getParametersResponseBody() {
        }
        
        public getParametersResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class displayMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="displayMessage", Namespace="http://WebService/", Order=0)]
        public TestGiesecke.ServiceReference1.displayMessageRequestBody Body;
        
        public displayMessageRequest() {
        }
        
        public displayMessageRequest(TestGiesecke.ServiceReference1.displayMessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class displayMessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public displayMessageRequestBody() {
        }
        
        public displayMessageRequestBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class displayMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="displayMessageResponse", Namespace="http://WebService/", Order=0)]
        public TestGiesecke.ServiceReference1.displayMessageResponseBody Body;
        
        public displayMessageResponse() {
        }
        
        public displayMessageResponse(TestGiesecke.ServiceReference1.displayMessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class displayMessageResponseBody {
        
        public displayMessageResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class displayWarningRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="displayWarning", Namespace="http://WebService/", Order=0)]
        public TestGiesecke.ServiceReference1.displayWarningRequestBody Body;
        
        public displayWarningRequest() {
        }
        
        public displayWarningRequest(TestGiesecke.ServiceReference1.displayWarningRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class displayWarningRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public displayWarningRequestBody() {
        }
        
        public displayWarningRequestBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class displayWarningResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="displayWarningResponse", Namespace="http://WebService/", Order=0)]
        public TestGiesecke.ServiceReference1.displayWarningResponseBody Body;
        
        public displayWarningResponse() {
        }
        
        public displayWarningResponse(TestGiesecke.ServiceReference1.displayWarningResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class displayWarningResponseBody {
        
        public displayWarningResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CreoWebServiceDefChannel : TestGiesecke.ServiceReference1.CreoWebServiceDef, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreoWebServiceDefClient : System.ServiceModel.ClientBase<TestGiesecke.ServiceReference1.CreoWebServiceDef>, TestGiesecke.ServiceReference1.CreoWebServiceDef {
        
        public CreoWebServiceDefClient() {
        }
        
        public CreoWebServiceDefClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreoWebServiceDefClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreoWebServiceDefClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreoWebServiceDefClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestGiesecke.ServiceReference1.getParametersResponse TestGiesecke.ServiceReference1.CreoWebServiceDef.getParameters(TestGiesecke.ServiceReference1.getParametersRequest request) {
            return base.Channel.getParameters(request);
        }
        
        public string getParameters() {
            TestGiesecke.ServiceReference1.getParametersRequest inValue = new TestGiesecke.ServiceReference1.getParametersRequest();
            inValue.Body = new TestGiesecke.ServiceReference1.getParametersRequestBody();
            TestGiesecke.ServiceReference1.getParametersResponse retVal = ((TestGiesecke.ServiceReference1.CreoWebServiceDef)(this)).getParameters(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.getParametersResponse> TestGiesecke.ServiceReference1.CreoWebServiceDef.getParametersAsync(TestGiesecke.ServiceReference1.getParametersRequest request) {
            return base.Channel.getParametersAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.getParametersResponse> getParametersAsync() {
            TestGiesecke.ServiceReference1.getParametersRequest inValue = new TestGiesecke.ServiceReference1.getParametersRequest();
            inValue.Body = new TestGiesecke.ServiceReference1.getParametersRequestBody();
            return ((TestGiesecke.ServiceReference1.CreoWebServiceDef)(this)).getParametersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestGiesecke.ServiceReference1.displayMessageResponse TestGiesecke.ServiceReference1.CreoWebServiceDef.displayMessage(TestGiesecke.ServiceReference1.displayMessageRequest request) {
            return base.Channel.displayMessage(request);
        }
        
        public void displayMessage(string arg0) {
            TestGiesecke.ServiceReference1.displayMessageRequest inValue = new TestGiesecke.ServiceReference1.displayMessageRequest();
            inValue.Body = new TestGiesecke.ServiceReference1.displayMessageRequestBody();
            inValue.Body.arg0 = arg0;
            TestGiesecke.ServiceReference1.displayMessageResponse retVal = ((TestGiesecke.ServiceReference1.CreoWebServiceDef)(this)).displayMessage(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.displayMessageResponse> TestGiesecke.ServiceReference1.CreoWebServiceDef.displayMessageAsync(TestGiesecke.ServiceReference1.displayMessageRequest request) {
            return base.Channel.displayMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.displayMessageResponse> displayMessageAsync(string arg0) {
            TestGiesecke.ServiceReference1.displayMessageRequest inValue = new TestGiesecke.ServiceReference1.displayMessageRequest();
            inValue.Body = new TestGiesecke.ServiceReference1.displayMessageRequestBody();
            inValue.Body.arg0 = arg0;
            return ((TestGiesecke.ServiceReference1.CreoWebServiceDef)(this)).displayMessageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestGiesecke.ServiceReference1.displayWarningResponse TestGiesecke.ServiceReference1.CreoWebServiceDef.displayWarning(TestGiesecke.ServiceReference1.displayWarningRequest request) {
            return base.Channel.displayWarning(request);
        }
        
        public void displayWarning(string arg0) {
            TestGiesecke.ServiceReference1.displayWarningRequest inValue = new TestGiesecke.ServiceReference1.displayWarningRequest();
            inValue.Body = new TestGiesecke.ServiceReference1.displayWarningRequestBody();
            inValue.Body.arg0 = arg0;
            TestGiesecke.ServiceReference1.displayWarningResponse retVal = ((TestGiesecke.ServiceReference1.CreoWebServiceDef)(this)).displayWarning(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.displayWarningResponse> TestGiesecke.ServiceReference1.CreoWebServiceDef.displayWarningAsync(TestGiesecke.ServiceReference1.displayWarningRequest request) {
            return base.Channel.displayWarningAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestGiesecke.ServiceReference1.displayWarningResponse> displayWarningAsync(string arg0) {
            TestGiesecke.ServiceReference1.displayWarningRequest inValue = new TestGiesecke.ServiceReference1.displayWarningRequest();
            inValue.Body = new TestGiesecke.ServiceReference1.displayWarningRequestBody();
            inValue.Body.arg0 = arg0;
            return ((TestGiesecke.ServiceReference1.CreoWebServiceDef)(this)).displayWarningAsync(inValue);
        }
    }
}
