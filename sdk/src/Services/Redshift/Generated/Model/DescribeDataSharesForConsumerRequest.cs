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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataSharesForConsumer operation.
    /// Returns a list of datashares where the account identifier being called is a consumer
    /// account identifier.
    /// </summary>
    public partial class DescribeDataSharesForConsumerRequest : AmazonRedshiftRequest
    {
        private string _consumerArn;
        private string _marker;
        private int? _maxRecords;
        private DataShareStatusForConsumer _status;

        /// <summary>
        /// Gets and sets the property ConsumerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumer that returns in the list of datashares.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ConsumerArn
        {
            get { return this._consumerArn; }
            set { this._consumerArn = value; }
        }

        // Check to see if ConsumerArn property is set
        internal bool IsSetConsumerArn()
        {
            return this._consumerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeDataSharesForConsumer</a> request exceed
        /// the value specified in <code>MaxRecords</code>, Amazon Web Services returns a value
        /// in the <code>Marker</code> field of the response. You can retrieve the next set of
        /// response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and retrying the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <code>MaxRecords</code> value, a value is returned
        /// in a <code>marker</code> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value. 
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An identifier giving the status of a datashare in the consumer cluster. If this field
        /// is specified, Amazon Redshift returns the list of datashares that have the specified
        /// status.
        /// </para>
        /// </summary>
        public DataShareStatusForConsumer Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}