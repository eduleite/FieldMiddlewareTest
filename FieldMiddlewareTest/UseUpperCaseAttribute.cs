using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FieldMiddlewareTest
{
    public class UseUpperCaseAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.Use(next => async context =>
            {
                await next(context);
                if (context.Result is string result)
                {
                    context.Result = result.ToUpperInvariant();
                }
            });
        }
    }
}
