﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Ecommerce.ServiceModel.ProductStockService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductStockService.IProductStockService")]
    public interface IProductStockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductStockService/Get", ReplyAction="http://tempuri.org/IProductStockService/GetResponse")]
        Sitecore.Ecommerce.DomainModel.Products.ProductStock Get(Sitecore.Ecommerce.DomainModel.Products.ProductStockInfo stockInfo, Sitecore.Ecommerce.Services.ServiceClientArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductStockService/Update", ReplyAction="http://tempuri.org/IProductStockService/UpdateResponse")]
        void Update(string code, long newAmount, Sitecore.Ecommerce.Services.ServiceClientArgs args);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductStockServiceChannel : Sitecore.Ecommerce.ServiceModel.ProductStockService.IProductStockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductStockServiceClient : System.ServiceModel.ClientBase<Sitecore.Ecommerce.ServiceModel.ProductStockService.IProductStockService>, Sitecore.Ecommerce.ServiceModel.ProductStockService.IProductStockService {
        
        public ProductStockServiceClient() {
        }
        
        public ProductStockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductStockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductStockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductStockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sitecore.Ecommerce.DomainModel.Products.ProductStock Get(Sitecore.Ecommerce.DomainModel.Products.ProductStockInfo stockInfo, Sitecore.Ecommerce.Services.ServiceClientArgs args) {
            return base.Channel.Get(stockInfo, args);
        }
        
        public void Update(string code, long newAmount, Sitecore.Ecommerce.Services.ServiceClientArgs args) {
            base.Channel.Update(code, newAmount, args);
        }
    }
}
