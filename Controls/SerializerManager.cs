using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TempMonitor.Controls.Sensors
{

    public static class SerializerManager
    {

        public static string OptionsFolder = Application.StartupPath + Path.DirectorySeparatorChar + "options" + Path.DirectorySeparatorChar;

        public static string OptionsFileName = "options.bin";

        public static string OptionsFile = OptionsFolder + OptionsFileName;


        /// <summary>
        /// Serializes an object to binary format
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {

            if (!Directory.Exists(Path.GetFullPath(OptionsFolder)))
            {
                Directory.CreateDirectory(OptionsFolder);
            }

                if (serializableObject == null) { return; }



            try
            {
                using (var stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(stream, serializableObject);
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }


        /// <summary>
        /// Deserializes an binary file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {

                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    objectOut = (T) bFormatter.Deserialize(stream);
                    stream.Close();
                }

                return objectOut;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
