﻿using System.Collections;
using System.Collections.Generic;
using CookComputing.XmlRpc;

namespace Frost.SharpOpenSubtitles.Models.Report {

    public class LastUpdates : XmlRpcStruct, IEnumerable<LastUpdate> {
         
        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.</returns>
        public new IEnumerator<LastUpdate> GetEnumerator() {
            IDictionaryEnumerator enumerator = base.GetEnumerator();
            while (enumerator.MoveNext()) {
                DictionaryEntry current = (DictionaryEntry) enumerator.Current;

                yield return new LastUpdate((string) current.Key, (XmlRpcStruct) current.Value);
            }
        }

        public LastUpdate GetByISOCode(string isoCode) {
            return ContainsKey(isoCode)
                ? new LastUpdate(isoCode, (XmlRpcStruct) this[isoCode])
                : null;
        }

    }
}