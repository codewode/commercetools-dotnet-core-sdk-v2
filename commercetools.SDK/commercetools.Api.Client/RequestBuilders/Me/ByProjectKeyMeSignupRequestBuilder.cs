using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMeSignupRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMeSignupRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMeSignupPost Post(commercetools.Api.Models.Me.MyCustomerDraft myCustomerDraft) {
           return new ByProjectKeyMeSignupPost(ApiHttpClient, SerializerService, ProjectKey, myCustomerDraft);
       }
       
   }
}