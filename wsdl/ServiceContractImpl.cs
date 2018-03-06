﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IServiceContract")]
public interface IServiceContract
{
    
    // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname PingResult aus Namespace http://tempuri.org/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/Ping", ReplyAction="*")]
    PingResponse Ping(PingRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/Ping", ReplyAction="*")]
    System.Threading.Tasks.Task<PingResponse> PingAsync(PingRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class PingRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="Ping", Namespace="http://tempuri.org/", Order=0)]
    public PingRequestBody Body;
    
    public PingRequest()
    {
    }
    
    public PingRequest(PingRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute()]
public partial class PingRequestBody
{
    
    public PingRequestBody()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class PingResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="PingResponse", Namespace="http://tempuri.org/", Order=0)]
    public PingResponseBody Body;
    
    public PingResponse()
    {
    }
    
    public PingResponse(PingResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
public partial class PingResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
    public string PingResult;
    
    public PingResponseBody()
    {
    }
    
    public PingResponseBody(string PingResult)
    {
        this.PingResult = PingResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceContractChannel : IServiceContract, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceContractClient : System.ServiceModel.ClientBase<IServiceContract>, IServiceContract
{
    
    public ServiceContractClient()
    {
    }
    
    public ServiceContractClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    PingResponse IServiceContract.Ping(PingRequest request)
    {
        return base.Channel.Ping(request);
    }
    
    public string Ping()
    {
        PingRequest inValue = new PingRequest();
        inValue.Body = new PingRequestBody();
        PingResponse retVal = ((IServiceContract)(this)).Ping(inValue);
        return retVal.Body.PingResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<PingResponse> IServiceContract.PingAsync(PingRequest request)
    {
        return base.Channel.PingAsync(request);
    }
    
    public System.Threading.Tasks.Task<PingResponse> PingAsync()
    {
        PingRequest inValue = new PingRequest();
        inValue.Body = new PingRequestBody();
        return ((IServiceContract)(this)).PingAsync(inValue);
    }
}