using AutoFixture;
using DeepEqual.Syntax;
using SchemaRemapper.Core;
using SchemaRemapper.Core.Schema;
using Xunit;

namespace SchemaRemapper.Test.Core
{
    public class TestSchemaRegister
    {
        [Fact]
        public void 追加したスキーマを参照できる()
        {
            var register = new SchemaCollection();
            var fixture = new Fixture();
            var node = fixture.Create<SchemaNode>();

            Assert.Empty(register.NodeMap);
            register.Register(node);
            Assert.NotEmpty(register.NodeMap);

            var added = register.NodeMap[node.Type.FullName];
            node.WithDeepEqual(added)
                .Assert();
        }
    }
}