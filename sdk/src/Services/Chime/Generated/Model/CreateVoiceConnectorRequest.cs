/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVoiceConnector operation.
    /// Creates an Amazon Chime Voice Connector under the administrator's AWS account. Enabling
    /// <a>CreateVoiceConnectorRequest$RequireEncryption</a> configures your Amazon Chime
    /// Voice Connector to use TLS transport for SIP signaling and Secure RTP (SRTP) for media.
    /// Inbound calls use TLS transport, and unencrypted outbound calls are blocked.
    /// </summary>
    public partial class CreateVoiceConnectorRequest : AmazonChimeRequest
    {
        private string _name;
        private bool? _requireEncryption;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Chime Voice Connector.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequireEncryption. 
        /// <para>
        /// When enabled, requires encryption for the Amazon Chime Voice Connector.
        /// </para>
        /// </summary>
        public bool RequireEncryption
        {
            get { return this._requireEncryption.GetValueOrDefault(); }
            set { this._requireEncryption = value; }
        }

        // Check to see if RequireEncryption property is set
        internal bool IsSetRequireEncryption()
        {
            return this._requireEncryption.HasValue; 
        }

    }
}