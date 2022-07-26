using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSqlite
{
    class FlyoutItemPage
    {

        public string Title { get; set; }
        public string IconSource { get; set; }
        //targetPage variable is where we store our page. Its datatype is Type.
        //it represents type declarations such as class types, interface types, array types, enumeration types and so on
        public Type TargetPage { get; set; }
        
    }
}
