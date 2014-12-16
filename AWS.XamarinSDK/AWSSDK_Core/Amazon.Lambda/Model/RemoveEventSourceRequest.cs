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

/*
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveEventSource operation.
    /// Removes an event source mapping. This means AWS Lambda will no longer invoke the function
    /// for events in the associated source.
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:RemoveEventSource</code> action.
    /// </para>
    /// </summary>
    public partial class RemoveEventSourceRequest : AmazonLambdaRequest
    {
        private string _uUID;

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The event source mapping ID.
        /// </para>
        /// </summary>
        public string UUID
        {
            get { return this._uUID; }
            set { this._uUID = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uUID != null;
        }

    }
}