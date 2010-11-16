﻿/* Copyright 2010 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB.Bson.DefaultSerializer {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class BsonKnownTypesAttribute : Attribute {
        #region private fields
        private Type[] knownTypes;
        #endregion

        #region constructors
        public BsonKnownTypesAttribute(
            params Type[] knownTypes
        ) {
            this.knownTypes = knownTypes;
        }
        #endregion

        #region public properties
        public Type[] KnownTypes {
            get { return knownTypes; }
        }
        #endregion
    }
}