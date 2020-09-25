using System;
using System.Text;

namespace FunWithClasses
{
    public class Person
    {
        private string mFirstName;
        public string FirstName
        {
            get
            {
                return this.mFirstName;
            }
            set
            {
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i<value.Length; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(char.ToUpper(value[i]));
                    }
                    else
                    {
                        sb.Append(value[i]);
                    }
                }
                this.mFirstName = sb.ToString();

            }
        }
        public string LastName
        {
            get;
            set;
        }

        public DateTime BirthDate
        {
            get;
            set;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public override int GetHashCode()
        {
            //return 1;
            return this.FirstName.GetHashCode() + this.LastName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            Person other = obj as Person;

            if (other == null)
            {
                isEqual = false;
            }
            else
            {
                if (this.GetHashCode() == other.GetHashCode())
                {
                    if (this.FirstName.Equals(other.FirstName) &&
                        this.LastName.Equals(other.LastName) &&
                        this.BirthDate.Equals(other.BirthDate))
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                    }
                }
                else
                {
                    isEqual = false;
                }
            }
            return isEqual;
        }

        //public string get_FirstName()
        //public string set_FirstName(string nameToSet);

    }
}
