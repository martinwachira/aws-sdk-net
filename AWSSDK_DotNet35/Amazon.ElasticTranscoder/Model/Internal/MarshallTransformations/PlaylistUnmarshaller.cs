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
      /// PlaylistUnmarshaller
      /// </summary>
      internal class PlaylistUnmarshaller : IUnmarshaller<Playlist, XmlUnmarshallerContext>, IUnmarshaller<Playlist, JsonUnmarshallerContext>
      {
        Playlist IUnmarshaller<Playlist, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Playlist Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Playlist playlist = new Playlist();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                playlist.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Format", targetDepth))
              {
                playlist.Format = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("OutputKeys", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                playlist.OutputKeys = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                playlist.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusDetail", targetDepth))
              {
                playlist.StatusDetail = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return playlist;
        }

        private static PlaylistUnmarshaller instance;
        public static PlaylistUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PlaylistUnmarshaller();
            return instance;
        }
    }
}
  
