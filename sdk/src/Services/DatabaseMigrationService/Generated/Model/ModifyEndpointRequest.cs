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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEndpoint operation.
    /// Modifies the specified endpoint.
    /// </summary>
    public partial class ModifyEndpointRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _certificateArn;
        private string _databaseName;
        private string _endpointArn;
        private string _endpointIdentifier;
        private ReplicationEndpointTypeValue _endpointType;
        private string _engineName;
        private string _extraConnectionAttributes;
        private string _password;
        private int? _port;
        private string _serverName;
        private DmsSslModeValue _sslMode;
        private string _username;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate used for SSL connection.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the endpoint database.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The database endpoint identifier. Identifiers must begin with a letter; must contain
        /// only ASCII letters, digits, and hyphens; and must not end with a hyphen or contain
        /// two consecutive hyphens.
        /// </para>
        /// </summary>
        public string EndpointIdentifier
        {
            get { return this._endpointIdentifier; }
            set { this._endpointIdentifier = value; }
        }

        // Check to see if EndpointIdentifier property is set
        internal bool IsSetEndpointIdentifier()
        {
            return this._endpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint.
        /// </para>
        /// </summary>
        public ReplicationEndpointTypeValue EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The type of engine for the endpoint. Valid values include MYSQL, ORACLE, POSTGRES,
        /// MARIADB, AURORA, REDSHIFT, and SQLSERVER.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraConnectionAttributes. 
        /// <para>
        /// Additional attributes associated with the connection.
        /// </para>
        /// </summary>
        public string ExtraConnectionAttributes
        {
            get { return this._extraConnectionAttributes; }
            set { this._extraConnectionAttributes = value; }
        }

        // Check to see if ExtraConnectionAttributes property is set
        internal bool IsSetExtraConnectionAttributes()
        {
            return this._extraConnectionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password to be used to login to the endpoint database.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port used by the endpoint database.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server where the endpoint database resides.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property SslMode. 
        /// <para>
        /// The SSL mode to be used.
        /// </para>
        ///  
        /// <para>
        /// SSL mode can be one of four values: none, require, verify-ca, verify-full. 
        /// </para>
        ///  
        /// <para>
        /// The default value is none.
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode
        {
            get { return this._sslMode; }
            set { this._sslMode = value; }
        }

        // Check to see if SslMode property is set
        internal bool IsSetSslMode()
        {
            return this._sslMode != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name to be used to login to the endpoint database.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}