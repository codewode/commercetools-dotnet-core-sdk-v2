using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Ml.Client.RequestBuilders.MissingData
{
   public partial class ByProjectKeyMissingDataAttributesPost : ApiMethod<ByProjectKeyMissingDataAttributesPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Ml.Models.MissingData.IMissingAttributesSearchRequest MissingAttributesSearchRequest;
   
       public ByProjectKeyMissingDataAttributesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Ml.Models.MissingData.IMissingAttributesSearchRequest missingAttributesSearchRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.MissingAttributesSearchRequest = missingAttributesSearchRequest;
           this.RequestUrl = $"/{ProjectKey}/missing-data/attributes";
       }
   
   

       public async Task<commercetools.Ml.Models.Common.TaskToken> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Ml.Models.Common.TaskToken>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(MissingAttributesSearchRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}