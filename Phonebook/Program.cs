using System;

namespace Phonebook
{
    internal class Program
    {
        private class PhoneBook
        {
            private string[] Name;
            private string[] Number;
            private int size;

            public PhoneBook(int _size)
            {
                this.size = _size;
                Name = new string[size];
                Number = new string[size];
            }


         

           /* public void SetBook(int i,string name, string phone)
            {
                    this.name[i] = Names;
                    this.phone[i] = phone;  
            }

            public string GetPhone(string getName)
            {
                for (int i = 0; i < size; i++)
                {
                    if (name[i] == getName)
                    {
                        return phone[i];
                    }
                }
                return null;
            }



            public string this[int index]
            {
                get
                {
                    if (index > 0 && index < size)
                    {
                        if (z[index] == index)
                        {
                            return phone[index];
                        }

                    }
                }
                return null;
            }

        } */

            public string this[int index, string name]
            {
                set
                {
                 if(index >= 0 && index <= size)
                    {
                        this.Name[index] = name;    
                        this.Number[index] = value;  
                    }

                }
                get
                {
                    for (int i = 0; i < this.size; i++)
                    {
                        if (this.Name[i] == name)
                        {
                            return this.Number[i];
                        }
                    }
                    return "not found";
                }
            }
            public string this[string name]
            {

                get
                {
                    for (int i = 0; i < this.size; i++)
                    {
                        if (this.Name[i] == name)
                        {
                            return this.Number[i];
                        }
                    }
                    return null;
                }
            }
        }






        static void Main(string[] args)
        {
            PhoneBook ph = new PhoneBook(4);
            ph[0, "Intisar"] ="96857412";
            ph[1, "Asma"]= "96854123";
            ph[2, "noor"] = "93214756";
            ph[3, "Fatma"] = "96321452";
            Console.WriteLine(ph[0, "Intisar"]);
            Console.WriteLine(ph["Asma"]);




        }
    }
}
