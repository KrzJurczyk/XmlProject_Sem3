﻿using System.IO;
using System.Xml.Serialization;
using XML_Project_Sem3.DataContainers;

namespace XML_Project_Sem3.Config
{
    public class ModelCreator
    {
        #region Privte Fields

        private readonly DataProvider data = new DataProvider();

        #endregion

        #region Public Methods

        public void StartCreateXml()
        {
            var xmlCreator = new XmlCreator();
            xmlCreator.CreateWorld();

            XmlSerializer x = new XmlSerializer(typeof(WorldData));
            TextWriter writer = new StreamWriter(data.PathToProject + @"\projektXml.xml");
            x.Serialize(writer, xmlCreator.World);
        }

        #endregion
    }
}