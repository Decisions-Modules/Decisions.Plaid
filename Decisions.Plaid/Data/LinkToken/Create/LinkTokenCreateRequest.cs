using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Create
{
    /// <summary>LinkTokenCreateRequest defines the request schema for `/link/token/create`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenCreateRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>The name of your application, as it should be displayed in Link. Maximum length of 30 characters. If a value longer than 30 characters is provided, Link will display "This Application" instead.</summary>
        [Newtonsoft.Json.JsonProperty("client_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Client_name { get; set; }
    
        /// <summary>The language that Link should be displayed in.
        /// <br/>
        /// <br/>Supported languages are:
        /// <br/>- English (`'en'`)
        /// <br/>- French (`'fr'`)
        /// <br/>- Spanish (`'es'`)
        /// <br/>- Dutch (`'nl'`)
        /// <br/>
        /// <br/>When using a Link customization, the language configured here must match the setting in the customization, or the customization will not be applied.</summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Language { get; set; }
    
        /// <summary>Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard. Institutions from all listed countries will be shown.  Supported country codes are: `US`, `CA`, `ES`, `FR`, `GB`, `IE`, `NL`.
        /// <br/>
        /// <br/>If Link is launched with multiple country codes, only products that you are enabled for in all countries will be used by Link. Note that while all countries are enabled by default in Sandbox and Development, in Production only US and Canada are enabled by default. To gain access to European institutions in the Production environment, [file a product access Support ticket](https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access) via the Plaid dashboard. If you initialize with a European country code, your users will see the European consent panel during the Link flow.
        /// <br/>
        /// <br/>If using a Link customization, make sure the country codes in the customization match those specified in `country_codes`. If both `country_codes` and a Link customization are used, the value in `country_codes` may override the value in the customization.
        /// <br/>
        /// <br/>If using the Auth features Instant Match, Same-day Micro-deposits, or Automated Micro-deposits, `country_codes` must be set to `['US']`.</summary>
        [Newtonsoft.Json.JsonProperty("country_codes", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.ObjectModel.Collection<CountryCode> Country_codes { get; set; } = new System.Collections.ObjectModel.Collection<CountryCode>();
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public LinkTokenCreateRequestUser User { get; set; } = new LinkTokenCreateRequestUser();
    
        /// <summary>List of Plaid product(s) you wish to use. If launching Link in update mode, should be omitted; required otherwise. Valid products are:
        /// <br/>
        /// <br/>`transactions`, `auth`, `identity`, `assets`, `investments`, `liabilities`, `payment_initiation`, `deposit_switch`, `income_verification`, `transfer`
        /// <br/>
        /// <br/>`balance` is *not* a valid value, the Balance product does not require explicit initalization and will automatically be initialized when any other product is initialized.
        /// <br/>
        /// <br/>Only institutions that support *all* requested products will be shown in Link; to maximize the number of institutions listed, it is recommended to initialize Link with the minimal product set required for your use case. Additional products can be added after Link initialization by calling the relevant endpoints. For details and exceptions, see [Choosing when to initialize products](https://plaid.com/docs/link/best-practices/#choosing-when-to-initialize-products).
        /// <br/>
        /// <br/>Note that, unless you have opted to disable Instant Match support, institutions that support Instant Match will also be shown in Link if `auth` is specified as a product, even though these institutions do not contain `auth` in their product array.
        /// <br/>
        /// <br/>In Production, you will be billed for each product that you specify when initializing Link. Note that a product cannot be removed from an Item once the Item has been initialized with that product. To stop billing on an Item for subscription-based products, such as Liabilities, Investments, and Transactions, remove the Item via `/item/remove`.</summary>
        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<Products.Products> Products { get; set; }
    
        /// <summary>The destination URL to which any webhooks should be sent.</summary>
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook { get; set; }
    
        /// <summary>The `access_token` associated with the Item to update, used when updating or modifying an existing `access_token`. Used when launching Link in update mode, when completing the Same-day (manual) Micro-deposit flow, or (optionally) when initializing Link as part of the Payment Initiation (UK and Europe) flow.</summary>
        [Newtonsoft.Json.JsonProperty("access_token", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Access_token { get; set; }
    
        /// <summary>The name of the Link customization from the Plaid Dashboard to be applied to Link. If not specified, the `default` customization will be used. When using a Link customization, the language in the customization must match the language selected via the `language` parameter, and the countries in the customization should match the country codes selected via `country_codes`.</summary>
        [Newtonsoft.Json.JsonProperty("link_customization_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Link_customization_name { get; set; }
    
        /// <summary>A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or via a webview. The `redirect_uri` should not contain any query parameters. When used in Production or Development, must be an https URI. To specify any subdomain, use `*` as a wildcard character, e.g. `https://*.example.com/oauth.html`. If `android_package_name` is specified, this field should be left blank.  Note that any redirect URI must also be added to the Allowed redirect URIs list in the [developer dashboard](https://dashboard.plaid.com/team/api).</summary>
        [Newtonsoft.Json.JsonProperty("redirect_uri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Redirect_uri { get; set; }
    
        /// <summary>The name of your app's Android package. Required if using the `link_token` to initialize Link on Android. When creating a `link_token` for initializing Link on other platforms, this field must be left blank. Any package name specified here must also be added to the Allowed Android package names setting on the [developer dashboard](https://dashboard.plaid.com/team/api). </summary>
        [Newtonsoft.Json.JsonProperty("android_package_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Android_package_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account_filters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenAccountFilters Account_filters { get; set; }
    
        [Newtonsoft.Json.JsonProperty("eu_config", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenEUConfig Eu_config { get; set; }
    
        /// <summary>Used for certain Europe-only configurations, as well as certain legacy use cases in other regions.</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Institution_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("payment_initiation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenCreateRequestPaymentInitiation Payment_initiation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("deposit_switch", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenCreateRequestDepositSwitch Deposit_switch { get; set; }
    
        [Newtonsoft.Json.JsonProperty("income_verification", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenCreateRequestIncomeVerification Income_verification { get; set; }
    
        [Newtonsoft.Json.JsonProperty("auth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenCreateRequestAuth Auth { get; set; }
    
        [Newtonsoft.Json.JsonProperty("update", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkTokenCreateRequestUpdate Update { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}