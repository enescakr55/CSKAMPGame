using CSharp_Oyun.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Interface
{
    interface Manager
    {
        public void Add(Entity entity);
        public void DeletewithId(int id);
        public void Show();
    }
}
