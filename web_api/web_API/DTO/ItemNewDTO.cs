using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_API.DTO
{
    public class ItemNewDTO
    {
        public int itemId;
        public string name;
        //public string size;
        //  public string style;
        //  public string type;
        //  public string condition;
        public string description;
        public string image1;
        public string image2;
        public string image3;
        public string image4;
        public int numberOfPoints;
        public int sizeId;
        public int typeId;
        public int styleId;
        public int conditionId;
    }
}