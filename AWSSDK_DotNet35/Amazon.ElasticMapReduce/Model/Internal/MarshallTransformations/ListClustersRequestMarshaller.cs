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
    /// List Clusters Request Marshaller
    /// </summary>       
    internal class ListClustersRequestMarshaller : IMarshaller<IRequest, ListClustersRequest> 
    {
        

        public IRequest Marshall(ListClustersRequest listClustersRequest) 
        {

            IRequest request = new DefaultRequest(listClustersRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.ListClusters";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (listClustersRequest != null && listClustersRequest.IsSetCreatedAfter()) 
                {
                    writer.WritePropertyName("CreatedAfter");
                    writer.Write(listClustersRequest.CreatedAfter);
                }
                if (listClustersRequest != null && listClustersRequest.IsSetCreatedBefore()) 
                {
                    writer.WritePropertyName("CreatedBefore");
                    writer.Write(listClustersRequest.CreatedBefore);
                }

                if (listClustersRequest != null && listClustersRequest.ClusterStates != null && listClustersRequest.ClusterStates.Count > 0) 
                {
                    List<string> clusterStatesList = listClustersRequest.ClusterStates;
                    writer.WritePropertyName("ClusterStates");
                    writer.WriteArrayStart();

                    foreach (string clusterStatesListValue in clusterStatesList) 
                    { 
                        writer.Write(StringUtils.FromString(clusterStatesListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (listClustersRequest != null && listClustersRequest.IsSetMarker()) 
                {
                    writer.WritePropertyName("Marker");
                    writer.Write(listClustersRequest.Marker);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
