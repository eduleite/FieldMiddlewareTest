using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldMiddlewareTest
{

    public class QueryResolver
    {

        [UseUpperCase]
        public string HelloWorld()
        {
            return "hello world";
        }

    }
}
