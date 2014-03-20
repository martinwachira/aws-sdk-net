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
    /// Update User Profile Request Marshaller
    /// </summary>       
    internal class UpdateUserProfileRequestMarshaller : IMarshaller<IRequest, UpdateUserProfileRequest> 
    {
        

        public IRequest Marshall(UpdateUserProfileRequest updateUserProfileRequest) 
        {

            IRequest request = new DefaultRequest(updateUserProfileRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.UpdateUserProfile";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (updateUserProfileRequest != null && updateUserProfileRequest.IsSetIamUserArn()) 
                {
                    writer.WritePropertyName("IamUserArn");
                    writer.Write(updateUserProfileRequest.IamUserArn);
                }
                if (updateUserProfileRequest != null && updateUserProfileRequest.IsSetSshUsername()) 
                {
                    writer.WritePropertyName("SshUsername");
                    writer.Write(updateUserProfileRequest.SshUsername);
                }
                if (updateUserProfileRequest != null && updateUserProfileRequest.IsSetSshPublicKey()) 
                {
                    writer.WritePropertyName("SshPublicKey");
                    writer.Write(updateUserProfileRequest.SshPublicKey);
                }
                if (updateUserProfileRequest != null && updateUserProfileRequest.IsSetAllowSelfManagement()) 
                {
                    writer.WritePropertyName("AllowSelfManagement");
                    writer.Write(updateUserProfileRequest.AllowSelfManagement);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
