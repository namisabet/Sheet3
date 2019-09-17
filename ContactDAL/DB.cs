using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ContactDAL;

namespace ContactDAL
{
    public static class DB
    {
        public static int LastId = 1;

        public static List<Entity> entities = new List<Entity>();
        public static List<Entity> active = new List<Entity>();
    }
}
