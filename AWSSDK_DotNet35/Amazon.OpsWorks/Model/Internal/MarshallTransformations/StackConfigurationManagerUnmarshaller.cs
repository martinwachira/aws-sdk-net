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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StackConfigurationManagerUnmarshaller
      /// </summary>
      internal class StackConfigurationManagerUnmarshaller : IUnmarshaller<StackConfigurationManager, XmlUnmarshallerContext>, IUnmarshaller<StackConfigurationManager, JsonUnmarshallerContext>
      {
        StackConfigurationManager IUnmarshaller<StackConfigurationManager, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StackConfigurationManager Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            StackConfigurationManager stackConfigurationManager = new StackConfigurationManager();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                stackConfigurationManager.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Version", targetDepth))
              {
                stackConfigurationManager.Version = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return stackConfigurationManager;
        }

        private static StackConfigurationManagerUnmarshaller instance;
        public static StackConfigurationManagerUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StackConfigurationManagerUnmarshaller();
            return instance;
        }
    }
}
  
