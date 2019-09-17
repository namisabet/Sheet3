using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ContactDAL;


namespace ContactBAL
{
    public class Business
    {
        public void Add(Entity p)
        {
            p.Id = DB.LastId++;
            if (p.MobileNum == null || string.IsNullOrWhiteSpace(p.MobileNum) || string.IsNullOrEmpty(p.MobileNum))
                p.MobileNum = "Not Available";
            DB.entities.Add(p);
        }
        public void Display(Entity p)
        {
            DB.active.Add(p);
        }
        public List<Entity> GetEntity()
        {

            DB.active.Clear();

            for (int i = 0; i < DB.entities.Count; i++)
            {
                if (DB.entities[i].Active == true)
                    Display(DB.entities[i]);
            }
            return DB.active;
        }

        public void Delete(int id)
        {
            Entity en = DB.entities.Where(x => x.Id == id).First();
            en.Active = false;
        }

        public Entity Details(int id)
        {
            return DB.entities.Where(x => x.Id == id).Single();
        }

        public void Update(Entity p)
        {
            Entity en = DB.entities.Where(x => x.Id == p.Id).First();

            if (p.MobileNum == null || string.IsNullOrWhiteSpace(p.MobileNum) || string.IsNullOrEmpty(p.MobileNum))
                p.MobileNum = "Not Available";


            en.FirstName = p.FirstName;
            en.LastName = p.LastName;
            en.MobileNum = p.MobileNum;
            en.HomeNum = p.HomeNum;
            en.BusinessNum = p.BusinessNum;
            en.Address = p.Address;
            en.Active = p.Active;
            en.Note = p.Note;

            if (en.MobileNum == null || string.IsNullOrEmpty(en.MobileNum) || string.IsNullOrWhiteSpace(en.MobileNum))
            { en.MobileNum = "Not Available"; }
            /*
             * Entity getters and setters for reference
             * 
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MobileNum { get; set; }
            public string HomeNum { get; set; }
            public string BusinessNum { get; set; }
            public string Address { get; set; }
            public string Note { get; set; }
            public bool Active { get; set; }
        */

        }
    }
}
