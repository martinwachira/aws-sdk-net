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
 * Do not modify this file. This file is generated from the profile-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Profile.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Profile.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteProfileKey Request Marshaller
    /// </summary>       
    public class DeleteProfileKeyRequestMarshaller : IMarshaller<IRequest, DeleteProfileKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteProfileKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteProfileKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Profile");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonProfileException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}/profiles/keys/delete";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetKeyName())
                {
                    context.Writer.WritePropertyName("KeyName");
                    context.Writer.Write(publicRequest.KeyName);
                }

                if(publicRequest.IsSetProfileId())
                {
                    context.Writer.WritePropertyName("ProfileId");
                    context.Writer.Write(publicRequest.ProfileId);
                }

                if(publicRequest.IsSetValues())
                {
                    context.Writer.WritePropertyName("Values");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestValuesListValue in publicRequest.Values)
                    {
                            context.Writer.Write(publicRequestValuesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DeleteProfileKeyRequestMarshaller _instance = new DeleteProfileKeyRequestMarshaller();        

        internal static DeleteProfileKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteProfileKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}