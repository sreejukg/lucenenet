// LUCENENET specific - commented this because we already have an ObjectDisposedException in .NET.
// This is just reinventing the wheel. ObjectDisposedException, like AlreadyClosedException, subclasses 
// InvalidOperationException, so it makes a good replacement.

//using System;

//namespace Lucene.Net.Store
//{
//    /*
//     * Licensed to the Apache Software Foundation (ASF) under one or more
//     * contributor license agreements.  See the NOTICE file distributed with
//     * this work for additional information regarding copyright ownership.
//     * The ASF licenses this file to You under the Apache License, Version 2.0
//     * (the "License"); you may not use this file except in compliance with
//     * the License.  You may obtain a copy of the License at
//     *
//     *     http://www.apache.org/licenses/LICENSE-2.0
//     *
//     * Unless required by applicable law or agreed to in writing, software
//     * distributed under the License is distributed on an "AS IS" BASIS,
//     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     * See the License for the specific language governing permissions and
//     * limitations under the License.
//     */

//    /// <summary>
//    /// this exception is thrown when there is an attempt to
//    /// access something that has already been closed.
//    /// </summary>
//    // LUCENENET: All exeption classes should be marked serializable
//#if FEATURE_SERIALIZABLE
//    [Serializable]
//#endif
//    public class AlreadyClosedException : InvalidOperationException
//    {
//        public AlreadyClosedException(string message)
//            : base(message)
//        {
//        }
//    }
//}