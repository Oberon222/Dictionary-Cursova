using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Dictionary_Cursova
{
    class Dictionary
    {
        public string NameDictionary { get; set; }
       
        Dictionary<string,string> dictionary;

        public Dictionary()
        {
            NameDictionary = "Empty";
            dictionary = new Dictionary<string, string>();
        }

        public Dictionary(string nameDictionary)
        {
            NameDictionary = nameDictionary;
            dictionary = new Dictionary<string, string>();
        }





        public void AddWordAndTranslate(string str1,string str2)
        {
            dictionary.Add(str1, str2);
        }

        public  void AddTranslation(string strKey, string additionTranslation)
        {
            foreach(var it in dictionary)
            {
                if(strKey == it.Key)
                {
                    
                    dictionary[it.Key]=((it.Value)+ additionTranslation); //  перевірити
                }
            }

        }

        public void ReplaceTheWord()
        {


        }

        public void ReplaceTranslation(string strKey, string newTranslation)
        {
            foreach(var it in dictionary)
            {
                if(strKey== it.Key)
                {
                    dictionary[it.Key] = newTranslation;
                }
            }

        }

        public void DeleteTranslation(string wordKey, string deleteTranslate)
        {
            foreach(var it in dictionary)
            {
                if(it.Key== wordKey)
                {
                    string tmp = it.Value;
                    string[] words = tmp.Split(new char[] { ' ' });
                    for(int i=0;i<words.Length;i++)
                    {
                        if(words[i]== deleteTranslate)
                        {
                            words.R
                        }
                    }

                }
            }
        }

        public void DeleteWord(string strKey)
        {
            foreach(var it in dictionary)
            {
                if(strKey == it.Key)
                {
                    dictionary.Remove(it.Key);
                }
            }
        }


        public void SerchTranslation(string strKey)
        {
            foreach (var it in dictionary)
            {
                if(it.Key == strKey)
                {
                    Console.WriteLine($"Word {it.Key} : Translation {it.Value}");
                }
            }
        }



    }

    class DictionaryCollection
    {
        public string NameDictionatyCollection { get; set; }
        List<Dictionary> dictionaries;

        public DictionaryCollection()
        {
            NameDictionatyCollection = "Empty";
            dictionaries = new List<Dictionary>();
        }

        public DictionaryCollection(string name)
        {
            NameDictionatyCollection = name;
            dictionaries = new List<Dictionary>();

        }

        public void AddToDictionaryCollection(Dictionary dic)
        {
            dictionaries.Add(dic);
        }

        public void DeleteFromDictionaryCollection(Dictionary dic)
        {
            foreach(var it in dictionaries)
            {
                if(it.NameDictionary== dic.NameDictionary)
                {
                    dictionaries.Remove(it);
                }
            }
        }

        public void SaveInFile()
        {

        }

        public void LoadFromFile()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            do
            {

            } while (true);
        }
    }
}
