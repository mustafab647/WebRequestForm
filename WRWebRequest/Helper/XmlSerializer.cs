using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRWebRequest.Helper
{
    public class XmlSerializer<T> where T : class,new()
    {
        public XmlSerializer() { }

        public T DeSerialize(string xmlStr)
        {
            T? result = default(T);
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] buffer = System.Text.UTF8Encoding.UTF8.GetBytes(xmlStr);
                ms.Write(buffer, 0, buffer.Length);
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                result = (T?)xmlSerializer.Deserialize(ms);
            }
            return result ?? new T();
        }
        public string Serialize(T obj)
        {
            string result = null;
            using(MemoryStream ms = new MemoryStream())
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                xmlSerializer.Serialize(ms, obj);
                byte[] buffer = ms.ToArray();
                result = System.Text.UTF8Encoding.UTF8.GetString(buffer);
            }
            return result;
        }
        public string Serialize(object obj)
        {
            string result = null;
            using (MemoryStream ms = new MemoryStream())
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                xmlSerializer.Serialize(ms, obj);
                byte[] buffer = ms.ToArray();
                result = System.Text.UTF8Encoding.UTF8.GetString(buffer);
            }
            return result;
        }
    }
}
