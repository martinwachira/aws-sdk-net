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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTable Request Marshaller
    /// </summary>       
    public class CreateTableRequestMarshaller : IMarshaller<IRequest, CreateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamWrite");
            string target = "Timestream_20181101.CreateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDatabaseName())
                {
                    context.Writer.WritePropertyName("DatabaseName");
                    context.Writer.Write(publicRequest.DatabaseName);
                }

                if(publicRequest.IsSetMagneticStoreWriteProperties())
                {
                    context.Writer.WritePropertyName("MagneticStoreWriteProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = MagneticStoreWritePropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MagneticStoreWriteProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRetentionProperties())
                {
                    context.Writer.WritePropertyName("RetentionProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetentionPropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetentionProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTableName())
                {
                    context.Writer.WritePropertyName("TableName");
                    context.Writer.Write(publicRequest.TableName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTableRequestMarshaller _instance = new CreateTableRequestMarshaller();        

        internal static CreateTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}