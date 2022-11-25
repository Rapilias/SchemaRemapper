using System;
using System.Collections.Generic;
using SchemaRemapper.Core.Schema;

namespace SchemaRemapper.Core
{
    public interface ISchemaCollection
    {
        public IReadOnlyDictionary<string, SchemaNode> NodeMap { get; }
    }

    public interface ISchemaRegister
    {
        public void Register<T>();
        public void Register(SchemaNode schema);
    }

    internal class SchemaCollection : ISchemaCollection, ISchemaRegister
    {
        private readonly Dictionary<string, SchemaNode> _nodeMap = new Dictionary<string, SchemaNode>();
        public IReadOnlyDictionary<string, SchemaNode> NodeMap => this._nodeMap;

        public void Register(SchemaNode schema)
        {
            this._nodeMap.Add(schema.Type.FullName, schema);
        }

        public void Register<T>()
        {
            throw new NotImplementedException();
        }
    }
}