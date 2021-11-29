using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Decisions.Plaid.Data.Accounts.Balance;
using Decisions.Plaid.Data.Accounts.Get;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Applications;
using Decisions.Plaid.Data.AssetReports;
using Decisions.Plaid.Data.AssetReports.Audit;
using Decisions.Plaid.Data.AssetReports.Create;
using Decisions.Plaid.Data.AssetReports.Filter;
using Decisions.Plaid.Data.AssetReports.Refresh;
using Decisions.Plaid.Data.AssetReports.Remove;
using Decisions.Plaid.Data.Auth;
using Decisions.Plaid.Data.BankTransfer.Balance;
using Decisions.Plaid.Data.BankTransfer.Cancel;
using Decisions.Plaid.Data.BankTransfer.Create;
using Decisions.Plaid.Data.BankTransfer.Events;
using Decisions.Plaid.Data.BankTransfer.Get;
using Decisions.Plaid.Data.BankTransfer.List;
using Decisions.Plaid.Data.BankTransfer.MigrateAccount;
using Decisions.Plaid.Data.BankTransfer.Sweep;
using Decisions.Plaid.Data.Categories;
using Decisions.Plaid.Data.DepositSwitch.Create;
using Decisions.Plaid.Data.DepositSwitch.Get;
using Decisions.Plaid.Data.DepositSwitch.Token;
using Decisions.Plaid.Data.Employees;
using Decisions.Plaid.Data.Employees.Search;
using Decisions.Plaid.Data.Identity;
using Decisions.Plaid.Data.IncomeVerification.Create;
using Decisions.Plaid.Data.IncomeVerification.Documents;
using Decisions.Plaid.Data.IncomeVerification.Paystubs;
using Decisions.Plaid.Data.IncomeVerification.Precheck;
using Decisions.Plaid.Data.IncomeVerification.Refresh;
using Decisions.Plaid.Data.IncomeVerification.Summary;
using Decisions.Plaid.Data.IncomeVerification.Taxforms;
using Decisions.Plaid.Data.Institutions.Get;
using Decisions.Plaid.Data.Institutions.Search;
using Decisions.Plaid.Data.Investments.Holdings;
using Decisions.Plaid.Data.Investments.Transactions;
using Decisions.Plaid.Data.Items.AccessToken;
using Decisions.Plaid.Data.Items.Application;
using Decisions.Plaid.Data.Items.Get;
using Decisions.Plaid.Data.Items.Import;
using Decisions.Plaid.Data.Items.PublicToken;
using Decisions.Plaid.Data.Items.Remove;
using Decisions.Plaid.Data.Liabilities.Get;
using Decisions.Plaid.Data.LinkToken.Create;
using Decisions.Plaid.Data.LinkToken.Get;
using Decisions.Plaid.Data.PaymentInitiation.Payments;
using Decisions.Plaid.Data.PaymentInitiation.Recipient;
using Decisions.Plaid.Data.Processors;
using Decisions.Plaid.Data.Processors.Auth;
using Decisions.Plaid.Data.Processors.Balance;
using Decisions.Plaid.Data.Processors.Create;
using Decisions.Plaid.Data.Processors.Identity;
using Decisions.Plaid.Data.Processors.Stripe;
using Decisions.Plaid.Data.Processors.Token;
using Decisions.Plaid.Data.Sandbox;
using Decisions.Plaid.Data.Signal.DecisionReport;
using Decisions.Plaid.Data.Signal.Evaluate;
using Decisions.Plaid.Data.Signal.ReturnReport;
using Decisions.Plaid.Data.Transactions.Get;
using Decisions.Plaid.Data.Transactions.Recurring;
using Decisions.Plaid.Data.Transactions.Refresh;
using Decisions.Plaid.Data.Transactions.Sync;
using Decisions.Plaid.Data.Transfers.Authorization;
using Decisions.Plaid.Data.Transfers.Cancel;
using Decisions.Plaid.Data.Transfers.Create;
using Decisions.Plaid.Data.Transfers.EventList;
using Decisions.Plaid.Data.Transfers.Events;
using Decisions.Plaid.Data.Transfers.Get;
using Decisions.Plaid.Data.Transfers.List;
using Decisions.Plaid.Data.Webhooks;
using DecisionsFramework.ServiceLayer;

