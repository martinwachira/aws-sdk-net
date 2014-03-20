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
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// CategoryUnmarshaller
      /// </summary>
      internal class CategoryUnmarshaller : IUnmarshaller<Category, XmlUnmarshallerContext>, IUnmarshaller<Category, JsonUnmarshallerContext>
      {
        Category IUnmarshaller<Category, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Category Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Category category = new Category();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("code", targetDepth))
              {
                category.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("name", targetDepth))
              {
                category.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return category;
        }

        private static CategoryUnmarshaller instance;
        public static CategoryUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CategoryUnmarshaller();
            return instance;
        }
    }
}
  
