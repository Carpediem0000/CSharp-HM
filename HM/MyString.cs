using System;

namespace HM
{
    class MyString
    {
        public char[] str {  get; set; }

        public MyString(char[] w) { str = w; }

        public int length { get; }

        public char StartWith() => str[0];
        public char EndWith() => str[str.Length - 1];
        public char[] Substring(int startIndex, int endIndex)
        {
            //this.str = "Some text"
            //startIndex = 3
            //endIndex = 2
            //result = "e "
            char[] res = new char[endIndex];
            int j = 0;

            for (int i = startIndex; i < startIndex + endIndex; i++)
            {
                res[j++] = str[i];
            }

            return res;
        }
        public void Remove(int startIndex, int endIndex)
        {
            //this.str = "Some text"
            //startIndex = 1
            //endIndex = 3
            //result = "S text"

            char[] res = new char[str.Length - endIndex];
            for (int i = 0, j = 0; i < str.Length; i++)
            {
                if (i >= startIndex && i < i + endIndex){}
                else
                {
                    res[j] = str[i];
                    j++;
                }
            }
            str = res;
        }

        private void Insert(int index, char[] value)
        {
            char[] res = new char[str.Length + value.Length];

            for (int i = 0, j = 0; i < res.Length; i++)
            {
                if (i < index || i >= index + value.Length)
                {
                    res[i] = str[j];
                    j++;
                }
                else
                {
                    res[i] = value[i - index];
                }
            }

            str = res;
        }

        public void RemoveAll()
        {
            //this.str = "Some text"
            //this.str = ""
            str = new char[0];
        }
        public int IndexOf(char[] search)
        {
            //this.str = "My friend with hi"
            //search = "hi"
            //foundIndex = 15
            int foundIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == search[0])
                {
                    foundIndex = i;
                    bool found = false;
                    for (int j = 0; j < search.Length; j++)
                    {
                        if (search[j] == str[foundIndex])
                        {
                            found = true;
                            foundIndex++;
                        }
                        else
                        {
                            found = false;
                            foundIndex = -1;
                            i += search.Length-1;
                            break;
                        }
                    }
                    if (found)
                    {
                        foundIndex = i;
                        break;
                    }
                }
            }
            return foundIndex;
        }
        public void Concat(char[] str1, char[] str2)
        {
            //str1 = "Hello, "
            //str2 = "World!"
            //result = "Hello, World!"
            str = new char[str1.Length + str2.Length];
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                str[j++] = str1[i];
            }
            for (int i = 0; i < length; i++)
            {
                str[j++] = str2[i];
            }
        }
        public void Replace(char[] newValue)
        {
            //this.str = "Hi"
            //newValue = "Hello"
            //result = "Hello"
            str = newValue;
        }
        public void Replace(char[] oldValue, char[] newValue)
        {
            //oldValue = "Hi"
            //newValue = "Hello"
            //result = "Hello
            int length = 0;
            char[] res;
            if (oldValue.Length < newValue.Length)
            {
                length = newValue.Length - oldValue.Length;
                res = new char[str.Length + length];
            }
            else
            {
                length = oldValue.Length - newValue.Length;
                res = new char[str.Length - length];
            }

            int ind = IndexOf(oldValue);

            for (int i = 0; i < str.Length; i++)
            {
                if (i >= ind && i < newValue.Length + i){}
                else
                {
                    res[i] = str[i];
                }
            }

            for (int i = ind, j = 0; i < res.Length; i++)
            {
                res[i] = newValue[j++];
            }
            str = res;
        }
        public void Trim(char ch)
        {
            //ch = ' '
            //this.str = "Hello, World!"
            //result = "Hello,World!"
            char[] res = new char[str.Length];
            int j = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                {
                    res[j++] = str[i];
                }
            }
            str = res;
        }
        public bool CompareTo(char[] str1, char[] str2)
        {
            //str1 = "Hello"
            //str2 = "Hello"
            if (str1.Length != str2.Length)
            {
                return false;
            }

            bool res = false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2[i])
                {
                    res = true;
                }
                else
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
