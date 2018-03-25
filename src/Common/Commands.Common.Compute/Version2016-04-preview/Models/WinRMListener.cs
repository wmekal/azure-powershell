// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version2016_04_preview.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes Protocol and thumbprint of Windows Remote Management listener
    /// </summary>
    public partial class WinRMListener
    {
        /// <summary>
        /// Initializes a new instance of the WinRMListener class.
        /// </summary>
        public WinRMListener()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WinRMListener class.
        /// </summary>
        /// <param name="protocol">Specifies the protocol of listener.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;**http**
        /// &lt;br&gt;&lt;br&gt; **https**. Possible values include: 'Http',
        /// 'Https'</param>
        /// <param name="certificateUrl">This is the URL of a certificate that
        /// has been uploaded to Key Vault as a secret. For adding a secret to
        /// the Key Vault, see [Add a key or secret to the key
        /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64
        /// encoding of the following JSON Object which is encoded in UTF-8:
        /// &lt;br&gt;&lt;br&gt; {&lt;br&gt;
        /// "data":"&lt;Base64-encoded-certificate&gt;",&lt;br&gt;
        /// "dataType":"pfx",&lt;br&gt;
        /// "password":"&lt;pfx-file-password&gt;"&lt;br&gt;}</param>
        public WinRMListener(ProtocolTypes? protocol = default(ProtocolTypes?), string certificateUrl = default(string))
        {
            Protocol = protocol;
            CertificateUrl = certificateUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the protocol of listener.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;**http** &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// **https**. Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public ProtocolTypes? Protocol { get; set; }

        /// <summary>
        /// Gets or sets this is the URL of a certificate that has been
        /// uploaded to Key Vault as a secret. For adding a secret to the Key
        /// Vault, see [Add a key or secret to the key
        /// vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add).
        /// In this case, your certificate needs to be It is the Base64
        /// encoding of the following JSON Object which is encoded in UTF-8:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; {&amp;lt;br&amp;gt;
        /// "data":"&amp;lt;Base64-encoded-certificate&amp;gt;",&amp;lt;br&amp;gt;
        /// "dataType":"pfx",&amp;lt;br&amp;gt;
        /// "password":"&amp;lt;pfx-file-password&amp;gt;"&amp;lt;br&amp;gt;}
        /// </summary>
        [JsonProperty(PropertyName = "certificateUrl")]
        public string CertificateUrl { get; set; }

    }
}
