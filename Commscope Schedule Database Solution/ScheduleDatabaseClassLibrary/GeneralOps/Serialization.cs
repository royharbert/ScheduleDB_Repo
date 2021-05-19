using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ScheduleDatabaseClassLibrary.GeneralOps
{
    public class Serialization
    {
        public static string SerializeToXml<T>(T value)
        {
            StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, value);
            return writer.ToString();
        }
        /// <summary>
        /// Returns list of type T from XML encoded string>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T DeserializeToList<T>(string xml)
        {
            T list = default(T);
            if (xml != null & xml != "")
            {
                // Create an instance of the XmlSerializer.
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                // Declare an object variable of the type to be deserialized.
                //T output;

                StringReader reader = new StringReader(xml);                
                list = (T)serializer.Deserialize(reader);               
            }
            return list;
        }
    }
}