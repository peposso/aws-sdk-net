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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualService operation.
    /// Creates a virtual service within a service mesh.
    /// 
    ///          
    /// <para>
    /// A virtual service is an abstraction of a real service that is either provided by a
    ///         virtual node directly, or indirectly by means of a virtual router. Dependent
    /// services call         your virtual service by its <code>virtualServiceName</code>,
    /// and those requests are routed         to the virtual node or virtual router that is
    /// specified as the provider for the virtual         service.
    /// </para>
    /// </summary>
    public partial class CreateVirtualServiceRequest : AmazonAppMeshRequest
    {
        private string _clientToken;
        private string _meshName;
        private VirtualServiceSpec _spec;
        private string _virtualServiceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of therequest.
        /// Up to 36 letters, numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh in which to create the virtual service.
        /// </para>
        /// </summary>
        public string MeshName
        {
            get { return this._meshName; }
            set { this._meshName = value; }
        }

        // Check to see if MeshName property is set
        internal bool IsSetMeshName()
        {
            return this._meshName != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The virtual service specification to apply.
        /// </para>
        /// </summary>
        public VirtualServiceSpec Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualServiceName. 
        /// <para>
        /// The name to use for the virtual service.
        /// </para>
        /// </summary>
        public string VirtualServiceName
        {
            get { return this._virtualServiceName; }
            set { this._virtualServiceName = value; }
        }

        // Check to see if VirtualServiceName property is set
        internal bool IsSetVirtualServiceName()
        {
            return this._virtualServiceName != null;
        }

    }
}