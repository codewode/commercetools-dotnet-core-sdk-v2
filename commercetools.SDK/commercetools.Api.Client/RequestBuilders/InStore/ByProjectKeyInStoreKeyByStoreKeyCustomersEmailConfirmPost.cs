using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private commercetools.Api.Models.Customers.CustomerEmailVerify CustomerEmailVerify;
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Api.Models.Customers.CustomerEmailVerify customerEmailVerify) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.CustomerEmailVerify = customerEmailVerify;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/customers/email/confirm";
       }
   
   

       public async Task<JsonElement> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(CustomerEmailVerify);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}