namespace Decisions.Plaid.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.4.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class PlaidClient 
    {
        private string _baseUrl;
        private HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public PlaidClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
            
            var settings = ModuleSettingsAccessor<PlaidSettings>.GetSettings();
            if (!string.IsNullOrEmpty(settings.PlaidBaseUrl))
            {
                _baseUrl = settings.PlaidBaseUrl;
            }
            else
            {
                _baseUrl = "https://sandbox.plaid.com";
                settings.PlaidBaseUrl = _baseUrl;
                ModuleSettingsAccessor<PlaidSettings>.SaveSettings();
            }
        }
    
        private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }
    
        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
    
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
    
    
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);
        /// <summary>List a user’s connected applications</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemApplicationListResponse> ItemApplicationListAsync(ItemApplicationListRequest body)
        {
            return ItemApplicationListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List a user’s connected applications</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemApplicationListResponse ItemApplicationList(ItemApplicationListRequest body)
        {
            return Task.Run(async () => await ItemApplicationListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List a user’s connected applications</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemApplicationListResponse> ItemApplicationListAsync(ItemApplicationListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/application/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemApplicationListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Update the scopes of access for a particular application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemApplicationScopesUpdateResponse> ItemApplicationScopesUpdateAsync(ItemApplicationScopesUpdateRequest body)
        {
            return ItemApplicationScopesUpdateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Update the scopes of access for a particular application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemApplicationScopesUpdateResponse ItemApplicationScopesUpdate(ItemApplicationScopesUpdateRequest body)
        {
            return Task.Run(async () => await ItemApplicationScopesUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update the scopes of access for a particular application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemApplicationScopesUpdateResponse> ItemApplicationScopesUpdateAsync(ItemApplicationScopesUpdateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/application/scopes/update");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemApplicationScopesUpdateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve information about a Plaid application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ApplicationGetResponse> ApplicationGetAsync(ApplicationGetRequest body)
        {
            return ApplicationGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve information about a Plaid application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ApplicationGetResponse ApplicationGet(ApplicationGetRequest body)
        {
            return Task.Run(async () => await ApplicationGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve information about a Plaid application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ApplicationGetResponse> ApplicationGetAsync(ApplicationGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/application/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;

                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ApplicationGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemGetResponse> ItemGetAsync(ItemGetRequest body)
        {
            return ItemGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemGetResponse ItemGet(ItemGetRequest body)
        {
            return Task.Run(async () => await ItemGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemGetResponse> ItemGetAsync(ItemGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AuthGetResponse> AuthGetAsync(AuthGetRequest body)
        {
            return AuthGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AuthGetResponse AuthGet(AuthGetRequest body)
        {
            return Task.Run(async () => await AuthGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AuthGetResponse> AuthGetAsync(AuthGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/auth/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AuthGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Default error", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransactionsGetResponse> TransactionsGetAsync(TransactionsGetRequest body)
        {
            return TransactionsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransactionsGetResponse TransactionsGet(TransactionsGetRequest body)
        {
            return Task.Run(async () => await TransactionsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransactionsGetResponse> TransactionsGetAsync(TransactionsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransactionsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Refresh transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransactionsRefreshResponse> TransactionsRefreshAsync(TransactionsRefreshRequest body)
        {
            return TransactionsRefreshAsync(body, CancellationToken.None);
        }
    
        /// <summary>Refresh transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransactionsRefreshResponse TransactionsRefresh(TransactionsRefreshRequest body)
        {
            return Task.Run(async () => await TransactionsRefreshAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Refresh transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransactionsRefreshResponse> TransactionsRefreshAsync(TransactionsRefreshRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/refresh");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransactionsRefreshResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get streams of recurring transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransactionsRecurringGetResponse> TransactionsRecurringGetAsync(TransactionsRecurringGetRequest body)
        {
            return TransactionsRecurringGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get streams of recurring transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransactionsRecurringGetResponse TransactionsRecurringGet(TransactionsRecurringGetRequest body)
        {
            return Task.Run(async () => await TransactionsRecurringGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get streams of recurring transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransactionsRecurringGetResponse> TransactionsRecurringGetAsync(TransactionsRecurringGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/recurring/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransactionsRecurringGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get incremental transaction updates on an item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransactionsSyncResponse> TransactionsSyncAsync(TransactionsSyncRequest body)
        {
            return TransactionsSyncAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get incremental transaction updates on an item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransactionsSyncResponse TransactionsSync(TransactionsSyncRequest body)
        {
            return Task.Run(async () => await TransactionsSyncAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get incremental transaction updates on an item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransactionsSyncResponse> TransactionsSyncAsync(TransactionsSyncRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transactions/sync");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransactionsSyncResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get details of all supported institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<InstitutionsGetResponse> InstitutionsGetAsync(InstitutionsGetRequest body)
        {
            return InstitutionsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get details of all supported institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public InstitutionsGetResponse InstitutionsGet(InstitutionsGetRequest body)
        {
            return Task.Run(async () => await InstitutionsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get details of all supported institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<InstitutionsGetResponse> InstitutionsGetAsync(InstitutionsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/institutions/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<InstitutionsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Search institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<InstitutionsSearchResponse> InstitutionsSearchAsync(InstitutionsSearchRequest body)
        {
            return InstitutionsSearchAsync(body, CancellationToken.None);
        }
    
        /// <summary>Search institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public InstitutionsSearchResponse InstitutionsSearch(InstitutionsSearchRequest body)
        {
            return Task.Run(async () => await InstitutionsSearchAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Search institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<InstitutionsSearchResponse> InstitutionsSearchAsync(InstitutionsSearchRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/institutions/search");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<InstitutionsSearchResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get details of an institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<InstitutionsGetByIdResponse> InstitutionsGetByIdAsync(InstitutionsGetByIdRequest body)
        {
            return InstitutionsGetByIdAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get details of an institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public InstitutionsGetByIdResponse InstitutionsGetById(InstitutionsGetByIdRequest body)
        {
            return Task.Run(async () => await InstitutionsGetByIdAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get details of an institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<InstitutionsGetByIdResponse> InstitutionsGetByIdAsync(InstitutionsGetByIdRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/institutions/get_by_id");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<InstitutionsGetByIdResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Remove an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemRemoveResponse> ItemRemoveAsync(ItemRemoveRequest body)
        {
            return ItemRemoveAsync(body, CancellationToken.None);
        }
    
        /// <summary>Remove an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemRemoveResponse ItemRemove(ItemRemoveRequest body)
        {
            return Task.Run(async () => await ItemRemoveAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Remove an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemRemoveResponse> ItemRemoveAsync(ItemRemoveRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/remove");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemRemoveResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve accounts</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AccountsGetResponse> AccountsGetAsync(AccountsGetRequest body)
        {
            return AccountsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve accounts</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AccountsGetResponse AccountsGet(AccountsGetRequest body)
        {
            return Task.Run(async () => await AccountsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve accounts</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AccountsGetResponse> AccountsGetAsync(AccountsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/accounts/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AccountsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get Categories</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<CategoriesGetResponse> CategoriesGetAsync(CategoriesGetRequest body)
        {
            return CategoriesGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get Categories</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public CategoriesGetResponse CategoriesGet(CategoriesGetRequest body)
        {
            return Task.Run(async () => await CategoriesGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get Categories</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<CategoriesGetResponse> CategoriesGetAsync(CategoriesGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/categories/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<CategoriesGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a test Item and processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxProcessorTokenCreateResponse> SandboxProcessorTokenCreateAsync(SandboxProcessorTokenCreateRequest body)
        {
            return SandboxProcessorTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a test Item and processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxProcessorTokenCreateResponse SandboxProcessorTokenCreate(SandboxProcessorTokenCreateRequest body)
        {
            return Task.Run(async () => await SandboxProcessorTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a test Item and processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxProcessorTokenCreateResponse> SandboxProcessorTokenCreateAsync(SandboxProcessorTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/processor_token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxProcessorTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a test Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxPublicTokenCreateResponse> SandboxPublicTokenCreateAsync(SandboxPublicTokenCreateRequest body)
        {
            return SandboxPublicTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a test Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxPublicTokenCreateResponse SandboxPublicTokenCreate(SandboxPublicTokenCreateRequest body)
        {
            return Task.Run(async () => await SandboxPublicTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a test Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxPublicTokenCreateResponse> SandboxPublicTokenCreateAsync(SandboxPublicTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/public_token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxPublicTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Fire a test webhook</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxItemFireWebhookResponse> SandboxItemFireWebhookAsync(SandboxItemFireWebhookRequest body)
        {
            return SandboxItemFireWebhookAsync(body, CancellationToken.None);
        }
    
        /// <summary>Fire a test webhook</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxItemFireWebhookResponse SandboxItemFireWebhook(SandboxItemFireWebhookRequest body)
        {
            return Task.Run(async () => await SandboxItemFireWebhookAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fire a test webhook</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxItemFireWebhookResponse> SandboxItemFireWebhookAsync(SandboxItemFireWebhookRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/item/fire_webhook");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxItemFireWebhookResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve real-time balance data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AccountsGetResponse> AccountsBalanceGetAsync(AccountsBalanceGetRequest body)
        {
            return AccountsBalanceGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve real-time balance data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AccountsGetResponse AccountsBalanceGet(AccountsBalanceGetRequest body)
        {
            return Task.Run(async () => await AccountsBalanceGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve real-time balance data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AccountsGetResponse> AccountsBalanceGetAsync(AccountsBalanceGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/accounts/balance/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AccountsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<IdentityGetResponse> IdentityGetAsync(IdentityGetRequest body)
        {
            return IdentityGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public IdentityGetResponse IdentityGet(IdentityGetRequest body)
        {
            return Task.Run(async () => await IdentityGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<IdentityGetResponse> IdentityGetAsync(IdentityGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/identity/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IdentityGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve Auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorAuthGetResponse> ProcessorAuthGetAsync(ProcessorAuthGetRequest body)
        {
            return ProcessorAuthGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve Auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorAuthGetResponse ProcessorAuthGet(ProcessorAuthGetRequest body)
        {
            return Task.Run(async () => await ProcessorAuthGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve Auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorAuthGetResponse> ProcessorAuthGetAsync(ProcessorAuthGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/auth/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorAuthGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a bank transfer as a processor</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorBankTransferCreateResponse> ProcessorBankTransferCreateAsync(ProcessorBankTransferCreateRequest body)
        {
            return ProcessorBankTransferCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a bank transfer as a processor</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorBankTransferCreateResponse ProcessorBankTransferCreate(ProcessorBankTransferCreateRequest body)
        {
            return Task.Run(async () => await ProcessorBankTransferCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a bank transfer as a processor</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorBankTransferCreateResponse> ProcessorBankTransferCreateAsync(ProcessorBankTransferCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/bank_transfer/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorBankTransferCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve Identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorIdentityGetResponse> ProcessorIdentityGetAsync(ProcessorIdentityGetRequest body)
        {
            return ProcessorIdentityGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve Identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorIdentityGetResponse ProcessorIdentityGet(ProcessorIdentityGetRequest body)
        {
            return Task.Run(async () => await ProcessorIdentityGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve Identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorIdentityGetResponse> ProcessorIdentityGetAsync(ProcessorIdentityGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/identity/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorIdentityGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve Balance data</summary>
        /// <param name="body">The `/processor/balance/get` endpoint returns the real-time balance for the account associated with a given `processor_token`.
        /// <br/>
        /// <br/>The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
        /// <br/>
        /// <br/>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of `null`.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorBalanceGetResponse> ProcessorBalanceGetAsync(ProcessorBalanceGetRequest body)
        {
            return ProcessorBalanceGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve Balance data</summary>
        /// <param name="body">The `/processor/balance/get` endpoint returns the real-time balance for the account associated with a given `processor_token`.
        /// <br/>
        /// <br/>The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
        /// <br/>
        /// <br/>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of `null`.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorBalanceGetResponse ProcessorBalanceGet(ProcessorBalanceGetRequest body)
        {
            return Task.Run(async () => await ProcessorBalanceGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve Balance data</summary>
        /// <param name="body">The `/processor/balance/get` endpoint returns the real-time balance for the account associated with a given `processor_token`.
        /// <br/>
        /// <br/>The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
        /// <br/>
        /// <br/>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of `null`.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorBalanceGetResponse> ProcessorBalanceGetAsync(ProcessorBalanceGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/balance/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorBalanceGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Update Webhook URL</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemWebhookUpdateResponse> ItemWebhookUpdateAsync(ItemWebhookUpdateRequest body)
        {
            return ItemWebhookUpdateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Update Webhook URL</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemWebhookUpdateResponse ItemWebhookUpdate(ItemWebhookUpdateRequest body)
        {
            return Task.Run(async () => await ItemWebhookUpdateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update Webhook URL</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemWebhookUpdateResponse> ItemWebhookUpdateAsync(ItemWebhookUpdateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/webhook/update");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemWebhookUpdateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Invalidate access_token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemAccessTokenInvalidateResponse> ItemAccessTokenInvalidateAsync(ItemAccessTokenInvalidateRequest body)
        {
            return ItemAccessTokenInvalidateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Invalidate access_token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemAccessTokenInvalidateResponse ItemAccessTokenInvalidate(ItemAccessTokenInvalidateRequest body)
        {
            return Task.Run(async () => await ItemAccessTokenInvalidateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Invalidate access_token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemAccessTokenInvalidateResponse> ItemAccessTokenInvalidateAsync(ItemAccessTokenInvalidateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/access_token/invalidate");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemAccessTokenInvalidateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get webhook verification key</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<WebhookVerificationKeyGetResponse> WebhookVerificationKeyGetAsync(WebhookVerificationKeyGetRequest body)
        {
            return WebhookVerificationKeyGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get webhook verification key</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public WebhookVerificationKeyGetResponse WebhookVerificationKeyGet(WebhookVerificationKeyGetRequest body)
        {
            return Task.Run(async () => await WebhookVerificationKeyGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get webhook verification key</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<WebhookVerificationKeyGetResponse> WebhookVerificationKeyGetAsync(WebhookVerificationKeyGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/webhook_verification_key/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<WebhookVerificationKeyGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve Liabilities data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<LiabilitiesGetResponse> LiabilitiesGetAsync(LiabilitiesGetRequest body)
        {
            return LiabilitiesGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve Liabilities data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public LiabilitiesGetResponse LiabilitiesGet(LiabilitiesGetRequest body)
        {
            return Task.Run(async () => await LiabilitiesGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve Liabilities data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<LiabilitiesGetResponse> LiabilitiesGetAsync(LiabilitiesGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/liabilities/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<LiabilitiesGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationRecipientCreateResponse> PaymentInitiationRecipientCreateAsync(PaymentInitiationRecipientCreateRequest body)
        {
            return PaymentInitiationRecipientCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationRecipientCreateResponse PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateRequest body)
        {
            return Task.Run(async () => await PaymentInitiationRecipientCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationRecipientCreateResponse> PaymentInitiationRecipientCreateAsync(PaymentInitiationRecipientCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/recipient/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationRecipientCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Reverse an existing payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationPaymentReverseResponse> PaymentInitiationPaymentReverseAsync(PaymentInitiationPaymentReverseRequest body)
        {
            return PaymentInitiationPaymentReverseAsync(body, CancellationToken.None);
        }
    
        /// <summary>Reverse an existing payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationPaymentReverseResponse PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseRequest body)
        {
            return Task.Run(async () => await PaymentInitiationPaymentReverseAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Reverse an existing payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationPaymentReverseResponse> PaymentInitiationPaymentReverseAsync(PaymentInitiationPaymentReverseRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/payment/reverse");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationPaymentReverseResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationRecipientGetResponse> PaymentInitiationRecipientGetAsync(PaymentInitiationRecipientGetRequest body)
        {
            return PaymentInitiationRecipientGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationRecipientGetResponse PaymentInitiationRecipientGet(PaymentInitiationRecipientGetRequest body)
        {
            return Task.Run(async () => await PaymentInitiationRecipientGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationRecipientGetResponse> PaymentInitiationRecipientGetAsync(PaymentInitiationRecipientGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/recipient/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationRecipientGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List payment recipients</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationRecipientListResponse> PaymentInitiationRecipientListAsync(PaymentInitiationRecipientListRequest body)
        {
            return PaymentInitiationRecipientListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List payment recipients</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationRecipientListResponse PaymentInitiationRecipientList(PaymentInitiationRecipientListRequest body)
        {
            return Task.Run(async () => await PaymentInitiationRecipientListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List payment recipients</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationRecipientListResponse> PaymentInitiationRecipientListAsync(PaymentInitiationRecipientListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/recipient/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationRecipientListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationPaymentCreateResponse> PaymentInitiationPaymentCreateAsync(PaymentInitiationPaymentCreateRequest body)
        {
            return PaymentInitiationPaymentCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationPaymentCreateResponse PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateRequest body)
        {
            return Task.Run(async () => await PaymentInitiationPaymentCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationPaymentCreateResponse> PaymentInitiationPaymentCreateAsync(PaymentInitiationPaymentCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/payment/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationPaymentCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create payment token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public Task<PaymentInitiationPaymentTokenCreateResponse> CreatePaymentTokenAsync(PaymentInitiationPaymentTokenCreateRequest body)
        {
            return CreatePaymentTokenAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create payment token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public PaymentInitiationPaymentTokenCreateResponse CreatePaymentToken(PaymentInitiationPaymentTokenCreateRequest body)
        {
            return Task.Run(async () => await CreatePaymentTokenAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create payment token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public async Task<PaymentInitiationPaymentTokenCreateResponse> CreatePaymentTokenAsync(PaymentInitiationPaymentTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/payment/token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationPaymentTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Force a Sandbox Item into an error state</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxItemResetLoginResponse> SandboxItemResetLoginAsync(SandboxItemResetLoginRequest body)
        {
            return SandboxItemResetLoginAsync(body, CancellationToken.None);
        }
    
        /// <summary>Force a Sandbox Item into an error state</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxItemResetLoginResponse SandboxItemResetLogin(SandboxItemResetLoginRequest body)
        {
            return Task.Run(async () => await SandboxItemResetLoginAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Force a Sandbox Item into an error state</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxItemResetLoginResponse> SandboxItemResetLoginAsync(SandboxItemResetLoginRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/item/reset_login");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxItemResetLoginResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Set verification status for Sandbox account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxItemSetVerificationStatusResponse> SandboxItemSetVerificationStatusAsync(SandboxItemSetVerificationStatusRequest body)
        {
            return SandboxItemSetVerificationStatusAsync(body, CancellationToken.None);
        }
    
        /// <summary>Set verification status for Sandbox account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxItemSetVerificationStatusResponse SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusRequest body)
        {
            return Task.Run(async () => await SandboxItemSetVerificationStatusAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Set verification status for Sandbox account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxItemSetVerificationStatusResponse> SandboxItemSetVerificationStatusAsync(SandboxItemSetVerificationStatusRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/item/set_verification_status");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxItemSetVerificationStatusResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Exchange public token for an access token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemPublicTokenExchangeResponse> ItemPublicTokenExchangeAsync(ItemPublicTokenExchangeRequest body)
        {
            return ItemPublicTokenExchangeAsync(body, CancellationToken.None);
        }
    
        /// <summary>Exchange public token for an access token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemPublicTokenExchangeResponse ItemPublicTokenExchange(ItemPublicTokenExchangeRequest body)
        {
            return Task.Run(async () => await ItemPublicTokenExchangeAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Exchange public token for an access token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemPublicTokenExchangeResponse> ItemPublicTokenExchangeAsync(ItemPublicTokenExchangeRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/public_token/exchange");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemPublicTokenExchangeResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create public token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemPublicTokenCreateResponse> ItemCreatePublicTokenAsync(ItemPublicTokenCreateRequest body)
        {
            return ItemCreatePublicTokenAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create public token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemPublicTokenCreateResponse ItemCreatePublicToken(ItemPublicTokenCreateRequest body)
        {
            return Task.Run(async () => await ItemCreatePublicTokenAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create public token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemPublicTokenCreateResponse> ItemCreatePublicTokenAsync(ItemPublicTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/public_token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemPublicTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get payment details</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationPaymentGetResponse> PaymentInitiationPaymentGetAsync(PaymentInitiationPaymentGetRequest body)
        {
            return PaymentInitiationPaymentGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get payment details</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationPaymentGetResponse PaymentInitiationPaymentGet(PaymentInitiationPaymentGetRequest body)
        {
            return Task.Run(async () => await PaymentInitiationPaymentGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get payment details</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationPaymentGetResponse> PaymentInitiationPaymentGetAsync(PaymentInitiationPaymentGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/payment/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationPaymentGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List payments</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<PaymentInitiationPaymentListResponse> PaymentInitiationPaymentListAsync(PaymentInitiationPaymentListRequest body)
        {
            return PaymentInitiationPaymentListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List payments</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public PaymentInitiationPaymentListResponse PaymentInitiationPaymentList(PaymentInitiationPaymentListRequest body)
        {
            return Task.Run(async () => await PaymentInitiationPaymentListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List payments</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<PaymentInitiationPaymentListResponse> PaymentInitiationPaymentListAsync(PaymentInitiationPaymentListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/payment_initiation/payment/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<PaymentInitiationPaymentListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportCreateResponse> AssetReportCreateAsync(AssetReportCreateRequest body)
        {
            return AssetReportCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportCreateResponse AssetReportCreate(AssetReportCreateRequest body)
        {
            return Task.Run(async () => await AssetReportCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportCreateResponse> AssetReportCreateAsync(AssetReportCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Refresh an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportRefreshResponse> AssetReportRefreshAsync(AssetReportRefreshRequest body)
        {
            return AssetReportRefreshAsync(body, CancellationToken.None);
        }
    
        /// <summary>Refresh an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportRefreshResponse AssetReportRefresh(AssetReportRefreshRequest body)
        {
            return Task.Run(async () => await AssetReportRefreshAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Refresh an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportRefreshResponse> AssetReportRefreshAsync(AssetReportRefreshRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/refresh");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportRefreshResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Delete an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportRemoveResponse> AssetReportRemoveAsync(AssetReportRemoveRequest body)
        {
            return AssetReportRemoveAsync(body, CancellationToken.None);
        }
    
        /// <summary>Delete an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportRemoveResponse AssetReportRemove(AssetReportRemoveRequest body)
        {
            return Task.Run(async () => await AssetReportRemoveAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Delete an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportRemoveResponse> AssetReportRemoveAsync(AssetReportRemoveRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/remove");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportRemoveResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Filter Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportFilterResponse> AssetReportFilterAsync(AssetReportFilterRequest body)
        {
            return AssetReportFilterAsync(body, CancellationToken.None);
        }
    
        /// <summary>Filter Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportFilterResponse AssetReportFilter(AssetReportFilterRequest body)
        {
            return Task.Run(async () => await AssetReportFilterAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Filter Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportFilterResponse> AssetReportFilterAsync(AssetReportFilterRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/filter");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportFilterResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportGetResponse> AssetReportGetAsync(AssetReportGetRequest body)
        {
            return AssetReportGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportGetResponse AssetReportGet(AssetReportGetRequest body)
        {
            return Task.Run(async () => await AssetReportGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportGetResponse> AssetReportGetAsync(AssetReportGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve a PDF Asset Report</summary>
        /// <returns>A PDF of the Asset Report</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<FileResponse> AssetReportPdfGetAsync(AssetReportPDFGetRequest body)
        {
            return AssetReportPdfGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve a PDF Asset Report</summary>
        /// <returns>A PDF of the Asset Report</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public FileResponse AssetReportPdfGet(AssetReportPDFGetRequest body)
        {
            return Task.Run(async () => await AssetReportPdfGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a PDF Asset Report</summary>
        /// <returns>A PDF of the Asset Report</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<FileResponse> AssetReportPdfGetAsync(AssetReportPDFGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/pdf/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/pdf"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200 || status == 206)
                        {
                            var responseStream = response.Content == null ? System.IO.Stream.Null : await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            var fileResponse = new FileResponse(status, headers, responseStream, null, response); 
                            disposeClient = false; disposeResponse = false; // response and client are disposed by FileResponse
                            return fileResponse;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportAuditCopyCreateResponse> AssetReportAuditCopyCreateAsync(AssetReportAuditCopyCreateRequest body)
        {
            return AssetReportAuditCopyCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportAuditCopyCreateResponse AssetReportAuditCopyCreate(AssetReportAuditCopyCreateRequest body)
        {
            return Task.Run(async () => await AssetReportAuditCopyCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportAuditCopyCreateResponse> AssetReportAuditCopyCreateAsync(AssetReportAuditCopyCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/audit_copy/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportAuditCopyCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Remove Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportAuditCopyRemoveResponse> AssetReportAuditCopyRemoveAsync(AssetReportAuditCopyRemoveRequest body)
        {
            return AssetReportAuditCopyRemoveAsync(body, CancellationToken.None);
        }
    
        /// <summary>Remove Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportAuditCopyRemoveResponse AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveRequest body)
        {
            return Task.Run(async () => await AssetReportAuditCopyRemoveAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Remove Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportAuditCopyRemoveResponse> AssetReportAuditCopyRemoveAsync(AssetReportAuditCopyRemoveRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/audit_copy/remove");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportAuditCopyRemoveResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get Investment holdings</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<InvestmentsHoldingsGetResponse> InvestmentsHoldingsGetAsync(InvestmentsHoldingsGetRequest body)
        {
            return InvestmentsHoldingsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get Investment holdings</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public InvestmentsHoldingsGetResponse InvestmentsHoldingsGet(InvestmentsHoldingsGetRequest body)
        {
            return Task.Run(async () => await InvestmentsHoldingsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get Investment holdings</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<InvestmentsHoldingsGetResponse> InvestmentsHoldingsGetAsync(InvestmentsHoldingsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/investments/holdings/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<InvestmentsHoldingsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get investment transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<InvestmentsTransactionsGetResponse> InvestmentsTransactionsGetAsync(InvestmentsTransactionsGetRequest body)
        {
            return InvestmentsTransactionsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get investment transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public InvestmentsTransactionsGetResponse InvestmentsTransactionsGet(InvestmentsTransactionsGetRequest body)
        {
            return Task.Run(async () => await InvestmentsTransactionsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get investment transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<InvestmentsTransactionsGetResponse> InvestmentsTransactionsGetAsync(InvestmentsTransactionsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/investments/transactions/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<InvestmentsTransactionsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorTokenCreateResponse> ProcessorTokenCreateAsync(ProcessorTokenCreateRequest body)
        {
            return ProcessorTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorTokenCreateResponse ProcessorTokenCreate(ProcessorTokenCreateRequest body)
        {
            return Task.Run(async () => await ProcessorTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorTokenCreateResponse> ProcessorTokenCreateAsync(ProcessorTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create Stripe bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreateAsync(ProcessorStripeBankAccountTokenCreateRequest body)
        {
            return ProcessorStripeBankAccountTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create Stripe bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorStripeBankAccountTokenCreateResponse ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateRequest body)
        {
            return Task.Run(async () => await ProcessorStripeBankAccountTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create Stripe bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreateAsync(ProcessorStripeBankAccountTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/stripe/bank_account_token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorStripeBankAccountTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create Apex bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreateAsync(ProcessorApexProcessorTokenCreateRequest body)
        {
            return ProcessorApexProcessorTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create Apex bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ProcessorTokenCreateResponse ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateRequest body)
        {
            return Task.Run(async () => await ProcessorApexProcessorTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create Apex bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreateAsync(ProcessorApexProcessorTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/processor/apex/processor_token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ProcessorTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<DepositSwitchCreateResponse> DepositSwitchCreateAsync(DepositSwitchCreateRequest body)
        {
            return DepositSwitchCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public DepositSwitchCreateResponse DepositSwitchCreate(DepositSwitchCreateRequest body)
        {
            return Task.Run(async () => await DepositSwitchCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<DepositSwitchCreateResponse> DepositSwitchCreateAsync(DepositSwitchCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/deposit_switch/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<DepositSwitchCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Import Item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ItemImportResponse> ItemImportAsync(ItemImportRequest body)
        {
            return ItemImportAsync(body, CancellationToken.None);
        }
    
        /// <summary>Import Item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public ItemImportResponse ItemImport(ItemImportRequest body)
        {
            return Task.Run(async () => await ItemImportAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Import Item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ItemImportResponse> ItemImportAsync(ItemImportRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/item/import");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<ItemImportResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a deposit switch token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<DepositSwitchTokenCreateResponse> DepositSwitchTokenCreateAsync(DepositSwitchTokenCreateRequest body)
        {
            return DepositSwitchTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a deposit switch token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public DepositSwitchTokenCreateResponse DepositSwitchTokenCreate(DepositSwitchTokenCreateRequest body)
        {
            return Task.Run(async () => await DepositSwitchTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a deposit switch token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<DepositSwitchTokenCreateResponse> DepositSwitchTokenCreateAsync(DepositSwitchTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/deposit_switch/token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<DepositSwitchTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<LinkTokenCreateResponse> LinkTokenCreateAsync(LinkTokenCreateRequest body)
        {
            return LinkTokenCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public LinkTokenCreateResponse LinkTokenCreate(LinkTokenCreateRequest body)
        {
            return Task.Run(async () => await LinkTokenCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<LinkTokenCreateResponse> LinkTokenCreateAsync(LinkTokenCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/link/token/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<LinkTokenCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<LinkTokenGetResponse> LinkTokenGetAsync(LinkTokenGetRequest body)
        {
            return LinkTokenGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public LinkTokenGetResponse LinkTokenGet(LinkTokenGetRequest body)
        {
            return Task.Run(async () => await LinkTokenGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<LinkTokenGetResponse> LinkTokenGetAsync(LinkTokenGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/link/token/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<LinkTokenGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve an Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<AssetReportGetResponse> AssetReportAuditCopyGetAsync(AssetReportAuditCopyGetRequest body)
        {
            return AssetReportAuditCopyGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve an Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public AssetReportGetResponse AssetReportAuditCopyGet(AssetReportAuditCopyGetRequest body)
        {
            return Task.Run(async () => await AssetReportAuditCopyGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve an Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<AssetReportGetResponse> AssetReportAuditCopyGetAsync(AssetReportAuditCopyGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/asset_report/audit_copy/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<AssetReportGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<DepositSwitchGetResponse> DepositSwitchGetAsync(DepositSwitchGetRequest body)
        {
            return DepositSwitchGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public DepositSwitchGetResponse DepositSwitchGet(DepositSwitchGetRequest body)
        {
            return Task.Run(async () => await DepositSwitchGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<DepositSwitchGetResponse> DepositSwitchGetAsync(DepositSwitchGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/deposit_switch/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<DepositSwitchGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferGetResponse> TransferGetAsync(TransferGetRequest body)
        {
            return TransferGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferGetResponse TransferGet(TransferGetRequest body)
        {
            return Task.Run(async () => await TransferGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferGetResponse> TransferGetAsync(TransferGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferGetResponse> BankTransferGetAsync(BankTransferGetRequest body)
        {
            return BankTransferGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferGetResponse BankTransferGet(BankTransferGetRequest body)
        {
            return Task.Run(async () => await BankTransferGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferGetResponse> BankTransferGetAsync(BankTransferGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a transfer authorization</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferAuthorizationCreateResponse> TransferAuthorizationCreateAsync(TransferAuthorizationCreateRequest body)
        {
            return TransferAuthorizationCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a transfer authorization</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferAuthorizationCreateResponse TransferAuthorizationCreate(TransferAuthorizationCreateRequest body)
        {
            return Task.Run(async () => await TransferAuthorizationCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a transfer authorization</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferAuthorizationCreateResponse> TransferAuthorizationCreateAsync(TransferAuthorizationCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/authorization/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferAuthorizationCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferCreateResponse> TransferCreateAsync(TransferCreateRequest body)
        {
            return TransferCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferCreateResponse TransferCreate(TransferCreateRequest body)
        {
            return Task.Run(async () => await TransferCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferCreateResponse> TransferCreateAsync(TransferCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferCreateResponse> BankTransferCreateAsync(BankTransferCreateRequest body)
        {
            return BankTransferCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferCreateResponse BankTransferCreate(BankTransferCreateRequest body)
        {
            return Task.Run(async () => await BankTransferCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferCreateResponse> BankTransferCreateAsync(BankTransferCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferListResponse> TransferListAsync(TransferListRequest body)
        {
            return TransferListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferListResponse TransferList(TransferListRequest body)
        {
            return Task.Run(async () => await TransferListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferListResponse> TransferListAsync(TransferListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List bank transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferListResponse> BankTransferListAsync(BankTransferListRequest body)
        {
            return BankTransferListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List bank transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferListResponse BankTransferList(BankTransferListRequest body)
        {
            return Task.Run(async () => await BankTransferListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List bank transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferListResponse> BankTransferListAsync(BankTransferListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Cancel a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferCancelResponse> TransferCancelAsync(TransferCancelRequest body)
        {
            return TransferCancelAsync(body, CancellationToken.None);
        }
    
        /// <summary>Cancel a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferCancelResponse TransferCancel(TransferCancelRequest body)
        {
            return Task.Run(async () => await TransferCancelAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Cancel a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferCancelResponse> TransferCancelAsync(TransferCancelRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/cancel");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferCancelResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Cancel a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferCancelResponse> BankTransferCancelAsync(BankTransferCancelRequest body)
        {
            return BankTransferCancelAsync(body, CancellationToken.None);
        }
    
        /// <summary>Cancel a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferCancelResponse BankTransferCancel(BankTransferCancelRequest body)
        {
            return Task.Run(async () => await BankTransferCancelAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Cancel a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferCancelResponse> BankTransferCancelAsync(BankTransferCancelRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/cancel");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferCancelResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferEventListResponse> TransferEventListAsync(TransferEventListRequest body)
        {
            return TransferEventListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferEventListResponse TransferEventList(TransferEventListRequest body)
        {
            return Task.Run(async () => await TransferEventListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferEventListResponse> TransferEventListAsync(TransferEventListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/event/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferEventListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferEventListResponse> BankTransferEventListAsync(BankTransferEventListRequest body)
        {
            return BankTransferEventListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferEventListResponse BankTransferEventList(BankTransferEventListRequest body)
        {
            return Task.Run(async () => await BankTransferEventListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferEventListResponse> BankTransferEventListAsync(BankTransferEventListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/event/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferEventListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Sync transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<TransferEventSyncResponse> TransferEventSyncAsync(TransferEventSyncRequest body)
        {
            return TransferEventSyncAsync(body, CancellationToken.None);
        }
    
        /// <summary>Sync transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public TransferEventSyncResponse TransferEventSync(TransferEventSyncRequest body)
        {
            return Task.Run(async () => await TransferEventSyncAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Sync transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<TransferEventSyncResponse> TransferEventSyncAsync(TransferEventSyncRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/transfer/event/sync");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<TransferEventSyncResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Sync bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferEventSyncResponse> BankTransferEventSyncAsync(BankTransferEventSyncRequest body)
        {
            return BankTransferEventSyncAsync(body, CancellationToken.None);
        }
    
        /// <summary>Sync bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferEventSyncResponse BankTransferEventSync(BankTransferEventSyncRequest body)
        {
            return Task.Run(async () => await BankTransferEventSyncAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Sync bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferEventSyncResponse> BankTransferEventSyncAsync(BankTransferEventSyncRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/event/sync");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferEventSyncResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve a sweep</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferSweepGetResponse> BankTransferSweepGetAsync(BankTransferSweepGetRequest body)
        {
            return BankTransferSweepGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve a sweep</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferSweepGetResponse BankTransferSweepGet(BankTransferSweepGetRequest body)
        {
            return Task.Run(async () => await BankTransferSweepGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a sweep</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferSweepGetResponse> BankTransferSweepGetAsync(BankTransferSweepGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/sweep/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferSweepGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>List sweeps</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferSweepListResponse> BankTransferSweepListAsync(BankTransferSweepListRequest body)
        {
            return BankTransferSweepListAsync(body, CancellationToken.None);
        }
    
        /// <summary>List sweeps</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferSweepListResponse BankTransferSweepList(BankTransferSweepListRequest body)
        {
            return Task.Run(async () => await BankTransferSweepListAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>List sweeps</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferSweepListResponse> BankTransferSweepListAsync(BankTransferSweepListRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/sweep/list");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferSweepListResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Get balance of your Bank Transfer account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferBalanceGetResponse> BankTransferBalanceGetAsync(BankTransferBalanceGetRequest body)
        {
            return BankTransferBalanceGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Get balance of your Bank Transfer account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferBalanceGetResponse BankTransferBalanceGet(BankTransferBalanceGetRequest body)
        {
            return Task.Run(async () => await BankTransferBalanceGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get balance of your Bank Transfer account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferBalanceGetResponse> BankTransferBalanceGetAsync(BankTransferBalanceGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/balance/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferBalanceGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Migrate account into Bank Transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BankTransferMigrateAccountResponse> BankTransferMigrateAccountAsync(BankTransferMigrateAccountRequest body)
        {
            return BankTransferMigrateAccountAsync(body, CancellationToken.None);
        }
    
        /// <summary>Migrate account into Bank Transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public BankTransferMigrateAccountResponse BankTransferMigrateAccount(BankTransferMigrateAccountRequest body)
        {
            return Task.Run(async () => await BankTransferMigrateAccountAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Migrate account into Bank Transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BankTransferMigrateAccountResponse> BankTransferMigrateAccountAsync(BankTransferMigrateAccountRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/bank_transfer/migrate_account");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<BankTransferMigrateAccountResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Simulate a bank transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxBankTransferSimulateResponse> SandboxBankTransferSimulateAsync(SandboxBankTransferSimulateRequest body)
        {
            return SandboxBankTransferSimulateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Simulate a bank transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxBankTransferSimulateResponse SandboxBankTransferSimulate(SandboxBankTransferSimulateRequest body)
        {
            return Task.Run(async () => await SandboxBankTransferSimulateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulate a bank transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxBankTransferSimulateResponse> SandboxBankTransferSimulateAsync(SandboxBankTransferSimulateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/bank_transfer/simulate");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxBankTransferSimulateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Simulate a transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxTransferSimulateResponse> SandboxTransferSimulateAsync(SandboxTransferSimulateRequest body)
        {
            return SandboxTransferSimulateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Simulate a transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxTransferSimulateResponse SandboxTransferSimulate(SandboxTransferSimulateRequest body)
        {
            return Task.Run(async () => await SandboxTransferSimulateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Simulate a transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxTransferSimulateResponse> SandboxTransferSimulateAsync(SandboxTransferSimulateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/transfer/simulate");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxTransferSimulateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Search employer database</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<EmployersSearchResponse> EmployersSearchAsync(EmployersSearchRequest body)
        {
            return EmployersSearchAsync(body, CancellationToken.None);
        }
    
        /// <summary>Search employer database</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public EmployersSearchResponse EmployersSearch(EmployersSearchRequest body)
        {
            return Task.Run(async () => await EmployersSearchAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Search employer database</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<EmployersSearchResponse> EmployersSearchAsync(EmployersSearchRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/employers/search");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<EmployersSearchResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>(Deprecated) Create an income verification instance</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public Task<IncomeVerificationCreateResponse> IncomeVerificationCreateAsync(IncomeVerificationCreateRequest body)
        {
            return IncomeVerificationCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>(Deprecated) Create an income verification instance</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public IncomeVerificationCreateResponse IncomeVerificationCreate(IncomeVerificationCreateRequest body)
        {
            return Task.Run(async () => await IncomeVerificationCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>(Deprecated) Create an income verification instance</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public async Task<IncomeVerificationCreateResponse> IncomeVerificationCreateAsync(IncomeVerificationCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>(Deprecated) Retrieve a summary of information derived from income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<IncomeVerificationSummaryGetResponse> IncomeVerificationSummaryGetAsync(IncomeVerificationSummaryGetRequest body)
        {
            return IncomeVerificationSummaryGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>(Deprecated) Retrieve a summary of information derived from income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public IncomeVerificationSummaryGetResponse IncomeVerificationSummaryGet(IncomeVerificationSummaryGetRequest body)
        {
            return Task.Run(async () => await IncomeVerificationSummaryGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>(Deprecated) Retrieve a summary of information derived from income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<IncomeVerificationSummaryGetResponse> IncomeVerificationSummaryGetAsync(IncomeVerificationSummaryGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/summary/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationSummaryGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>(Deprecated) Retrieve information from a single paystub used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public Task<IncomeVerificationPaystubGetResponse> IncomeVerificationPaystubGetAsync(IncomeVerificationPaystubGetRequest body)
        {
            return IncomeVerificationPaystubGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>(Deprecated) Retrieve information from a single paystub used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public IncomeVerificationPaystubGetResponse IncomeVerificationPaystubGet(IncomeVerificationPaystubGetRequest body)
        {
            return Task.Run(async () => await IncomeVerificationPaystubGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>(Deprecated) Retrieve information from a single paystub used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        public async Task<IncomeVerificationPaystubGetResponse> IncomeVerificationPaystubGetAsync(IncomeVerificationPaystubGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/paystub/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationPaystubGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve information from the paystubs used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<IncomeVerificationPaystubsGetResponse> IncomeVerificationPaystubsGetAsync(IncomeVerificationPaystubsGetRequest body)
        {
            return IncomeVerificationPaystubsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve information from the paystubs used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public IncomeVerificationPaystubsGetResponse IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetRequest body)
        {
            return Task.Run(async () => await IncomeVerificationPaystubsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve information from the paystubs used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<IncomeVerificationPaystubsGetResponse> IncomeVerificationPaystubsGetAsync(IncomeVerificationPaystubsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/paystubs/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationPaystubsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Download the original documents used for income verification</summary>
        /// <returns>A ZIP file containing source documents(s) used as the basis for income verification.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<FileResponse> IncomeVerificationDocumentsDownloadAsync(IncomeVerificationDocumentsDownloadRequest body)
        {
            return IncomeVerificationDocumentsDownloadAsync(body, CancellationToken.None);
        }
    
        /// <summary>Download the original documents used for income verification</summary>
        /// <returns>A ZIP file containing source documents(s) used as the basis for income verification.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public FileResponse IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadRequest body)
        {
            return Task.Run(async () => await IncomeVerificationDocumentsDownloadAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Download the original documents used for income verification</summary>
        /// <returns>A ZIP file containing source documents(s) used as the basis for income verification.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<FileResponse> IncomeVerificationDocumentsDownloadAsync(IncomeVerificationDocumentsDownloadRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/documents/download");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/zip"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200 || status == 206)
                        {
                            var responseStream = response.Content == null ? System.IO.Stream.Null : await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            var fileResponse = new FileResponse(status, headers, responseStream, null, response); 
                            disposeClient = false; disposeResponse = false; // response and client are disposed by FileResponse
                            return fileResponse;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Refresh an income verification</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<IncomeVerificationRefreshResponse> IncomeVerificationRefreshAsync(IncomeVerificationRefreshRequest body)
        {
            return IncomeVerificationRefreshAsync(body, CancellationToken.None);
        }
    
        /// <summary>Refresh an income verification</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public IncomeVerificationRefreshResponse IncomeVerificationRefresh(IncomeVerificationRefreshRequest body)
        {
            return Task.Run(async () => await IncomeVerificationRefreshAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Refresh an income verification</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<IncomeVerificationRefreshResponse> IncomeVerificationRefreshAsync(IncomeVerificationRefreshRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/refresh");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationRefreshResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve information from the tax documents used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<IncomeVerificationTaxformsGetResponse> IncomeVerificationTaxformsGetAsync(IncomeVerificationTaxformsGetRequest body)
        {
            return IncomeVerificationTaxformsGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve information from the tax documents used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public IncomeVerificationTaxformsGetResponse IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetRequest body)
        {
            return Task.Run(async () => await IncomeVerificationTaxformsGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve information from the tax documents used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<IncomeVerificationTaxformsGetResponse> IncomeVerificationTaxformsGetAsync(IncomeVerificationTaxformsGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/taxforms/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationTaxformsGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Check a user's eligibility for the income verification product</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<IncomeVerificationPrecheckResponse> IncomeVerificationPrecheckAsync(IncomeVerificationPrecheckRequest body)
        {
            return IncomeVerificationPrecheckAsync(body, CancellationToken.None);
        }
    
        /// <summary>Check a user's eligibility for the income verification product</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public IncomeVerificationPrecheckResponse IncomeVerificationPrecheck(IncomeVerificationPrecheckRequest body)
        {
            return Task.Run(async () => await IncomeVerificationPrecheckAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Check a user's eligibility for the income verification product</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<IncomeVerificationPrecheckResponse> IncomeVerificationPrecheckAsync(IncomeVerificationPrecheckRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/income/verification/precheck");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<IncomeVerificationPrecheckResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Retrieve a summary of an individual's employment information.</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<EmploymentVerificationGetResponse> EmploymentVerificationGetAsync(EmploymentVerificationGetRequest body)
        {
            return EmploymentVerificationGetAsync(body, CancellationToken.None);
        }
    
        /// <summary>Retrieve a summary of an individual's employment information.</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public EmploymentVerificationGetResponse EmploymentVerificationGet(EmploymentVerificationGetRequest body)
        {
            return Task.Run(async () => await EmploymentVerificationGetAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieve a summary of an individual's employment information.</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<EmploymentVerificationGetResponse> EmploymentVerificationGetAsync(EmploymentVerificationGetRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/employment/verification/get");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<EmploymentVerificationGetResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Create a deposit switch without using Plaid Exchange</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<DepositSwitchAltCreateResponse> DepositSwitchAltCreateAsync(DepositSwitchAltCreateRequest body)
        {
            return DepositSwitchAltCreateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Create a deposit switch without using Plaid Exchange</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public DepositSwitchAltCreateResponse DepositSwitchAltCreate(DepositSwitchAltCreateRequest body)
        {
            return Task.Run(async () => await DepositSwitchAltCreateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Create a deposit switch without using Plaid Exchange</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<DepositSwitchAltCreateResponse> DepositSwitchAltCreateAsync(DepositSwitchAltCreateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/deposit_switch/alt/create");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<DepositSwitchAltCreateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Manually fire a Bank Transfer webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxBankTransferFireWebhookResponse> SandboxBankTransferFireWebhookAsync(SandboxBankTransferFireWebhookRequest body)
        {
            return SandboxBankTransferFireWebhookAsync(body, CancellationToken.None);
        }
    
        /// <summary>Manually fire a Bank Transfer webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxBankTransferFireWebhookResponse SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookRequest body)
        {
            return Task.Run(async () => await SandboxBankTransferFireWebhookAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Manually fire a Bank Transfer webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxBankTransferFireWebhookResponse> SandboxBankTransferFireWebhookAsync(SandboxBankTransferFireWebhookRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/bank_transfer/fire_webhook");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxBankTransferFireWebhookResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Manually fire an Income webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxIncomeFireWebhookResponse> SandboxIncomeFireWebhookAsync(SandboxIncomeFireWebhookRequest body)
        {
            return SandboxIncomeFireWebhookAsync(body, CancellationToken.None);
        }
    
        /// <summary>Manually fire an Income webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxIncomeFireWebhookResponse SandboxIncomeFireWebhook(SandboxIncomeFireWebhookRequest body)
        {
            return Task.Run(async () => await SandboxIncomeFireWebhookAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Manually fire an Income webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxIncomeFireWebhookResponse> SandboxIncomeFireWebhookAsync(SandboxIncomeFireWebhookRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/income/fire_webhook");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxIncomeFireWebhookResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Save the selected accounts when connecting to the Platypus Oauth institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SandboxOauthSelectAccountsResponse> SandboxOauthSelectAccountsAsync(SandboxOauthSelectAccountsRequest body)
        {
            return SandboxOauthSelectAccountsAsync(body, CancellationToken.None);
        }
    
        /// <summary>Save the selected accounts when connecting to the Platypus Oauth institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SandboxOauthSelectAccountsResponse SandboxOauthSelectAccounts(SandboxOauthSelectAccountsRequest body)
        {
            return Task.Run(async () => await SandboxOauthSelectAccountsAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Save the selected accounts when connecting to the Platypus Oauth institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SandboxOauthSelectAccountsResponse> SandboxOauthSelectAccountsAsync(SandboxOauthSelectAccountsRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/sandbox/oauth/select_accounts");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SandboxOauthSelectAccountsResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Evaluate a planned ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SignalEvaluateResponse> SignalEvaluateAsync(SignalEvaluateRequest body)
        {
            return SignalEvaluateAsync(body, CancellationToken.None);
        }
    
        /// <summary>Evaluate a planned ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SignalEvaluateResponse SignalEvaluate(SignalEvaluateRequest body)
        {
            return Task.Run(async () => await SignalEvaluateAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Evaluate a planned ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SignalEvaluateResponse> SignalEvaluateAsync(SignalEvaluateRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/signal/evaluate");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SignalEvaluateResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Report whether you initiated an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SignalDecisionReportResponse> SignalDecisionReportAsync(SignalDecisionReportRequest body)
        {
            return SignalDecisionReportAsync(body, CancellationToken.None);
        }
    
        /// <summary>Report whether you initiated an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SignalDecisionReportResponse SignalDecisionReport(SignalDecisionReportRequest body)
        {
            return Task.Run(async () => await SignalDecisionReportAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Report whether you initiated an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SignalDecisionReportResponse> SignalDecisionReportAsync(SignalDecisionReportRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/signal/decision/report");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SignalDecisionReportResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        /// <summary>Report a return for an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<SignalReturnReportResponse> SignalReturnReportAsync(SignalReturnReportRequest body)
        {
            return SignalReturnReportAsync(body, CancellationToken.None);
        }
    
        /// <summary>Report a return for an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public SignalReturnReportResponse SignalReturnReport(SignalReturnReportRequest body)
        {
            return Task.Run(async () => await SignalReturnReportAsync(body, CancellationToken.None)).GetAwaiter().GetResult();
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Report a return for an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<SignalReturnReportResponse> SignalReturnReportAsync(SignalReturnReportRequest body, CancellationToken cancellationToken)
        {
            if (body == null)
                throw new System.ArgumentNullException("body");
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/signal/return/report");
    
            var client = _httpClient;
            var disposeClient = false;
            try
            {
                using (var request = new HttpRequestMessage())
                {
                    var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                    content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request.Content = content;
                    request.Method = new HttpMethod("POST");
                    request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client, request, urlBuilder);
    
                    var url = urlBuilder.ToString();
                    request.RequestUri = new System.Uri(url, System.UriKind.RelativeOrAbsolute);
    
                    PrepareRequest(client, request, url);
    
                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse = true;
                    try
                    {
                        var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                        if (response.Content != null && response.Content.Headers != null)
                        {
                            foreach (var item in response.Content.Headers)
                                headers[item.Key] = item.Value;
                        }
    
                        ProcessResponse(client, response);
    
                        var status = (int)response.StatusCode;
                        if (status == 200)
                        {
                            var objectResponse = await ReadObjectResponseAsync<SignalReturnReportResponse>(response, headers, cancellationToken).ConfigureAwait(false);
                            if (objectResponse.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status, objectResponse.Text, headers, null);
                            }
                            return objectResponse.Object;
                        }
                        else
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers, cancellationToken).ConfigureAwait(false);
                            throw new ApiException<Error>("Error response.", status, objectResponse.Text, headers, objectResponse.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse)
                            response.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient)
                    client.Dispose();
            }
        }
    
        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                Object = responseObject;
                Text = responseText;
            }
    
            public T Object { get; }
    
            public string Text { get; }
        }
    
        public bool ReadResponseAsString { get; set; }
        
        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, CancellationToken cancellationToken)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }
        
            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }
    
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }
        
            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
        
                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool) 
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
}
}