using System;
using System.Xml.Serialization;

namespace Scripts.Utility.Serializer {
    /// <summary>
    /// Additional struct for serialization dictionary.
    /// </summary>
    /// <typeparam name="K">Key type</typeparam>
    /// <typeparam name="V">Value type</typeparam>
    [Serializable]
    [XmlType ("KeyValuePair")]
    public struct KeyValuePair<K,V> {
        /// <summary>
        /// Key
        /// </summary>
        [XmlElement ("Key")]
        public K Key { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        [XmlElement ("Value")]
        public V Value { get; set; }
    }
}
