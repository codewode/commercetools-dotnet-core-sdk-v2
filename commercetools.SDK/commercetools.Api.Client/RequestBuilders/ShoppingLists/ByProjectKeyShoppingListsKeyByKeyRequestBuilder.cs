using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.ShoppingLists
{
   public class ByProjectKeyShoppingListsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyShoppingListsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyShoppingListsKeyByKeyGet Get() {
           return new ByProjectKeyShoppingListsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyShoppingListsKeyByKeyPost Post(commercetools.Api.Models.ShoppingLists.ShoppingListUpdate shoppingListUpdate) {
           return new ByProjectKeyShoppingListsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, shoppingListUpdate);
       }
       
       public ByProjectKeyShoppingListsKeyByKeyDelete Delete() {
           return new ByProjectKeyShoppingListsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}