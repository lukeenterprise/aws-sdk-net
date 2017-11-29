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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteService operation.
    /// Deletes a specified service within a cluster. You can delete a service if you have
    /// no running tasks in it and the desired task count is zero. If the service is actively
    /// maintaining tasks, you cannot delete it, and you must update the service to a desired
    /// task count of zero. For more information, see <a>UpdateService</a>.
    /// 
    ///  <note> 
    /// <para>
    /// When you delete a service, if there are still running tasks that require cleanup,
    /// the service status moves from <code>ACTIVE</code> to <code>DRAINING</code>, and the
    /// service is no longer visible in the console or in <a>ListServices</a> API operations.
    /// After the tasks have stopped, then the service status moves from <code>DRAINING</code>
    /// to <code>INACTIVE</code>. Services in the <code>DRAINING</code> or <code>INACTIVE</code>
    /// status can still be viewed with <a>DescribeServices</a> API operations. However, in
    /// the future, <code>INACTIVE</code> services may be cleaned up and purged from Amazon
    /// ECS record keeping, and <a>DescribeServices</a> API operations on those services return
    /// a <code>ServiceNotFoundException</code> error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteServiceRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _service;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// to delete. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service to delete.
        /// </para>
        /// </summary>
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}