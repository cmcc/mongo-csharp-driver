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

using MongoDB.BsonLibrary.IO;

namespace MongoDB.BsonLibrary.Serialization.PropertySerializers {
    public class StringPropertySerializer : IBsonPropertySerializer {
        #region private static fields
        private static StringPropertySerializer singleton = new StringPropertySerializer();
        #endregion

        #region constructors
        private StringPropertySerializer() {
        }
        #endregion

        #region public static properties
        public static StringPropertySerializer Singleton {
            get { return singleton; }
        }
        #endregion

        #region public properties
        public Type PropertyType {
            get { return typeof(string); }
        }
        #endregion

        #region public methods
        public void DeserializeProperty(
            BsonReader bsonReader,
            object obj,
            BsonPropertyMap propertyMap
        ) {
            var value = bsonReader.ReadString(propertyMap.ElementName);
            propertyMap.Setter(obj, value);
        }

        public void SerializeProperty(
            BsonWriter bsonWriter,
            object obj,
            BsonPropertyMap propertyMap
        ) {
            var value = (string) propertyMap.Getter(obj);
            bsonWriter.WriteString(propertyMap.ElementName, value);
        }
        #endregion
    }
}