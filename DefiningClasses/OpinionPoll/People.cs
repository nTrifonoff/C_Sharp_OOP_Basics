using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04OpinionPoll
{
    public class People
    {
        private List<Person> humans;

        public People()
        {
            this.Humans = new List<Person>();
        }
        public List<Person> Humans
        {
            get { return this.humans; }
            set { this.humans = value; }
        }

        public List<Person> Get30sAndAbove()
        {
            return this.Humans.Where(x => x.Age > 30).OrderBy(k => k.Name).ToList();
        }

        public void AddMember(Person human)
        {
            if (human == null)
            {
                throw new Exception();
            }

            this.Humans.Add(human);
        }
    }
}
