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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataPipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Pipeline Definition Request Marshaller
    /// </summary>       
    internal class GetPipelineDefinitionRequestMarshaller : IMarshaller<IRequest, GetPipelineDefinitionRequest> 
    {
        

        public IRequest Marshall(GetPipelineDefinitionRequest getPipelineDefinitionRequest) 
        {

            IRequest request = new DefaultRequest(getPipelineDefinitionRequest, "AmazonDataPipeline");
            string target = "DataPipeline.GetPipelineDefinition";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (getPipelineDefinitionRequest != null && getPipelineDefinitionRequest.IsSetPipelineId()) 
                {
                    writer.WritePropertyName("pipelineId");
                    writer.Write(getPipelineDefinitionRequest.PipelineId);
                }
                if (getPipelineDefinitionRequest != null && getPipelineDefinitionRequest.IsSetVersion()) 
                {
                    writer.WritePropertyName("version");
                    writer.Write(getPipelineDefinitionRequest.Version);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
