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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplaceNetworkAclEntry Request Marshaller
    /// </summary>       
    public class ReplaceNetworkAclEntryRequestMarshaller : IMarshaller<IRequest, ReplaceNetworkAclEntryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceNetworkAclEntryRequest)input);
        }
    
        public IRequest Marshall(ReplaceNetworkAclEntryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ReplaceNetworkAclEntry");
            request.Parameters.Add("Version", "2014-10-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCidrBlock())
                {
                    request.Parameters.Add("CidrBlock", StringUtils.FromString(publicRequest.CidrBlock));
                }
                if(publicRequest.IsSetEgress())
                {
                    request.Parameters.Add("Egress", StringUtils.FromBool(publicRequest.Egress));
                }
                if(publicRequest.IsSetIcmpTypeCode())
                {
                    if(publicRequest.IcmpTypeCode.IsSetCode())
                    {
                        request.Parameters.Add("Icmp" + "." + "Code", StringUtils.FromInt(publicRequest.IcmpTypeCode.Code));
                    }
                    if(publicRequest.IcmpTypeCode.IsSetType())
                    {
                        request.Parameters.Add("Icmp" + "." + "Type", StringUtils.FromInt(publicRequest.IcmpTypeCode.Type));
                    }
                }
                if(publicRequest.IsSetNetworkAclId())
                {
                    request.Parameters.Add("NetworkAclId", StringUtils.FromString(publicRequest.NetworkAclId));
                }
                if(publicRequest.IsSetPortRange())
                {
                    if(publicRequest.PortRange.IsSetFrom())
                    {
                        request.Parameters.Add("PortRange" + "." + "From", StringUtils.FromInt(publicRequest.PortRange.From));
                    }
                    if(publicRequest.PortRange.IsSetTo())
                    {
                        request.Parameters.Add("PortRange" + "." + "To", StringUtils.FromInt(publicRequest.PortRange.To));
                    }
                }
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
                }
                if(publicRequest.IsSetRuleAction())
                {
                    request.Parameters.Add("RuleAction", StringUtils.FromString(publicRequest.RuleAction));
                }
                if(publicRequest.IsSetRuleNumber())
                {
                    request.Parameters.Add("RuleNumber", StringUtils.FromInt(publicRequest.RuleNumber));
                }
            }
            return request;
        }
    }
}