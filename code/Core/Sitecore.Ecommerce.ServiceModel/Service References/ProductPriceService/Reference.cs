﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Ecommerce.ServiceModel.ProductPriceService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductPriceService.IProductPriceService")]
    public interface IProductPriceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductPriceService/GetPriceMatrix", ReplyAction="http://tempuri.org/IProductPriceService/GetPriceMatrixResponse")]
        string GetPriceMatrix(string code, Sitecore.Ecommerce.Services.ServiceClientArgs args);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductPriceServiceChannel : Sitecore.Ecommerce.ServiceModel.ProductPriceService.IProductPriceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductPriceServiceClient : System.ServiceModel.ClientBase<Sitecore.Ecommerce.ServiceModel.ProductPriceService.IProductPriceService>, Sitecore.Ecommerce.ServiceModel.ProductPriceService.IProductPriceService {
        
        public ProductPriceServiceClient() {
        }
        
        public ProductPriceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductPriceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductPriceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductPriceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPriceMatrix(string code, Sitecore.Ecommerce.Services.ServiceClientArgs args) {
            return base.Channel.GetPriceMatrix(code, args);
        }
    }
}
