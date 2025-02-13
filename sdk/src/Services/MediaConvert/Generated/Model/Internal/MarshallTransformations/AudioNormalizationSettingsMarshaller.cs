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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AudioNormalizationSettings Marshaller
    /// </summary>
    public class AudioNormalizationSettingsMarshaller : IRequestMarshaller<AudioNormalizationSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AudioNormalizationSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAlgorithm())
            {
                context.Writer.WritePropertyName("algorithm");
                context.Writer.Write(requestObject.Algorithm);
            }

            if(requestObject.IsSetAlgorithmControl())
            {
                context.Writer.WritePropertyName("algorithmControl");
                context.Writer.Write(requestObject.AlgorithmControl);
            }

            if(requestObject.IsSetCorrectionGateLevel())
            {
                context.Writer.WritePropertyName("correctionGateLevel");
                context.Writer.Write(requestObject.CorrectionGateLevel);
            }

            if(requestObject.IsSetLoudnessLogging())
            {
                context.Writer.WritePropertyName("loudnessLogging");
                context.Writer.Write(requestObject.LoudnessLogging);
            }

            if(requestObject.IsSetPeakCalculation())
            {
                context.Writer.WritePropertyName("peakCalculation");
                context.Writer.Write(requestObject.PeakCalculation);
            }

            if(requestObject.IsSetTargetLkfs())
            {
                context.Writer.WritePropertyName("targetLkfs");
                context.Writer.Write(requestObject.TargetLkfs);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AudioNormalizationSettingsMarshaller Instance = new AudioNormalizationSettingsMarshaller();

    }
}