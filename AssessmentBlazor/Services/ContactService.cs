using AssessmentBlazor.Model;

namespace AssessmentBlazor.Services
{
    public class ContactService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            var client = _httpClientFactory.CreateClient("api");

            var response = await client.GetFromJsonAsync<ResponseViewModel<List<Contact>>>("Contact/GetAllContacts");

            return response?.Data ?? new List<Contact>();
        }
    }
}
