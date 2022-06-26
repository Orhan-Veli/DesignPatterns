using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person{Name="Robert",Gender="MALE",MaritalStatus="SINGLE"});
            persons.Add(new Person{Name="John",Gender="MALE",MaritalStatus="SINGLE"});
            persons.Add(new Person{Name="Diana",Gender="FEMALE",MaritalStatus="MARRIED"});
            
            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new OrCriteria(single, female);

            PrintPersons(male.MeetCriteria(persons)); 
            Console.WriteLine("----------");
            PrintPersons(female.MeetCriteria(persons));
            Console.WriteLine("----------");
            PrintPersons(singleMale.MeetCriteria(persons));
            Console.WriteLine("----------");
            PrintPersons(singleOrFemale.MeetCriteria(persons));
        }

        public static void PrintPersons(List<Person> persons)
        {
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name + " " + item.Gender + " " + item.MaritalStatus);
            }
        }
    }

   

    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        // private string name;
        // private string gender;
        // private string maritalStatus;

        // public Person(string name, string gender, string maritalStatus)
        // {
        //     this.name = name;
        //     this.gender = gender;
        //     this.maritalStatus = maritalStatus;
        // }
    }

    public interface Criteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }

    public class CriteriaMale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();

            foreach (var person in persons)
            {
                if(person.Gender == "MALE")
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        } 
    }

    public class CriteriaFemale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach (var person in persons)
            {
                if(person.Gender == "FEMALE")
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        } 
    }

    public class CriteriaSingle : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();

            foreach (var person in persons)
            {
                if(person.MaritalStatus == "SINGLE")
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }

    public class AndCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public AndCriteria(Criteria criteria,Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = criteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.MeetCriteria(persons);
            return otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }

    public class OrCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public OrCriteria(Criteria criteria,Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = criteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.MeetCriteria(persons);

            foreach (var person in otherCriteriaItems)
            {
                if(!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }

            return firstCriteriaItems;
        }
    }
}
