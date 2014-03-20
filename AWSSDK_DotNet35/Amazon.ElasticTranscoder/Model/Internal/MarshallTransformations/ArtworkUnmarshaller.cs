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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ArtworkUnmarshaller
      /// </summary>
      internal class ArtworkUnmarshaller : IUnmarshaller<Artwork, XmlUnmarshallerContext>, IUnmarshaller<Artwork, JsonUnmarshallerContext>
      {
        Artwork IUnmarshaller<Artwork, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Artwork Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Artwork artwork = new Artwork();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("InputKey", targetDepth))
              {
                artwork.InputKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxWidth", targetDepth))
              {
                artwork.MaxWidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MaxHeight", targetDepth))
              {
                artwork.MaxHeight = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SizingPolicy", targetDepth))
              {
                artwork.SizingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PaddingPolicy", targetDepth))
              {
                artwork.PaddingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AlbumArtFormat", targetDepth))
              {
                artwork.AlbumArtFormat = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return artwork;
        }

        private static ArtworkUnmarshaller instance;
        public static ArtworkUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ArtworkUnmarshaller();
            return instance;
        }
    }
}
  
