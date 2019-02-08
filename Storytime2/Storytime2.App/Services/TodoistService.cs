using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Storytime2.App.Services
{
    public class TodoistSyncResponse
    {
        public Item[] Items { get; set; }
        public Label[] Labels { get; set; }
        public Project[] Projects { get; set; }
        public bool FullSync { get; set; }

        public string SyncToken { get; set; } = "*";
    }

    public class TodoistService
    {
        private HttpClient httpClient;
        public TodoistService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Item[]> GetTodosAsync()
        {
            UriBuilder todoistUri = new UriBuilder("https://todoist.com/api/v7/sync");
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["token"] = "947b80f211fcd6bd6fe54b8056a56ff25901c575";
            parameters["resource_types"] = @"[""items"", ""projects"", ""labels""]";
            FormUrlEncodedContent request = new FormUrlEncodedContent(parameters);
            HttpResponseMessage responseMessage = await httpClient.PostAsync(todoistUri.Uri, request);
            string jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            TodoistSyncResponse response = JsonConvert.DeserializeObject<TodoistSyncResponse>(jsonResponse);
            return response.Items;
        }
    }
}
