using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasoDeEstudoExtensionSIR.Helpers
{
    public sealed class SIRFieldTypeHelper
    {
        private static SIRFieldTypeHelper instance = null;
        private static readonly object padlock = new object();

        public List<SIRFieldType> Types { get; set; }

        SIRFieldTypeHelper()
        {
            Types = new List<SIRFieldType>();
            Types.Add(new SIRFieldType() { name = "CodigoPostal", size = "25", unit = "%" });
            Types.Add(new SIRFieldType() { name = "Telemovel", size = "9", unit = "em" });
            Types.Add(new SIRFieldType() { name = "NICP", size = "10", unit = "em" });
            Types.Add(new SIRFieldType() { name = "NIC", size = "75", unit = "%" });
            Types.Add(new SIRFieldType() { name = "CIN", size = "70", unit = "px" });
        }

        public static SIRFieldTypeHelper Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SIRFieldTypeHelper();
                    }
                    return instance;
                }
            }
        }
    }
}