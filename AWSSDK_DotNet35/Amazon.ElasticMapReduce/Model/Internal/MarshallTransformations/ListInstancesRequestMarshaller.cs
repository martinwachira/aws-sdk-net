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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Instances Request Marshaller
    /// </summary>       
    internal class ListInstancesRequestMarshaller : IMarshaller<IRequest, ListInstancesRequest> 
    {
        

        public IRequest Marshall(ListInstancesRequest listInstancesRequest) 
        {

            IRequest request = new DefaultRequest(listInstancesRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.ListInstances";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (listInstancesRequest != null && listInstancesRequest.IsSetClusterId()) 
                {
                    writer.WritePropertyName("ClusterId");
                    writer.Write(listInstancesRequest.ClusterId);
                }
                if (listInstancesRequest != null && listInstancesRequest.IsSetInstanceGroupId()) 
                {
                    writer.WritePropertyName("InstanceGroupId");
                    writer.Write(listInstancesRequest.InstanceGroupId);
                }

                if (listInstancesRequest != null && listInstancesRequest.InstanceGroupTypes != null && listInstancesRequest.InstanceGroupTypes.Count > 0) 
                {
                    List<string> instanceGroupTypesList = listInstancesRequest.InstanceGroupTypes;
                    writer.WritePropertyName("InstanceGroupTypes");
                    writer.WriteArrayStart();

                    foreach (string instanceGroupTypesListValue in instanceGroupTypesList) 
                    { 
                        writer.Write(StringUtils.FromString(instanceGroupTypesListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (listInstancesRequest != null && listInstancesRequest.IsSetMarker()) 
                {
                    writer.WritePropertyName("Marker");
                    writer.Write(listInstancesRequest.Marker);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
