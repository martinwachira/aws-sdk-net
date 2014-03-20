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

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Instance Request Marshaller
    /// </summary>       
    internal class CreateInstanceRequestMarshaller : IMarshaller<IRequest, CreateInstanceRequest> 
    {
        

        public IRequest Marshall(CreateInstanceRequest createInstanceRequest) 
        {

            IRequest request = new DefaultRequest(createInstanceRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.CreateInstance";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (createInstanceRequest != null && createInstanceRequest.IsSetStackId()) 
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(createInstanceRequest.StackId);
                }

                if (createInstanceRequest != null && createInstanceRequest.LayerIds != null && createInstanceRequest.LayerIds.Count > 0) 
                {
                    List<string> layerIdsList = createInstanceRequest.LayerIds;
                    writer.WritePropertyName("LayerIds");
                    writer.WriteArrayStart();

                    foreach (string layerIdsListValue in layerIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(layerIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetInstanceType()) 
                {
                    writer.WritePropertyName("InstanceType");
                    writer.Write(createInstanceRequest.InstanceType);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetAutoScalingType()) 
                {
                    writer.WritePropertyName("AutoScalingType");
                    writer.Write(createInstanceRequest.AutoScalingType);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetHostname()) 
                {
                    writer.WritePropertyName("Hostname");
                    writer.Write(createInstanceRequest.Hostname);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetOs()) 
                {
                    writer.WritePropertyName("Os");
                    writer.Write(createInstanceRequest.Os);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetAmiId()) 
                {
                    writer.WritePropertyName("AmiId");
                    writer.Write(createInstanceRequest.AmiId);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetSshKeyName()) 
                {
                    writer.WritePropertyName("SshKeyName");
                    writer.Write(createInstanceRequest.SshKeyName);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetAvailabilityZone()) 
                {
                    writer.WritePropertyName("AvailabilityZone");
                    writer.Write(createInstanceRequest.AvailabilityZone);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetSubnetId()) 
                {
                    writer.WritePropertyName("SubnetId");
                    writer.Write(createInstanceRequest.SubnetId);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetArchitecture()) 
                {
                    writer.WritePropertyName("Architecture");
                    writer.Write(createInstanceRequest.Architecture);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetRootDeviceType()) 
                {
                    writer.WritePropertyName("RootDeviceType");
                    writer.Write(createInstanceRequest.RootDeviceType);
                }
                if (createInstanceRequest != null && createInstanceRequest.IsSetInstallUpdatesOnBoot()) 
                {
                    writer.WritePropertyName("InstallUpdatesOnBoot");
                    writer.Write(createInstanceRequest.InstallUpdatesOnBoot);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
