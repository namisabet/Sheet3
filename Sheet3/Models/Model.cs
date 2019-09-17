using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactBAL;
using Entities;

namespace Sheet3.Models
{
    public class Model
    {
        private Business bll = new Business();
        public List<Entity> GetList()
        {

            return bll.GetEntity();
        }

    }
}