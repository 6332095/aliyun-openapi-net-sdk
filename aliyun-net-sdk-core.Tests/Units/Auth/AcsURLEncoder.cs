﻿using System.Text;
/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Web;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class AcsUrlEncoderTest
    {
        [Fact]
        public void Encode()
        {
            var source = " ♂:@#¥%&*（";
            var encode = HttpUtility.UrlDecode(AcsURLEncoder.Encode(" ♂:@#¥%&*（"), Encoding.UTF8);
            Assert.Equal(encode, source);
        }

        [Fact]
        public void PercentEncode()
        {
            var result =
                AcsURLEncoder.PercentEncode(
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~!@#$%^&*()");
            Assert.Equal(
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~%21%40%23%24%25%5E%26%2A%28%29",
                result);
        }
    }
}
