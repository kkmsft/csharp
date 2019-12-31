using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using k8s;
using k8s.Models;

namespace watch
{
    public class ListWatcher : ServiceClient<Kubernetes>
    {
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        public void InitSerialization() {

                SerializationSettings = new JsonSerializerSettings
                    {
                        Formatting = Newtonsoft.Json.Formatting.Indented,
                        DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                        DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                        ContractResolver = new ReadOnlyJsonContractResolver(),
                        Converters = new  List<JsonConverter>
                            {
                                new Iso8601TimeSpanConverter()
                            }
                    };
                    DeserializationSettings = new JsonSerializerSettings
                    {
                        DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                        DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                        ContractResolver = new ReadOnlyJsonContractResolver(),
                        Converters = new List<JsonConverter>
                            {
                                new Iso8601TimeSpanConverter()
                            }
                    };
        }


        
        public async Task<HttpOperationResponse<T>> List<T>(string namespaceParameter, string apiVersionParameter, string kindParameter, CancellationToken cancellationToken=default(CancellationToken), bool? watch = default(bool?)) {                                    
            // Construct URL                       
            var _url = new System.Uri("http://localhost:8080/api/{apiVersion}/namespaces/{namespace}/{kind}").ToString();
            _url = _url.Replace("{namespace}", System.Uri.EscapeDataString(namespaceParameter));
            _url = _url.Replace("{apiVersion}", System.Uri.EscapeDataString(apiVersionParameter));
            _url = _url.Replace("{kind}", System.Uri.EscapeDataString(kindParameter));
            
            List<string> _queryParameters = new List<string>();
            if (watch != null)
            {
                _queryParameters.Add(string.Format("watch={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(watch, SerializationSettings).Trim('"'))));
            }          
            
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }


            HttpResponseMessage _httpResponse = null;
            string _requestContent = null;


            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();            
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);            
        

            cancellationToken.ThrowIfCancellationRequested();          
            System.Console.WriteLine("Here about to call GET: {0}", _httpRequest.RequestUri.ToString());  
 
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);  

            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            System.Console.WriteLine("Here later");  
            cancellationToken.ThrowIfCancellationRequested();

            string _responseContent = null;

            if ((int)_statusCode != 200 && (int)_statusCode != 401)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);              
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }

          
            // Create Result
            var _result = new HttpOperationResponse<T>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;

            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<T>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }            
            return _result; 
        }
    }
}
