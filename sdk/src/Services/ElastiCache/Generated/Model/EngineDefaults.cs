/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of a <code>DescribeEngineDefaultParameters</code> operation.
    /// </summary>
    public partial class EngineDefaults
    {
        private List<CacheNodeTypeSpecificParameter> _cacheNodeTypeSpecificParameters = new List<CacheNodeTypeSpecificParameter>();
        private string _cacheParameterGroupFamily;
        private string _marker;
        private List<Parameter> _parameters = new List<Parameter>();

        /// <summary>
        /// Gets and sets the property CacheNodeTypeSpecificParameters. 
        /// <para>
        /// A list of parameters specific to a particular cache node type. Each element in the
        /// list contains detailed information about one parameter.
        /// </para>
        /// </summary>
        public List<CacheNodeTypeSpecificParameter> CacheNodeTypeSpecificParameters
        {
            get { return this._cacheNodeTypeSpecificParameters; }
            set { this._cacheNodeTypeSpecificParameters = value; }
        }

        // Check to see if CacheNodeTypeSpecificParameters property is set
        internal bool IsSetCacheNodeTypeSpecificParameters()
        {
            return this._cacheNodeTypeSpecificParameters != null && this._cacheNodeTypeSpecificParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CacheParameterGroupFamily. 
        /// <para>
        /// Specifies the name of the cache parameter group family to which the engine default
        /// parameters apply.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <code>memcached1.4</code> | <code>memcached1.5</code> | <code>memcached1.6</code>
        /// | <code>redis2.6</code> | <code>redis2.8</code> | <code>redis3.2</code> | <code>redis4.0</code>
        /// | <code>redis5.0</code> | <code>redis6.0</code> | <code>redis6.x</code> 
        /// </para>
        /// </summary>
        public string CacheParameterGroupFamily
        {
            get { return this._cacheParameterGroupFamily; }
            set { this._cacheParameterGroupFamily = value; }
        }

        // Check to see if CacheParameterGroupFamily property is set
        internal bool IsSetCacheParameterGroupFamily()
        {
            return this._cacheParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Provides an identifier to allow retrieval of paginated results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Contains a list of engine default parameters.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}