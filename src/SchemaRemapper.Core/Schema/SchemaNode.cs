using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaRemapper.Core.Schema
{
    public enum ValueType
    {
        Value,
        Array,
        Dictionary,
    }

    public class SchemaNode
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public ValueType ValueType { get; set; }
    }
}