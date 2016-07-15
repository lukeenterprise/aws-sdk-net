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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the output of a put approval result action.
    /// </summary>
    public partial class PutApprovalResultResponse : AmazonWebServiceResponse
    {
        private DateTime? _approvedAt;

        /// <summary>
        /// Gets and sets the property ApprovedAt. 
        /// <para>
        /// The timestamp showing when the approval or rejection was submitted.
        /// </para>
        /// </summary>
        public DateTime ApprovedAt
        {
            get { return this._approvedAt.GetValueOrDefault(); }
            set { this._approvedAt = value; }
        }

        // Check to see if ApprovedAt property is set
        internal bool IsSetApprovedAt()
        {
            return this._approvedAt.HasValue; 
        }

    }
}