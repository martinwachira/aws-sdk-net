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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details on the cache hit of a pipeline execution step.
    /// </summary>
    public partial class CacheHitResult
    {
        private string _sourcePipelineExecutionArn;

        /// <summary>
        /// Gets and sets the property SourcePipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SourcePipelineExecutionArn
        {
            get { return this._sourcePipelineExecutionArn; }
            set { this._sourcePipelineExecutionArn = value; }
        }

        // Check to see if SourcePipelineExecutionArn property is set
        internal bool IsSetSourcePipelineExecutionArn()
        {
            return this._sourcePipelineExecutionArn != null;
        }

    }
}