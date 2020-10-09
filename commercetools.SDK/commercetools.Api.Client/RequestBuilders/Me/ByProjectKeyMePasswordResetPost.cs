using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMePasswordResetPost : ApiMethod<ByProjectKeyMePasswordResetPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyMePasswordResetPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/me/password/reset";
       }
   
   

       public async Task<commercetools.Api.Models.Me.MyCustomer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Me.MyCustomer>(requestMessage);
       }
   }
}